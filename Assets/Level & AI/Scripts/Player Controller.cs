using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : Entity
{
    public float playerSpeed = 10f;
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

        selfRigidBody.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") *playerSpeed, selfRigidBody.linearVelocity.y);
    }
    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(1f);
        jumpCooldown = false;
    }
    public override void OnTakeDamage()
    {

    }
    public override void OnDie()
    {

    }
}
