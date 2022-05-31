using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthController : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    public float playerHealth;


    bool isAlive = true;                //Stores the player's "alive" state
    int trapsLayer;                     //The layer the traps are on


    void Start()
    {
        healthBar = GetComponent<Image>();
        //Get the integer representation of the "Traps" layer
        trapsLayer = LayerMask.NameToLayer("Traps");
    }

    // Update is called once per frame
    public void UpdateHealth()
    {
        healthBar.fillAmount = playerHealth;

        if (playerHealth <= 0)
        {
            isAlive = false;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            //GameManager.instance.End();
            //Tell the Game Manager that the player died and tell the Audio Manager to play
            //the death audio
            //GameManager.PlayerDied();
            //AudioManager.PlayDeathAudio();
        }

    }
}
