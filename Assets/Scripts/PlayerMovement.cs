using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Alex Musick 2020
//PlayerMovement should be attached to player gameobject
namespace am
{

    
    public class PlayerMovement : MonoBehaviour
    {
        [Header("Player Movement Speed")]
        public float rotationSpeed = 100f;
        public float thrustSpeed = 2f;
        

         // Start is called before the first frame update
         void Start()
        {
            if (GetComponent<Rigidbody2D>().gravityScale != 0 )
            {
                Debug.LogWarning(gameObject.name + "gravity should be set to 0");
            }
        }

        public void rotator(float rotatorInput)
        {
            //handles rotation input 
            transform.Rotate(0, 0, -Input.GetAxis("Horizontal")*
            rotationSpeed * Time.deltaTime);

        }

        public void velocity(float velocityInput)
        {
            //handles forward velocity with rigidbody
            GetComponent<Rigidbody2D>().
                AddForce(transform.up * thrustSpeed *
                Input.GetAxis("Vertical"));  
        }

        private void OnTriggerEnter2D(Collider2D other) 
        {
            if(other.gameObject.tag == "Asteroid")
            {
            //attemps to get player to reset on collision (wip)
            transform.position = new Vector3 (0,0,0);
            //remove velocity
            GetComponent<Rigidbody2D> ().
            velocity = new Vector3 (0,0,0);
            }
        }
    }
}
