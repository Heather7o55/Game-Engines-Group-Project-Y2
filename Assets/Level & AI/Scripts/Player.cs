using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Player : Entity
{
    public bool hidden = false;
    public float Speed = 6f;
    public float SprintSpeed = 10f;
    public float jumpHeight = 4f;
    private bool jumpCooldown = false;

    void Start()
    {
        Setup();
    }
    void Update()
    {
        UpdateMovement();
    }
    private void UpdateMovement()
    {

        if(Input.GetKey(KeyCode.Space) & !jumpCooldown)
        {
            selfRigidBody.linearVelocity = new Vector2(selfRigidBody.linearVelocity.x,jumpHeight);
            jumpCooldown = true;
            StartCoroutine(JumpCooldown());
        }

        selfRigidBody.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") *Speed, selfRigidBody.linearVelocity.y);
    }
    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(1f);
        jumpCooldown = false;
    }
    private void Hide()
    {
        gameObject.GetComponent<Collider2D>().enabled = false;
    }
    public override void OnTakeDamage()
    {

    }
    public override void OnDie()
    {

    }
}