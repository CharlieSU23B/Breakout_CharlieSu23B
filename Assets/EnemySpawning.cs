using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawning : MonoBehaviour
{
    int numberOfEnemys = 1;

    // Start is called before the first frame update
    void Start()
    {
        Enemy.transform.position = new Vector3(-8, 17, 0);
    }

    [SerializeField]
    GameObject Enemy;

    // Update is called once per frame
    void Update()
    {
        Vector3 EnemyPosition = new Vector3(Enemy.transform.position.x, Enemy.transform.position.y, Enemy.transform.position.z);

        if (numberOfEnemys < 5)
        {
            Instantiate(Enemy, EnemyPosition, Quaternion.identity);

            Enemy.transform.position = new Vector3(Enemy.transform.position.x + 4, Enemy.transform.position.y, Enemy.transform.position.z);
            
            numberOfEnemys ++;
            Debug.Log("Hej "+numberOfEnemys);
        }
    }
}
