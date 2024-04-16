#pragma warning disable CA1416
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ImageViewerSuccession;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        toolStrip_fileStatus.Text = "No image loaded!";
    }

    private void SetImage(bool addImage, string imagePath = "")
    {
        if (addImage)
        {
            pictureBox1.Image = Image.FromFile(imagePath);
            toolStrip_fileStatus.Text = $"Loaded image: {imagePath}";
        }
        else
        {
            pictureBox1.Image = null;
            toolStrip_fileStatus.Text = "No image loaded!";
        }
    }

    private void openToolStripMenuItem_Click(object sender, EventArgs e)
    {
        filePicker.ShowDialog();
        Console.WriteLine(filePicker.FileName);

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
}