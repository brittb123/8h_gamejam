using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Rigidbody _rigidbody;
    public float speed = 1;
    public GameObject EnemyTarget;

    // Start is called before the first frame update
    void Start()
    {

        _rigidbody.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
        _rigidbody.transform.LookAt(EnemyTarget.transform.position);
   
        _rigidbody.AddRelativeForce(new Vector3(0, 0, speed));
    }
}
