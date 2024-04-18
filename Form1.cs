#pragma warning disable CA1416
using System;
using System.Windows.Forms;

namespace ImageViewerSuccession;

public partial class Form1 : Form
{
    private Uri _blankPage = new Uri("about:blank");

    public Form1()
    {
        InitializeComponent();
        lblFileStatus.Text = "No image loaded!";
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

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
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

    private void clearToolStripMenuItem_Click(object sender, EventArgs e)
    {
        SetImage(false);
    }

    private void btnResize_Click(object sender, EventArgs e)
    {
        // https://stackoverflow.com/questions/10915958/how-to-zoom-an-image-inout-in-c
        // The solution I decided on was embedding a web browser, and modifying the zoom of the webpage
        if (String.IsNullOrEmpty(txtZoom.Text))
        {
            MessageBox.Show("Can't resize image when the zoom factor is null or empty!");
        }
        else
        {
            int zoomFactor = Convert.ToInt32(txtZoom.Text);
            picture.ZoomFactor = zoomFactor;
        }
    }


    private void txtZoom_TextChanged(object sender, EventArgs e)
    {
        /* Todo

        if (!txtZoom.Text.EndsWith("%"))
        {
            txtZoom.Text += "%";
        }
        */
    }
}