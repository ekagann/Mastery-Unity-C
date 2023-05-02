
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBox : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer enabledSprite;
    [SerializeField]
    private SpriteRenderer disabledSprite;
    [SerializeField]
    private int totalCoins = 1;
    private Animator animator;
    private int remainingCoins;

    void Awake()
    {

        animator = GetComponent<Animator>();
        remainingCoins = totalCoins;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (remainingCoins > 0 &&
            WasHitByPlayer(collision) &&
            WasHitFromBottomSide(collision))
        {
            if (collision.contacts[0].normal.y > 0.5)
            {


                GameManager.Instance.AddCoin();
                remainingCoins--;
                animator.SetTrigger("FlipCoin");

                if (remainingCoins <= 0)
                {
                    enabledSprite.enabled = false;
                    disabledSprite.enabled = true;
                }
            }
        }
    }

    private static bool WasHitByPlayer(Collision2D collision)
    {
        return collision.collider.GetComponent<PlayerMovementController>() != null;
    }

    private static bool WasHitFromBottomSide(Collision2D collision)
    {
        return collision.contacts[0].normal.y > 0.5;
    }
}
