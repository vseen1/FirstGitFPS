using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Interactable : MonoBehaviour
{
    public Transform player;
    public float interactionDistance = 2f;
    public string nextSceneName = "EndScreen";

    private bool canInteract = false;
    
    
    
    
    
    
    
    
    
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void Update()
    {
        // Calculate the distance between the player and the object
        float distance = Vector3.Distance(player.position, transform.position);

        // Check if the player is within the interaction distance
        if (distance <= interactionDistance)
        {
            // Set the flag to allow interaction
            canInteract = true;

            // Check for input to interact
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Load the next scene
                SceneManager.LoadScene("EndScreen");
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
        else
        {
            // Reset the interaction flag if the player moves away
            canInteract = false;
        }
    }
    private void OnGUI()
    {
        // Display interaction prompt if the player is within range
        if (canInteract)
        {
            GUI.Label(new Rect(Screen.width / 2 - 75, Screen.height - 50, 150, 30), "Press E to interact");
        }
    }





}
