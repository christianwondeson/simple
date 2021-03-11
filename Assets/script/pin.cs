using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pin : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    private bool pinned=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!pinned)
        rb.MovePosition(rb.position + Vector2.up*speed*Time.deltaTime);
    }

    void OntiggerEnter2D(Collider2D collid)
    {
        if (collid.tag == "Rotator")
        {
            pinned = true;
        }
    }
}
