using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillOnTouch : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var playerMovementController = collision.collider.GetComponent<PlayerMovementController>();
        if (playerMovementController != null)
        {
            SceneManager.LoadScene(0);
        }
    }
}
