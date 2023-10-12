using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class destroyer : MonoBehaviour
{
    // March Like the Start() and updated() method , ontriggerenter2D is  A special unity method that is called
    // by unity automaticaly at a specific point - in thhis caes , when something enter the trigger attached 
    // to this gameobject 
     private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the gan#me object that has collided withour trigger is trigged with Cleanup
        if (collision.gameObject.tag == "Cleanup")
        { // Then we use this method to destroy it
            Destroy(collision.gameObject);
         
        }
    }

 
}
