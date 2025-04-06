using UnityEngine;

public class Sword : MonoBehaviour
{
    PlayerControls playerControls;
    Animator myAnimator;

    private void Awake()
    {
        playerControls = new PlayerControls();
        myAnimator = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        playerControls.Enable();
    }

    private void Start()
    {
        playerControls.Combat.Attack.started += (context) => Attack();
    }

    void Attack()
    {
        myAnimator.SetTrigger("Attack");
    }
}
