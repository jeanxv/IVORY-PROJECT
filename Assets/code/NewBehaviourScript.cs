using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //create a public array  of object to spawn , we will fill this up using the Editor
    public GameObject[] objectToSpawn;

    float timeToNextSpawn; //Tracks how long we should wait before spawnign a new object 
    float timeSinceLastSpawn = 0.0f; // Track the time since we last spawn something 

    public float minSpawnTime = 0.5f; //minimum amont of time between   spawning objects 
    public float maxSpawnTime = 3.0f; //max time between spawning objects

    // Start is called before the first frame update
    void Start()
    {
        //random. range return a random float between to values 
        timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        // Add time.detatime return the amount of time passed since the last frame 
        // this will creat a float that count up in seconds 
        timeSinceLastSpawn = timeSinceLastSpawn + Time.deltaTime;

        //if we've counyed pastthe amount of time we need to wait
        if (timeSinceLastSpawn > timeToNextSpawn)
        {
            //use random.range to pick a nujber between 0 and the amount of the item on our list 
            int selection = Random.Range(2, objectToSpawn.Length);

            //Instantiate spawn a gameobject- in this case we tell it ti spawna game object from our objecToSpawn list
            //the second premeter in the brakets tells it where tp spawn se we've entered the position of the spawner. 
            // the third paramete is fro rotation and quataernion.identity means no rotation 
            Instantiate(objectToSpawn[selection], transform.position, Quaternion.identity);

            // after spawning, we select a new random rime for the next spawn and set our time back to zero
            timeToNextSpawn = Random.Range(minSpawnTime, maxSpawnTime);
            timeSinceLastSpawn = 0.0f;



        }
        
      }
    
}
