using UnityEngine;

public class LoadingBGScroll : MonoBehaviour
{
    public float moveSpeed = 50f;
    public float teleportPosition = 1300f;
    public Vector3 teleportTarget = new Vector3(-1700f, 0f, 0f);
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
                // Teleport the sprite to the teleport target
                transform.position = teleportTarget;

                // Stop the movement
                //isMoving = false;
            }
        }
    }
}