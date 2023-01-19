using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterGrounding : MonoBehaviour
{
    [SerializeField]
    private Transform leftFoot;
    [SerializeField]
    private Transform rightFoot;
    [SerializeField]
    private float maxDistance;
    [SerializeField]
    private LayerMask layerMask;
    [SerializeField]
    private bool isGrounded;

    private void Update()
    {
        var raycastHit = Physics2D.Raycast(leftFoot.position, Vector2.down, maxDistance, layerMask);
        Debug.DrawRay(leftFoot.position, Vector3.down * maxDistance, Color.red);
        if (raycastHit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
        raycastHit = Physics2D.Raycast(rightFoot.position, Vector2.down, maxDistance, layerMask);
        Debug.DrawRay(leftFoot.position, Vector3.down * maxDistance, Color.red);
        if (raycastHit.collider != null)
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
    }
}
