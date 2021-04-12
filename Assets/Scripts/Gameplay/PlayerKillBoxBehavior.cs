using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerKillBoxBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        EnemyPlayerBehavior EnemyScript = other.GetComponent<EnemyPlayerBehavior>();
        if (EnemyScript)
            EnemyScript.Destroy();
    }
}
