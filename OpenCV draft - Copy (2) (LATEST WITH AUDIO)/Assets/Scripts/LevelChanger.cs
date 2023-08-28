using UnityEngine;
using UnityEngine.SceneManagement;

using OpenCvSharp.Demo;
using OpenCvSharp;

public class LevelChanger : MonoBehaviour
{
    public int sceneBuildIndex;
    
    public GameObject ant;

    private WebCamera camera;

    //public static WebCamera webCamera;

    private void Start()
    {
        camera =  ant.GetComponent<WebCamera>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger entered");

      
        //webCamera = other.GetComponent<WebCamera>();


        if(other.tag == "Player")
        {
            print ("Switching scene to " + sceneBuildIndex);

            camera.OnDestroy();



            //webCamera = other.GetComponent<WebCamera>();
            //webCamera.webCamTexture.Stop();

            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
         }
    }




}
