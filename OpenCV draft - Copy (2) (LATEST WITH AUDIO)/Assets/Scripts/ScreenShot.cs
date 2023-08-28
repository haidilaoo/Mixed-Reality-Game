using OpenCVForUnityExample;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    public TextRecognitionExample TextRecognition;
    public ChangeScene changeScene;

    private void Start()
    {
        StartCoroutine(Play());
    }

    // Update is called once per frame
    void Update()
    {
        

        //if (Input.GetKeyUp(KeyCode.Space)) //remove this such that it updates in real time but will cause alot of useless screenshots
       // {
/*            string folderPath = "Assets/StreamingAssets/OpenCVForUnity/text/";

            //if StreamingAssets or Text file DNE, will be created
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            var screenshotName = "ScreenShot_" + System.DateTime.Now.ToString("dd-MM-yy-HH-mm-ss") + ".jpg";

            ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName), 2);

            Debug.Log(folderPath + screenshotName);

            TextRecognition.imagename = screenshotName;

            Invoke("CallStartProcess", 1);*/

       // }

    }

    //add coroutine to take screenshots every 10 seconds 
    //will cause lag everytime screenshot is taken

    IEnumerator Play()
    {
        while (true)
        {
            yield return new WaitForSeconds(10);
            yield return new WaitForEndOfFrame();
            string folderPath = "Assets/StreamingAssets/OpenCVForUnity/text/";

            //if StreamingAssets or Text file DNE, will be created
            if (!System.IO.Directory.Exists(folderPath))
            {
                System.IO.Directory.CreateDirectory(folderPath);
            }

            var screenshotName = "ScreenShot_" + System.DateTime.Now.ToString("dd-MM-yy-HH-mm-ss") + ".jpg";

            ScreenCapture.CaptureScreenshot(System.IO.Path.Combine(folderPath, screenshotName), 2);

            Debug.Log(folderPath + screenshotName);

            TextRecognition.imagename = screenshotName;

            Invoke("CallStartProcess", 1);
        }
    }

    void CallStartProcess()
    {
        TextRecognition.StartProcess();
        //changeScene.destroyCam();

    }
}