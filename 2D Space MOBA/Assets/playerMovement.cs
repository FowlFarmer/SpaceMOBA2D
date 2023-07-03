using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 180f;

    private void Update()
    {
        // Movement
        if (Input.GetKey(KeyCode.W))
        {
            // Move in the direction of the orientation
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
        }

        // Rotation
        if (Input.GetKey(KeyCode.D))
        {
            // Rotate clockwise
            transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            // Rotate counterclockwise
            transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
        }
    }
}
