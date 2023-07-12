using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TilemapScroll : MonoBehaviour
{
    public float moveSpeed = 50f;
    public float teleportPosition = 100f;
    private bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            // Move the sprite to the right
            transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);

            // Check if the sprite has reached the teleport position
            if (transform.position.x >= teleportPosition)
            {
                
                transform.position = new Vector3(transform.position.x -100, 0, 0);

            }
        }
    }
}
