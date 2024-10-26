namespace calcivarExamen.Views;

public partial class Login : ContentPage
{
    private Dictionary<string, string> usuarios = new Dictionary<string, string>()
    {
        { "estudiante2024", "uisrael2024" },
        { "examen1", "parcial1" },
        { "Cristhian", "2024" }
    };
    public Login()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Acerca de", "UNIVERSIDAD TECNOLOGICA ISRAEL \n Desarrollado por: Cristhian Alcivar \n Cargo: Desarrollador Fullstack  \n Desarrollador el: 25-10-2024", "OK");
    }
    private void OnLoginClicked(object sender, EventArgs e)
    {
        string inputUsuario = txtUsuario.Text;
        string inputContrasena = txtContraseña.Text;

        if (usuarios.ContainsKey(inputUsuario))
        {
            string storedPassword = usuarios[inputUsuario];

            if (storedPassword == inputContrasena)
            {
                Navigation.PushAsync(new Registro(inputUsuario));
            }
            else
            {
                DisplayAlert("Error", "Usuario o contraseña incorrecto", "OK");
            }
        }
        else
        {
            DisplayAlert("Error", "Usuario no registrado", "OK");
        }
    }
}