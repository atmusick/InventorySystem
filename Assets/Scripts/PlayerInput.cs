using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using am;
//Alex Musick 2020 
//Should be attached to player gameobject

public class PlayerInput : MonoBehaviour
{
    //using playermovement in same namespace "am"
    PlayerMovement controller;

    // Start is called before the first frame update
    void Start()
    {
        //controller is component of playermovement
        controller = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        //separates input from playermovement
        controller.rotator(Input.GetAxis("Horizontal"));
        controller.velocity(Input.GetAxis("Vertical"));
    }
}
