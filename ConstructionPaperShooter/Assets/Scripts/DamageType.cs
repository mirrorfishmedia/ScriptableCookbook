using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableCookbook/Damage Type")]
public class DamageType : ScriptableObject
{

    public GameObject damageEffect;

    public void SpawnPrefabEffect(Vector3 spawnPosition)
    {
        GameObject clone = Instantiate(damageEffect, spawnPosition, Quaternion.identity) as GameObject;
    }
}
