using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    public bool Passed { get; private set; }
    public Checkpoint LastOrDefault { get; internal set; }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<PlayerMovementController>();
        if(player != null)
        {
            Passed = true;
        }
    }

    internal Checkpoint Last(Func<object, object> p)
    {
        throw new NotImplementedException();
    }
}
