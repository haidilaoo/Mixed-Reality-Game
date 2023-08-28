using OpenCVForUnityExample;
using OpenCvSharp.Demo;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    //private TextRecognitionExample TextRecog;
    public GameObject ant;
    public int sceneBuildIndex;

    private WebCamera camera;
    private void Start()
    {
        camera = ant.GetComponent<WebCamera>();

        //TextRecog = cube.GetComponent<TextRecognitionExample>();
    }

    //to handle scene transitions that invole webcams (e.g Main -> Start -> End)
    public void Change()
    {
        print("Play entered");


        //webCamera = other.GetComponent<WebCamera>();
      
            print("Switching scene to " + sceneBuildIndex);

            camera.OnDestroy();

            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }

    //to handle End -> Main no webcam involved
   
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    //another alternative to start as text recognition of play not 100% effective
    public void StartGame()
    {
       if ( Input.GetKeyDown(KeyCode.Space))
        print("Play entered");

        print("Switching scene to " + sceneBuildIndex);

        camera.OnDestroy();

        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }

    }
