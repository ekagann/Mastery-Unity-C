using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{ 
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");//sað ya da sola basýldýðý zaman yapýlacaklarýn tanýmý.
        float vertical = Input.GetAxis("Vertical");//yukarý ya da aþaðý basýldýðý zaman yapýlacaklarýn tanýmý.

        Vector3 movement = new Vector3(horizontal, vertical);

        Debug.Log(movement);


    }
}
