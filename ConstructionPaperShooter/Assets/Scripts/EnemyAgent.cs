using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAgent : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public ScriptableFloat enemySpeed;

    private Transform currentTarget;

    public void SetTarget(Transform targetTransform)
    {
        currentTarget = targetTransform;
    }
    
    // Update is called once per frame
    void Update()
    {
        navMeshAgent.speed = enemySpeed.value;
        navMeshAgent.SetDestination(currentTarget.position);
    }
}
