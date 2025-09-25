using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : Entity
{
    public float playerSpeed = 200f;

    private void UpdateMovement()
    {
        moveDirection = new Vector2(Input.GetAxisRaw("Horizontal"),new int = (Input.getbutton)  );
        moveDirection.Normalize();
    }
}
