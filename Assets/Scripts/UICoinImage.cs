using UnityEngine;

public class UICoinImage : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
        GameManager.Instance.OnCoinsChanged += Pulse;
    }

    private void OnDestroy()
    {
        GameManager.Instance.OnCoinsChanged -= Pulse;
    }
    private void Pulse(int coins)
    {
        animator.SetTrigger("Pulse");
    }

}
