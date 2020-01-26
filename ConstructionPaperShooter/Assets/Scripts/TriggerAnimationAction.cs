using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ScriptableCookbook/Actions/TriggerAnimation")]
public class TriggerAnimationAction : ScriptableAction
{

    public string triggerName = "StartFall";

    public override void PerformAction(GameObject obj)
    {
        Animator animator = obj.GetComponentInChildren<Animator>();

        if(animator != null)
        {
            animator.SetTrigger(triggerName);
        }
    }
}
