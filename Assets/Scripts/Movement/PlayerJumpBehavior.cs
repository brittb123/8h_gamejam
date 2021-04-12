using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody _rigidbody;
    public float JumpForce = 1;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("PlayerJump"))
                _rigidbody.AddForce(new Vector3(0, JumpForce, 0), ForceMode.Impulse);
    }

    
}
