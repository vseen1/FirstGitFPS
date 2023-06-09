using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerHealth : MonoBehaviour
{
    
    public GameObject HealthBar;
    
    public float health;

    public float maxHealth = 100;

    private void Start()
    {
        health = maxHealth;
    }
    public void AddHealth(float amount)
    {
        health += amount;
        Debug.Log(message: "Health Increased, Current Health: " + health);
    }

    public void DecreaseHealth (float amount)
    {
        health -= amount;
        Debug.Log(message: "Health Decreased, Current Health: " + health);
        if (health <= 0)
        {
            health = 0;
            Debug.Log(message: "Player is dead!");
            SceneManager.LoadScene("EndScreen");

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;

            

        }
        updateHealthBar();
    }

    public void updateHealthBar()
{
    float fillAmount = health / maxHealth;
    if (fillAmount > 1)
    {
        fillAmount = 1;
    }
    HealthBar.GetComponent<Image>().fillAmount = fillAmount;
}
   
}
