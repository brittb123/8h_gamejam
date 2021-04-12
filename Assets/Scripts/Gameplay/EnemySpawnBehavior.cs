using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnBehavior : MonoBehaviour
{

    public float xMin;
    public float xMax;
    public float zMin;
    public float zMax;

    public float TimeInterval;

    public GameObject EnemyRef;

    public bool gameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemy());
    }

    public IEnumerator SpawnEnemy()
    {
        float RandX;
        float RandZ;

        while(!gameOver)
        {
            RandX = Random.Range(xMin, xMax);
            RandZ = Random.Range(zMin, zMax);

            Vector3 Spawn = new Vector3(RandX, transform.position.y, RandZ);
            GameObject EnemySpawned = Instantiate(EnemyRef.gameObject, Spawn, new Quaternion());

            EnemyBehavior MovementScript = EnemySpawned.GetComponent<EnemyBehavior>();

            //Instantiate(EnemyRef, Spawn, new Quaternion());

            yield return new WaitForSeconds(TimeInterval);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
