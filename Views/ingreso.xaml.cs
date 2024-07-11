using System.Net;

namespace GsantyTS6.Views;

public partial class ingreso : ContentPage
{
    public ingreso()
    {
        InitializeComponent();
    }

    private void btnRegistro_Clicked(object sender, EventArgs e)
    {
        try
        {
            WebClient cliente = new WebClient();
            var parametros = new System.Collections.Specialized.NameValueCollection();
            parametros.Add("nombre", txtNombres.Text);
            parametros.Add("apellido", txtApellidos.Text);
            parametros.Add("direccion", txtDireccion.Text);
            parametros.Add("telefono", txtTelefono.Text);
            parametros.Add("email", txtEmail.Text);
            parametros.Add("contrasena", txtContrasena.Text);
            cliente.UploadValues("http://127.0.0.1:8080/semana6/estudiantews.php", "POST", parametros);
            Navigation.PushAsync(new Views.inicio());
        }
        catch (Exception ex)
        {
            DisplayAlert("Alerta", ex.Message, "Cerrar");

        }
    }
}