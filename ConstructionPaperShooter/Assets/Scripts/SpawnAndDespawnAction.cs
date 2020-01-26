using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableCookbook/Actions/SpawnAndDespawn")]
public class SpawnAndDespawnAction : ScriptableAction
{
    public GameObject[] objectsToSpawnAndDestroy;
    public float despawnDelay;

    public override void PerformAction(GameObject obj)
    {
        for (int i = 0; i < objectsToSpawnAndDestroy.Length; i++)
        {
            GameObject prefab = objectsToSpawnAndDestroy[i];
            GameObject clone = Instantiate(prefab, obj.transform.position, obj.transform.rotation);
            Destroy(clone, despawnDelay);
        }
    }
    
}
