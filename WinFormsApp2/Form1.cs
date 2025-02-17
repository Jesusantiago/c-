namespace WinFormsApp2;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btn1_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtName.Text) && !lstNames.Items.Contains(txtName.Text))
            lstNames.Items.Add(txtName.Text);
        

    }

    private void Names_Load(object sender, EventArgs e)
    {
        throw new System.NotImplementedException();
    }
}