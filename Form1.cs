#pragma warning disable CA1416
using System;
using System.Windows.Forms;

namespace ImageViewerSuccession;

public partial class Form1 : Form
{
    private Uri _blankPage = new("about:blank");

    public Form1()
    {
        InitializeComponent();
        SetImage(false);
    }

    private void SetImage(bool addImage, string imagePath = "")
    {
        if (addImage)
        {
            picture.Source = new Uri(imagePath);
            lblFileStatus.Text = $"Loaded image: {imagePath}";
        }
        else
        {
            picture.Source = _blankPage;
            lblFileStatus.Text = "No image loaded!";
        }
    }

    private void btnOpen_Click(object sender, EventArgs e)
    {
        filePicker.ShowDialog();

        if (filePicker.FileName == "") // Because this doesn't return null, for some reason
        {
            SetImage(false);
        }
        else
        {
            SetImage(true, filePicker.FileName);
        }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        SetImage(false);
    }

    private void numZoom_ValueChanged(object sender, EventArgs e)
    {
        // https://stackoverflow.com/questions/10915958/how-to-zoom-an-image-inout-in-c
        // The solution I decided on was embedding a web browser, and modifying the zoom of the webpage
        picture.ZoomFactor = Convert.ToInt16(numZoom.Value);
    }
}