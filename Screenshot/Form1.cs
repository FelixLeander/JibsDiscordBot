using System.Diagnostics;

namespace Screenshot;

public partial class Form1 : Form
{
    string _dirPath = Environment.CurrentDirectory;
    Bitmap _bitmap;

    public Form1()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e) => buttonSetBox.Enabled = !checkBox1.Checked;
    private void ButtonOpenDir_Click(object sender, EventArgs e)
    {
        Process.Start("explorer.exe", _dirPath);
    }
    private void NumericUpDown_ValueChanged(object sender, EventArgs e)
    {
        if (checkBox1.Checked)
        {
            SetBox();
        }
    }
    private void ButtonSetBox_Click(object sender, EventArgs stihn) => SetBox();
    private void SetBox() => CaptureScreen((int)numericUpDownStartX.Value, (int)numericUpDownStartY.Value, 0, 0, new Size((int)numericUpDownSizeX.Value + 10, (int)numericUpDownSizeY.Value + 10));

    private void CaptureScreen(int sourceX, int sourceY, int destX, int destY, Size regionSize)
    {
        Bitmap bitmap = new Bitmap(regionSize.Width, regionSize.Height);
        Graphics.FromImage(bitmap).CopyFromScreen(sourceX, sourceY, destX, destY, regionSize);
        pictureBox1.Image = bitmap;
        _bitmap = bitmap;
    }

    private void ButtonSaveImage_Click(object sender, EventArgs e) => Clipboard.SetImage(_bitmap);
}