using UnityEngine;

public static class Collission2DExtensions
{
    public static bool WasHitByPlayer(this Collision2D collision)
    {
        return collision.collider.GetComponent<PlayerMovementController>() != null;
    }

    public static bool WasHitFromBottomSide(this Collision2D collision)
    {
        return collision.contacts[0].normal.y > 0.5;
    }
}
