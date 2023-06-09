using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public float damageAmount = 10;
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.TryGetComponent(out PlayerHealth health))
        {
            health.DecreaseHealth(damageAmount);
        }
    }
}
