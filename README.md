##### Hallo,
###### Dies ist mein erstes Github-Projekt.
###### Zunächst stelle ich eine einfache Webcam-Anwendung vor, die ich in C# geschrieben habe.
###### Ich habe ein Webcam-Bild mit einer einzelnen Komponente in einer einfachen Picturebox gezeigt.

![](https://s20.directupload.net/images/230122/u4oyapd6.jpg)

###### Wie ich oben erwähnt habe, habe ich nur eine Komponente verwendet.

```csharp
private void webCamCapture1_ImageCaptured(object source, WebCam_Capture.WebcamEventArgs e)
    {
      pictureBox1.Image = e.WebCamImage;
    }
```
