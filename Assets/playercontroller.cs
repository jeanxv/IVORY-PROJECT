using System.Collections;
using System.Collections.Generic;
using Unity.PlasticSCM.Editor.WebApi;
using Unity.VisualScripting;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public GameObject groundChecker;
    public LayerMask whatIsGround;
    float maxspeed = 8.0f;
    bool isOneGround = false;
    float jumpForce = 5.0f;

    //Create a refernce to the Rigidbody2D so we can manipulate it 
    Rigidbody2D playerObject;

    // Start is called before the first frame update
    void Start()
    {
        //Find the Rigidbody2D component that is attached to the same object as the script
        playerObject = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        //Crreate a 'float' that will be eqal to the players horezontal input 
        float movementValueX = Input.GetAxis("Horizontal");

        //chnage the x velocity of the rigidbody 2D to be eqal to the movement 
        playerObject.velocity = new Vector2(movementValueX * 10, playerObject.velocity.y);

        //chech to see if the ground checker object is touchuing the ground 
        isOneGround = Physics2D.OverlapCircle(groundChecker.transform.position, 1.0f, whatIsGround);

        if ((isOneGround == true) && (Input.GetAxis("Jump") > 0.0f))
        {
            playerObject.AddForce(Vector2.up * jumpForce);
        }
    }
}
      



            

    