using System;
using System.Windows.Forms;

namespace WindowsApplication1
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void webCamCapture1_ImageCaptured(object source, WebCam_Capture.WebcamEventArgs e)
    {
      pictureBox1.Image = e.WebCamImage;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      webCamCapture1.Start(0);
    }

    private void button2_Click(object sender, EventArgs e)
    {
      webCamCapture1.Stop();
    }
  }
}