using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {

    float x;

    public float speed = 15f;
    public float force = 30f;


    Rigidbody rb;

    void Start() {

        rb = gameObject.GetComponent<Rigidbody>();
    
    }

	// Update is called once per frame
    void FixedUpdate()
    {

        x = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        Vector3 newPos = rb.position + Vector3.right * x;

        newPos = new Vector3(Mathf.Clamp(newPos.x, -6, 6), newPos.y, newPos.z);

        rb.MovePosition(newPos);

    }

    void OnCollisionEnter(Collision col)
    {

        if (col.gameObject.tag == "ball")
            shoot(col);
    
    }

    void shoot(Collision col) {

         col.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
    
    }
}
