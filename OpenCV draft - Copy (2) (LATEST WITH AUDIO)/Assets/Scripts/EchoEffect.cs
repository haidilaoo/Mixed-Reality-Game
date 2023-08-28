using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EchoEffect : MonoBehaviour
{

    public float timeBtwSpawn;
    public float startTimeBtwSpawns;

    [Range(0,10)]
    [SerializeField] int occurAfterVelocity;

    public GameObject echo;
    //private Player player;

    public GameObject player;

    private void Start()
    {
        //player = GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.transform.hasChanged)
            {

            if (timeBtwSpawn <= 0)
            {
                //spawn echo game object
                //Vector3 newPosition = new Vector3(transform.position.x, transform.position.y , transform.position.z );
                GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
                Destroy(instance, 8f);
               // Instantiate(echo, transform.position, Quaternion.identity);
                timeBtwSpawn = startTimeBtwSpawns;
                transform.hasChanged = false;
            }
            else
            {
                timeBtwSpawn -= Time.deltaTime;
            }
        }
    }
}
