using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.CompareTag("Points"))
        {
            ScoreHud.scoreAmount += 1;
            gameObject.SetActive(false);
            Debug.Log("Point Collected");
        }
    }

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 180) * Time.deltaTime);
    }
}
