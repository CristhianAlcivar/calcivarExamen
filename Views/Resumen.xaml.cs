namespace calcivarExamen.Views;

public partial class Resumen : ContentPage
{
	public Resumen(
        string usuario,
         string nombre,
        string apellido,
        object voltiamperio,
        DateTime fecha,
        object ciudad,
        string montoInicial,
        double cuotaMensual,
        double totalPagar
        )
	{
		InitializeComponent();
        txtUsuario.Text = "Usuario conectado " +  usuario;
        txtNombre.Text = nombre;
        txtApellido.Text = apellido;
        txtVa.Text = voltiamperio.ToString(); 
        txtFecha.Text = fecha.ToString("dd/MM/yyyy"); 
        txtCiudad.Text = ciudad.ToString();
        txtMontoInicial.Text = montoInicial;
        txtCuotaMensual.Text = cuotaMensual.ToString("F2");
        txtPagoTotal.Text = totalPagar.ToString("F2");
    }

    
    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Login());
    }
}