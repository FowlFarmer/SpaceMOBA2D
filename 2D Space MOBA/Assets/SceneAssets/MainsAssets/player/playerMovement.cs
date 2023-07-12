using UnityEngine;
using Photon.Pun;

public class playerMovement : MonoBehaviour
{
    public static float playerX = 0;
    public static float playerY = 0;
    public float moveSpeed = PlayerSpecs.Speed;
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    void Update()
    {
        playerX = transform.position.x;
        playerY = transform.position.y;
        if(view.IsMine)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            Vector3 direction = mousePosition - transform.position;
            float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            angle -= 90;

            transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));

            if (Input.GetKey(KeyCode.W))
            {
                // Move in the direction of the orientation
                transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(Vector3.down * moveSpeed/2 * Time.deltaTime);
            }
            // Rotation
            if (Input.GetKey(KeyCode.D))
            {
                // Rotate clockwise
                transform.Translate(Vector3.right * moveSpeed/2 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.A))
            {
                // Rotate counterclockwise
                transform.Translate(Vector3.left * moveSpeed/2 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.P))
            {
                PlayerSpecs.Speed++;
                Debug.Log("Increased speed");
            }
        }
    }
}
