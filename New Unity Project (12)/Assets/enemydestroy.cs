using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydestroy : MonoBehaviour
{
    public int health;
    
    public void TakeDamage (int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Die();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
