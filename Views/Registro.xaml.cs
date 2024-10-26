namespace calcivarExamen.Views;

public partial class Registro : ContentPage
{
    private double costoUPS = 300.0;
    private double cuotaMensual = 0;
    private string usuarioConectado;

    public Registro(string usuario)
	{
		InitializeComponent();
        usuarioConectado = usuario;
        txtUsuario.Text = "Usuario conectado "+ usuario;
    }

    private void OnCalcularPagoClicked(object sender, EventArgs e)
    {
        int montoInicial = int.Parse(txtMonto.Text);

        if (montoInicial >= costoUPS || montoInicial <= 0)
        {
            Console.WriteLine("El monto inicial debe ser mayor que 0 y menor que el costo total del UPS.");
            return;
        }

        double restante = costoUPS - montoInicial;
        double cuotaConInteres = (restante / 3) * 1.05;

        txtPago.Text = cuotaConInteres.ToString();
        cuotaMensual = cuotaConInteres;
    }
    private void OnResumenClicked(object sender, EventArgs e)
    {
        int montoInicial = int.Parse(txtMonto.Text);
        Navigation.PushAsync(new Resumen(
            usuarioConectado,
            txtNombre.Text,
            txtApellido.Text,
            pickerVoltiamperio.SelectedItem,
            txtFecha.Date,
            pickerCiudad.SelectedItem,
            txtMonto.Text,
            cuotaMensual,
            (cuotaMensual * 3) + montoInicial
            ));
    }

}