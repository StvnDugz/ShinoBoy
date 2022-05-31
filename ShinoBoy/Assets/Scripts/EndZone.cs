using System.Collections;
using UnityEngine;

public class EndZone : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collision)
    {
        //Trigger when play collides
        GameManager.instance.End();

    }
}
