using UnityEngine;

public class cameraZoom : MonoBehaviour
{
    public float zoomSpeed = 5f;
    public float minSize = 5f;
    public float maxSize = 25f;

    private void Start()
    {
        Screen.SetResolution(Screen.currentResolution.width, Screen.currentResolution.height, true);
    }
    private void Update()
    {
        // Get the scroll input
        float scrollInput = Input.GetAxis("Mouse ScrollWheel");

        // Calculate the new size based on the scroll input
        float newSize = Camera.main.orthographicSize - scrollInput * zoomSpeed;

        // Clamp the new size within the defined range
        newSize = Mathf.Clamp(newSize, minSize, maxSize);

        // Set the new size to the camera
        Camera.main.orthographicSize = newSize;
    }
}