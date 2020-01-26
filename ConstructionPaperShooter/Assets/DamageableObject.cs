using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableObject : MonoBehaviour
{
    public ScriptableInt maxHealth;
    public ScriptableAction[] deathActions;


    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth.value;
    }

    public void Damage(int damageAmount)
    {

        //subtract damage amount when Damage function is called
        currentHealth -= damageAmount;

        //Check if health has fallen below zero
        if (currentHealth == 0)
        {
            //if health has fallen below zero, deactivate it 
            Die();
        }
    }

    public void Die()
    {
        for (int i = 0; i < deathActions.Length; i++)
        {
            deathActions[i].PerformAction(this.gameObject);
        }
    }
}
