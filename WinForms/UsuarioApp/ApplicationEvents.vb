
Namespace My
    Partial Friend Class MyApplication
        ' 1. Inicializar el contenedor
        Private Sub MyApplication_Startup(sender As Object, e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dependencias.Configurar()
        End Sub

        Private Sub MyApplication_UnhandledException(sender As Object, e As ApplicationServices.UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim mensaje As String = $"Ocurrió un error inesperado: {e.Exception.Message}"

            MessageBox.Show(mensaje, "Error Crítico.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.ExitApplication = True
        End Sub
    End Class
End Namespace
