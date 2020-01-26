using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{

    public Transform playerTransform;

    public List<EnemyAgent> enemyAgents = new List<EnemyAgent>();

    // Start is called before the first frame update
    void Start()
    {
        SetupAgents();
    }

    void SetupAgents()
    {
        for (int i = 0; i < enemyAgents.Count; i++)
        {
            enemyAgents[i].SetTarget(playerTransform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
