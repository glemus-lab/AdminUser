USE master;
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'ControlUsuario')
BEGIN
    CREATE DATABASE ControlUsuario;
END
GO

USE ControlUsuario;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usuarios]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Usuarios] (
        [Id] INT IDENTITY(1,1) PRIMARY KEY,
        [Username] VARCHAR(15) NOT NULL,
        [NombreCompleto] VARCHAR(60) NOT NULL,
        [Correo] VARCHAR(60) NOT NULL,
        [PasswordHash] BINARY(100) NOT NULL,
        [Salt] VARCHAR(100) NOT NULL

    	CONSTRAINT UQ_Usuarios_UserName UNIQUE (UserName)
    );
END
GO

-- Procedimiento almacenado: List
CREATE OR ALTER PROCEDURE [dbo].[sp_listar_usuarios]
AS
BEGIN
    SELECT Id, Username, NombreCompleto, Correo FROM Usuarios;
END
GO

-- Procedimiento almacenado: Insert
CREATE OR ALTER PROCEDURE [dbo].[sp_insertar_usuario]
    @pUsername VARCHAR(15),
    @pNombreCompleto VARCHAR(60),
    @pCorreo VARCHAR(60),
    @pPassword VARCHAR(100)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM Usuarios WHERE UserName = @pUsername)
    BEGIN
        RAISERROR('El username ya se encuentra registrado.', 16, 1)
        RETURN;
    END

	DECLARE @NewSalt AS VARCHAR(50) = NewID()
	DECLARE @PasswordHash AS VARBINARY(100)

	SET @PasswordHash = HASHBYTES('SHA2_256', @pPassword + CAST(@NewSalt AS VARCHAR))

    INSERT INTO Usuarios (Username, NombreCompleto, Correo, PasswordHash, Salt)
    VALUES (@pUsername, @pNombreCompleto, @pCorreo, @PasswordHash, @NewSalt);
END
GO

-- Stored Procedure: Update
CREATE OR ALTER PROCEDURE [dbo].[sp_update_usuario]
    @pId INT,
    @pNombreCompleto VARCHAR(60),
    @pCorreo VARCHAR(60),
    @pPassword VARCHAR(100) = NULL
AS
BEGIN
	DECLARE @PasswordHash as BINARY(100) = NULL
	DECLARE @NewSalt as VARCHAR(100) = NULL

	If	@pPassword IS NOT NULL AND LEN(TRIM(@pPassword)) > 0
	BEGIN
		SET @NewSalt = NewID()
		SET @PasswordHash = HASHBYTES('SHA2_256', @pPassword + CAST(@NewSalt AS VARCHAR))
	END

    UPDATE Usuarios
    SET NombreCompleto = @pNombreCompleto,
        Correo = @pCorreo,
        PasswordHash = CASE WHEN @PasswordHash IS NOT NULL THEN @PasswordHash ELSE PasswordHash END,
        Salt = CASE WHEN @PasswordHash IS NOT NULL THEN @NewSalt ELSE Salt END
    WHERE Id = @pId;
END
GO

-- Procedimiento almacenado: Delete
CREATE OR ALTER PROCEDURE [dbo].[sp_delete_usuario]
    @pId INT
AS
BEGIN
    DELETE FROM Usuarios WHERE Id = @pId;
END
GO

-- Procedimiento almacenado: Validate
CREATE OR ALTER PROCEDURE [dbo].[sp_validar_usuario]
    @pUserName VARCHAR(15),
    @pPassword VARCHAR(100),
	@pEsValido BIT OUTPUT
AS
BEGIN
    if @pUserName IS NOT NULL AND @pPassword IS NOT NULL
	BEGIN
	    IF EXISTS (
			SELECT 1 FROM Usuarios 
			WHERE UserName = @pUserName AND PasswordHash = HASHBYTES('SHA2_256', @pPassword + CAST(Salt AS VARCHAR))
		)
		BEGIN
			SET @pEsValido = 1
		END
		ELSE
		BEGIN
			SET @pEsValido = 0
		END
	END
END
GO