using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlayerBehavior : MonoBehaviour
{

    public void Destroy()
    {
        Destroy(gameObject);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            Destroy();
    }
}
