using UnityEngine;

public class backgroundScroll : MonoBehaviour
{
    public float speed = 2f;

    private void Update()
    {
        // Move the object to the right
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }
}