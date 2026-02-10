Imports System.IO
Imports DataBase
Imports Microsoft.Extensions.Configuration
Imports Microsoft.Extensions.DependencyInjection

Module Dependencias
    Private _serviceProvider As IServiceProvider

    Public Sub Configurar()
        Dim servicios As New ServiceCollection()

        Dim config = New ConfigurationBuilder() _
            .SetBasePath(Directory.GetCurrentDirectory()) _
            .AddJsonFile("appsettings.json", optional:=False, reloadOnChange:=True) _
            .Build()

        servicios.AddSingleton(Of IConfiguration)(config)
        servicios.AddTransient(Of IUsuarioService, UsuarioService)()
        _serviceProvider = servicios.BuildServiceProvider()
    End Sub

    Public Function CreateScope() As IServiceScope
        Return _serviceProvider.CreateScope()
    End Function
End Module