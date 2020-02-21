using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour

{
    public GameObject player;
    public Collider2D playerCollider;
    public Collider2D bulletCollider;

    public Rigidbody2D rb;
        public GameObject bulletRevolver;
        public SpriteRenderer bulletSprite;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void OnEnable()
    {
        rb.velocity = new Vector2(0, 10);/*adds velocity to bullet when enabled*/
        Debug.Log("Yeet");
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Physics2D.IgnoreCollision(playerCollider, bulletCollider);//won't run into player
        }
        else
        {
            bulletRevolver.SetActive(false); //disables
            Debug.Log("dead bullet");
        }
    }
       
     
    // Update is called once per frame
    void Update()
    {
        
    }
}
