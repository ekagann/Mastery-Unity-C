using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 2;
    [SerializeField]
    private float jumpForce = 400;

    private new Rigidbody2D rigidbody2D;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        if (Input.GetButtonDown("Fire1"))
        {
            rigidbody2D.AddForce(Vector2.up * jumpForce);
        }

    }

    private void FixedUpdate()
    {

        float horizontal = Input.GetAxis("Horizontal");//sað ya da sola basýldýðý zaman yapýlacaklarýn tanýmý.

        Vector3 movement = new Vector3(horizontal, 0);

        transform.position += movement * Time.deltaTime * moveSpeed;

        


    }
}
