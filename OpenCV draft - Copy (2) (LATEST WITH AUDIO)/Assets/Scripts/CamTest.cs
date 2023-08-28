//To possibly fix
//problem of
//after Stopping playmode, camera stays on (with the light on), and the only way to free it is to close the unity editor/unplug camera.


using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CamTest : MonoBehaviour
{

    static WebCamTexture liveFeed;
    public RawImage feed;

    IEnumerator Start()
    {
        yield return Application.RequestUserAuthorization(UserAuthorization.WebCam);

        if (Application.HasUserAuthorization(UserAuthorization.WebCam))
        {
            if (!liveFeed)
                liveFeed = new WebCamTexture();
            liveFeed.Play();

            feed.texture = new Texture2D(liveFeed.width, liveFeed.height, TextureFormat.RGBA32, false);
        }
        else
            Debug.LogWarning("Camera access not obtained!");


    }
    void OnDisable()
    {
        if (liveFeed && liveFeed.isPlaying)
            liveFeed.Stop();
    }

    void Update()
    {
        if (liveFeed && liveFeed.didUpdateThisFrame)
        {
            Color32[] buffer = liveFeed.GetPixels32();
            (feed.texture as Texture2D).SetPixels32(buffer);
            (feed.texture as Texture2D).Apply();
            Debug.Log("ding");
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(gameObject.scene.name);
        }
    }
}