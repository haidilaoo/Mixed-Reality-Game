using OpenCvSharp;
using OpenCvSharp.Demo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContourFinder : WebCamera
{
    [SerializeField] private FlipMode ImageFlip;
    [SerializeField] private float Threshold = 96.4f;
    [SerializeField] private bool ShowProcessingImage = true;
    [SerializeField] private float CurveAccuracy = 10f;
    [SerializeField] private float MinArea = 5000f;

    //COLLIDER PROPERTIES
    [SerializeField] private PolygonCollider2D PolygonCollider;

    //Line Rendering 
    [SerializeField] private LineRenderer LineRenderer;

    private Mat image;
    private Mat processImage = new Mat();
    private Point[][] contours;
    private HierarchyIndex[] hierarchy;

    //COLLIDER PROPERTIES
    private Vector2[] vectorList;

    //Line Rendering
    private Vector3[] vector3List;

    protected override bool ProcessTexture(WebCamTexture input, ref Texture2D output)
    {
        image = OpenCvSharp.Unity.TextureToMat(input);
       

        Cv2.Flip(image, image, ImageFlip);
        Cv2.CvtColor(image, processImage, ColorConversionCodes.BGR2GRAY);
        Cv2.Threshold(processImage, processImage, Threshold, 255, ThresholdTypes.BinaryInv);
        Cv2.FindContours(processImage, out contours, out hierarchy, RetrievalModes.Tree, ContourApproximationModes.ApproxSimple, null);

        //COLLIDER PROPERTIES
        PolygonCollider.pathCount = 0;

        //Line Rendering
        LineRenderer.positionCount = 0;

        foreach (Point[] contour in contours)
        {
            Point[] points = Cv2.ApproxPolyDP(contour, CurveAccuracy, true);
            var area = Cv2.ContourArea(contour);

            if(area > MinArea)
            {
                drawContour(processImage, new Scalar(127, 127, 127), 2, points);

                //COLLIDER PROPERTIES
                PolygonCollider.pathCount++;
                PolygonCollider.SetPath(PolygonCollider.pathCount - 1, toVector2(points));

                

                //Line Rendering 
                LineRenderer.positionCount++;
                LineRenderer.SetPositions(toVector3(points));
            }
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



    private void drawContour(Mat Image, Scalar Color, int Thickness, Point[] Points)
    {
        for(int i=1; i< Points.Length; i++)
        {
            Cv2.Line(Image, Points[i - 1], Points[i], Color, Thickness);
        }

        Cv2.Line(Image, Points[Points.Length - 1], Points[0], Color, Thickness);   
    }

    //COLLIDER PROPERTIES
    private Vector2[] toVector2(Point[] points)
    {
        vectorList = new Vector2[points.Length];
        for(int i=0; i< points.Length; i++)
        {
            vectorList[i] = new Vector2(points[i].X, points[i].Y);
        }

        return vectorList;

    }

    //Line Rendering
    private Vector3[] toVector3(Point[] points)
    {
        vector3List = new Vector3[points.Length];
        for (int i = 0; i < points.Length; i++)
        {
            vector3List[i] = new Vector3(points[i].X, points[i].Y, 0.0f);
        }

        return  vector3List;
    }

}
