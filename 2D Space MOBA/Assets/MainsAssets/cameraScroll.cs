using UnityEngine;

public class cameraScroll : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float edgePercentage = 0.125f; // Represents 1/8th of the screen width or height

    private void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 movementDirection = Vector3.zero;

        // Get screen boundaries for each side
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        float screenLeft = screenWidth * edgePercentage;
        float screenRight = screenWidth - screenLeft;
        float screenTop = screenHeight * edgePercentage;
        float screenBottom = screenHeight - screenTop;

        // Check mouse position and set movement direction accordingly
        if (mousePosition.x < screenLeft)
        {
            movementDirection += Vector3.left;
        }
        else if (mousePosition.x > screenRight)
        {
            movementDirection += Vector3.right;
        }

        if (mousePosition.y < screenTop)
        {
            movementDirection += Vector3.down;
        }
        else if (mousePosition.y > screenBottom)
        {
            movementDirection += Vector3.up;
        }

        // Normalize the movement direction and apply speed
        if (movementDirection != Vector3.zero)
        {
            movementDirection.Normalize();
            transform.Translate(movementDirection * movementSpeed * Time.deltaTime);
        }
    }
}