using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float TurnSpeed = 1.0f;
    public float rotation;

    
    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rotation = Input.GetAxis("Horizontal") * TurnSpeed;
            transform.Rotate(transform.up, rotation);
        }

        if (Input.GetKey(KeyCode.D))
        {
            rotation = Input.GetAxis("Horizontal") * TurnSpeed;
            transform.Rotate(-transform.up, -rotation);
        }
    }
}
