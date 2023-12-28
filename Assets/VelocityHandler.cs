using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityHandler : MonoBehaviour
{
    Rigidbody rb;
    public float Vx;
    void Start()
    {
        Vx = -Vx;
        rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(Vx, 0, 0);
    }

    void Update()
    {
        
    }
}
