using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance = null;

    public GameObject levelCompleteText;
    public float resetDelay = 2f;
    bool gameEnd = false;
    public GameObject deathVFXPrefab;


    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != null)
            Destroy(gameObject);
    }

        public void End()
    {
        if (gameEnd == false)
        {
            gameEnd = true;
            // display Level Complete
            levelCompleteText.SetActive(true);
            Invoke("Reset", resetDelay);
        }

    }

    void Reset()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Instantiate(deathVFXPrefab, transform.position, transform.rotation);
    }
}
