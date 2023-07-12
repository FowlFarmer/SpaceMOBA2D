using UnityEngine;

public class cameraScroll : MonoBehaviour
{
    public float movementSpeed = 15f;
    public float edgePercentage = 0.1f;
    public float PXBoundary = 1000;
    public float NXBoundary = 0;
    public float NYBoundary = 0;
    public float PYBoundary = 1000;
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

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(playerMovement.playerX, playerMovement.playerY, transform.position.z);
        }
        else 
        {
            if (mousePosition.x < screenLeft && transform.position.x > NXBoundary)
            {
                movementDirection += Vector3.left;
            }
            else if (mousePosition.x > screenRight && transform.position.x < PXBoundary)
            {
                movementDirection += Vector3.right;
            }

            if (mousePosition.y < screenTop && transform.position.y > NYBoundary)
            {
                movementDirection += Vector3.down;
            }
            else if (mousePosition.y > screenBottom && transform.position.y < PYBoundary) //the gptz fucked this up so the y screen bottoms is up or smshit so whatever
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
}