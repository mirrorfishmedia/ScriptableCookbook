using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageableObject : MonoBehaviour
{
    public ScriptableInt maxHealth;
    public ScriptableAction[] deathActions;
    public DamageType[] vulnerableDamageTypes;


    private int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth.value;
    }

    public void Damage(int damageAmount, DamageType damageType)
    {

        if (damageType != null)
        {
            //subtract damage amount when Damage function is called
            for (int i = 0; i < vulnerableDamageTypes.Length; i++)
            {
                if (vulnerableDamageTypes[i] == damageType)
                {
                    damageAmount *= 2;
                }
            }
        }


        currentHealth -= damageAmount;
        Debug.Log("Damage " + damageAmount);

        //Check if health has fallen below zero
        if (currentHealth <= 0)
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
