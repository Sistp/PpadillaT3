namespace PpadillaT3.Vistas;

public partial class vLogin : ContentPage
{
	public vLogin()
	{
		InitializeComponent();
	}

    private void btnIniciar_Clicked(object sender, EventArgs e)
    {
        string usuario = "Carlos";
        string contrase�a = "Carlos123";
        string usuario2 = "Ana";
        string contrase�a2 = "Ana123";
        string usuario3 = "Jose";
        string contrase�a3 = "Jose123";

        if (txtUsuario.Text == usuario && txtContrasena.Text == contrase�a)
        {
            string mensajeBienvenida = "�Bienvenido, " + usuario + "!";
            DisplayAlert("Bienvenida", mensajeBienvenida, "Aceptar");
            Navigation.PushAsync(new Calificaciones(usuario));
        }
        else if (txtUsuario.Text == usuario2 && txtContrasena.Text == contrase�a2)
        {
            string mensajeBienvenida = "�Bienvenida, " + usuario2 + "!";
            DisplayAlert("Bienvenida", mensajeBienvenida, "Aceptar");
            Navigation.PushAsync(new Calificaciones(usuario2));
        }
        else if (txtUsuario.Text == usuario3 && txtContrasena.Text == contrase�a3)
        {
            string mensajeBienvenida = "�Bienvenido, " + usuario3 + "!";
            DisplayAlert("Bienvenida", mensajeBienvenida, "Aceptar");
            Navigation.PushAsync(new Calificaciones(usuario3));
        }
        else
        {
            DisplayAlert("ALERTA", "USUARIO/CONTRASE�A INCORRECTOS", "CANCELAR");
        }


    }
}