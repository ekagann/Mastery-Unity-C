using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    public float moveSpeed = 5;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//sað ya da sola basýldýðý zaman yapýlacaklarýn tanýmý.
        float vertical = Input.GetAxis("Vertical");//yukarý ya da aþaðý basýldýðý zaman yapýlacaklarýn tanýmý.

        Vector3 movement = new Vector3(horizontal, vertical);

        transform.position += movement *Time.deltaTime * moveSpeed;


    }
}
