using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camracontrole : MonoBehaviour
{
    // create a public referenc to the plaer - we assign this using the editor 
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //chnage our position relative to the player postion 
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z);

    }
}
 