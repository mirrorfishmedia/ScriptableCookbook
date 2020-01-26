using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableCookbook/Actions/Deactivate")]
public class DeactivateAction : ScriptableAction
{
    public override void PerformAction(GameObject obj)
    {
        obj.SetActive(false);
    }
}
