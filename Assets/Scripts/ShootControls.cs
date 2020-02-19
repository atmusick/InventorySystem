using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShootControls : MonoBehaviour
{
    ObjectPoolerCD.ObjectPoolerTemp pooler;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Awake()
    {
        pooler = GetComponent <ObjectPoolerCD.ObjectPoolerTemp>();  
    }

    // Update is called once per frame
    public void Update()
    {
        if (Input.GetButtonDown("Fire1"))//left control or left mouse button
        {
            Debug.Log("fire!");
            pooler.ShootBullet();
        }
    }
}
