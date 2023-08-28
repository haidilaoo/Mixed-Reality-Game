/*using OpenCvSharp;
using OpenCvSharp.Demo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealTimeText : WebCamera
{
    [SerializeField] private FlipMode ImageFlip;
    [SerializeField] private float Threshold = 96.4f;
    [SerializeField] private bool ShowProcessingImage = true;
    [SerializeField] private float CurveAccuracy = 10f;
    [SerializeField] private float MinArea = 5000f;

    private Mat image;
    private Mat processImage = new Mat();
    private Point[][] contours;
    private HierarchyIndex[] hierarchy;

    //Text Recognition 
    public UnityEngine.Texture2D texture;
    public UnityEngine.TextAsset model;

    protected override bool ProcessTexture(WebCamTexture input, ref Texture2D output)
    {
        image = OpenCvSharp.Unity.TextureToMat(input);

        Cv2.Flip(image, image, ImageFlip);
        Cv2.CvtColor(image, processImage, ColorConversionCodes.BGR2GRAY);
        Cv2.Threshold(processImage, processImage, Threshold, 255, ThresholdTypes.BinaryInv);
        Cv2.FindContours(processImage, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple, null);

        // some constants for drawing
        const int textPadding = 2;
        const HersheyFonts textFontFace = HersheyFonts.HersheyPlain;
        double textFontScale = System.Math.Max(this.texture.width, this.texture.height) / 512.0;
        Scalar boxColor = Scalar.DeepPink;
        Scalar textColor = Scalar.White;

        // load alphabet
        AlphabetOCR alphabet = new AlphabetOCR(model.bytes);

        //Scan Webcam
        // image = Unity.TextureToMat(this.texture);
        IList<AlphabetOCR.RecognizedLetter> letters = alphabet.ProcessImage(image);
       
        foreach (var letter in letters)
        {
            int line;
            var bounds = Cv2.BoundingRect(letter.Rect);

            // text box.
            var textData = string.Format("{0}: {1}%", letter.Data, System.Math.Round(letter.Confidence * 100));
            var textSize = Cv2.GetTextSize(textData, textFontFace, textFontScale, 1, out line);
            var textBox = new Rect(
                bounds.X + (bounds.Width - textSize.Width) / 2 - textPadding,
                bounds.Bottom,
                textSize.Width + textPadding * 2,
                textSize.Height + textPadding * 2
            );

            // draw shape
            image.Rectangle(bounds, boxColor, 2);
            image.Rectangle(textBox, boxColor, -1);
            image.PutText(textData, textBox.TopLeft + new Point(textPadding, textPadding + textSize.Height), textFontFace, textFontScale, textColor, (int)(textFontScale + 0.5));
        }

        if (output == null)
        {
            output = OpenCvSharp.Unity.MatToTexture(ShowProcessingImage ? processImage : image);
        }
        else
        {
            OpenCvSharp.Unity.MatToTexture(ShowProcessingImage ? processImage : image, output);
        }


        return true;
    }

        // Start is called before the first frame update
 
}
*/