namespace WinFormsApp2;

public partial class Ejercicio1_clase_numeroPar : Form
{
    public Ejercicio1_clase_numeroPar()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        string txt = inputTxt.Text;
        int num = int.Parse(txt);
        if ( num % 2 == 0)
        {
            MessageBox.Show("El numero ingresado es Par!");
        }
        else
        {
            MessageBox.Show("El numero ingresado es Impar!");
        }
    }


}