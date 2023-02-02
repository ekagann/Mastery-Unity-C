
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

    private int remainingCoins;

    void Awake()
    {
        remainingCoins = totalCoins;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (remainingCoins > 0 &&
            collision.collider.GetComponent<PlayerMovementController>() != null)
        {
            GameManager.Instance.AddCoin();
            remainingCoins--;

            if (remainingCoins <= 0)
            {
                enabledSprite.enabled = false;
                disabledSprite.enabled = true;
            }
        }
    }
}
