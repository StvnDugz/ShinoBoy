using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public float speed;
    public float distance;
    private bool movingR = true;
    public Transform groundCheck;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        int groundLayerMask = LayerMask.GetMask("Platforms");

        RaycastHit2D ground = Physics2D.Raycast(groundCheck.position, Vector2.down, distance, groundLayerMask);

        if (ground.collider == false)
        {
            if (movingR == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingR = false;
            }

            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingR = true;
            }
        }
    }
}
