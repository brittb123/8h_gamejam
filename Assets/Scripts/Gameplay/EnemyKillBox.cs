using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyKillBox : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        RobotDeathBehavior RobotDeath = other.GetComponent<RobotDeathBehavior>();

        if (RobotDeath)
            RobotDeath.Destroy();
    }
}
