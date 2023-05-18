using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableBox : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.WasHitByPlayer() &&
            collision.WasHitFromBottomSide())
        {
            Destroy(gameObject);

        }


    }
    
}
