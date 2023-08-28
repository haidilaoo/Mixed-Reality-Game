using OpenCvSharp;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    private LineRenderer LineRenderer;

    //Line Rendering
    private Vector3[] vector3List;

    [SerializeField] private Transform[] colliderTransform;
    
    // Start is called before the first frame update
    void Start()
    {
        LineRenderer = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        LineRenderer.positionCount = 0;

        /* lineRenderer.positionCount = colliderTransform.Length;
         for (int i = 0; i < colliderTransform.Length; i++)
         {
             lineRenderer.SetPosition(i, colliderTransform[i].position);
         }
 */

/*        for (int i = 0; i < ContourFinder.contours.Length; i++)
        {
            Point[] contour = ContourFinder.contours[i];
            Point[] points = Cv2.ApproxPolyDP(contour, CurveAccuracy, true);
            var area = Cv2.ContourArea(contour);

            if (area > MinArea)
            {
                drawContour(processImage, new Scalar(127, 127, 127), 2, points);

                //COLLIDER PROPERTIES
                PolygonCollider.pathCount++;
                PolygonCollider.SetPath(PolygonCollider.pathCount - 1, toVector2(points));



                //Line Rendering 
                LineRenderer.positionCount++;
                LineRenderer.SetPositions(toVector3(points));
            }
        }*/
    }
}
