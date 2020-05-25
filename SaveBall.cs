using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveBall : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 startPos;
    public Rigidbody rb;
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -2){
            transform.position = startPos;
            rb.velocity = new Vector3(0f,0f,0f);
        }
    }
}
