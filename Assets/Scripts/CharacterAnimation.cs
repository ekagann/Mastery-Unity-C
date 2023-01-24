using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    private Animator animator;
    private IMove mover;

    private void Awake()
    {
        animator = GetComponent<Animator>();
        mover = GetComponent<IMove>();
    }
    private void Update()
    {
        float speed = mover.Speed;
        animator.SetFloat("Speed", speed);
    }
}

