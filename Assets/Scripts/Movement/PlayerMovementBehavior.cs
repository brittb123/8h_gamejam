using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public float speed = 1.0f;
   

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Forward") > 0)
            _rigidbody.AddRelativeForce(new Vector3(0, 0, speed), ForceMode.Impulse);

    }
}
