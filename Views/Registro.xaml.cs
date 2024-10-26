namespace calcivarExamen.Views;

public partial class Registro : ContentPage
{
    public string usuario { get; set; }
    private double costoUPS = 300.0;

    public Registro(string usuario)
	{
		InitializeComponent();
        usuario = usuario;
        BindingContext = this;
    }

    private void OnCalcularPagoClicked(object sender, EventArgs e)
    {
        int montoInicial = Int32.Parse(txtMonto.Text);

        if (montoInicial >= costoUPS || montoInicial <= 0)
        {
            Console.WriteLine("El monto inicial debe ser mayor que 0 y menor que el costo total del UPS.");
            return;
        }

        double restante = costoUPS - montoInicial;
        double cuotaConInteres = (restante / 3) * 1.05;

        txtPago.Text = cuotaConInteres.ToString();
    }
    private void OnResumenClicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new Resumen());
    }

}