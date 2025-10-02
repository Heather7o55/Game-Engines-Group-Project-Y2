using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : Entity
{
    public float playerSpeed = 200f;
    public float jumpHeight = 200f;
    private bool jumpCooldown = false;

    private void UpdateMovement()
    {
        if (Input.GetKey(KeyCode.Space) & !jumpCooldown)
        {
            selfRigidBody.AddForce(new Vector2(0, jumpHeight));
            jumpCooldown = true;
            StartCoroutine(JumpCooldown());
        }
        Vector2 moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"), 0);
        moveDirection.Normalize();
        selfRigidBody.linearVelocity = moveDirection * playerSpeed;
    }
    IEnumerator JumpCooldown()
    {
        yield return new WaitForSeconds(2);
    }
    public override void OnTakeDamage()
    {

    }
    public override void OnDie()
    {

    }
}
