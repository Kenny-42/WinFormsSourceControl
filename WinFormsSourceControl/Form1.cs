namespace WinFormsSourceControl;
public partial class FormAreaAndPerimeterCalculator : Form
{
    public FormAreaAndPerimeterCalculator()
    {
        InitializeComponent();
    }

    private void BtnCalculate_Click(object sender, EventArgs e)
    {
        int length = Convert.ToInt32(txtLength.Text);
        int width = Convert.ToInt32(txtWidth.Text);

        int area = length * width;
        int perimeter = 2 * (length + width);

        txtArea.Text = "Area is: " + area;
        txtPerimeter.Text = "Perimeter is: " + perimeter;
    }
}
