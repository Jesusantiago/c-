namespace WinFormsApp2;

public partial class Ejercicio2_clase_descuentos : Form
{
    public Ejercicio2_clase_descuentos()
    {
        InitializeComponent();
    }
    
    private void Ejercicio2_clase_descuentos_Load(object sender, EventArgs e)
    {
        txtDescuento.Enabled = false;
        precioTotal.Enabled = false;
        throw new System.NotImplementedException();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string user = inputUser.Text;
        int precio = int.Parse(user);
        double descuento = 0;
        double precioConDescuento = 0;
        if (precio > 5 & precio <= 10)
        {
            descuento = precio * 0.05;
            txtDescuento.Text = descuento.ToString();
            precioConDescuento = precio * 0.95;
            precioTotal.Text = precioConDescuento.ToString();
        } else if (precio > 10 & precio <= 15)
        {
            descuento = precio * 0.10;
            txtDescuento.Text = descuento.ToString();
            precioConDescuento = precio * 0.90;
            precioTotal.Text = precioConDescuento.ToString();
        } else if (precio > 15)
        {
            descuento = precio * 0.015;
            txtDescuento.Text = descuento.ToString();
            precioConDescuento = precio * 0.85;
            precioTotal.Text = precioConDescuento.ToString();
        }
        else
        {
            MessageBox.Show("El precio no puede tener descuento.");
        }
        

      // throw new System.NotImplementedException();
    }


}