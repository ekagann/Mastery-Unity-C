using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;
    private PlayerMovementController playerMovementController;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        playerMovementController = GetComponent<PlayerMovementController>();
    }
    private void Update()
    {
        float speed = playerMovementController.Speed;
        animator.SetFloat("Speed", speed);
    }
}

