using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using OpenCvSharp.Demo;

public class ChangeSprite : MonoBehaviour
{
    public Sprite start, game;

    public GameObject ant;
    public int sceneBuildIndex;

    private WebCamera camera;

    private void Start()
    {
        camera = ant.GetComponent<WebCamera>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().sprite = start;
        }
        
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetComponent <SpriteRenderer>().sprite = game;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {


            print("Play entered");

            print("Switching scene to " + sceneBuildIndex);

            camera.OnDestroy();

            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        }
    }
}
