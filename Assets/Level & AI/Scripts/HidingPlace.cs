using UnityEngine;

public class HidingPlace : Interactable
{
    private Collider2D player;
    private bool playerHiding = false;
    void Update()
    {
        if (playerHiding)
        {
            player.gameObject.GetComponent<Player>().hidden = true;
        }
    }
    public override void Interact(Collider2D col)
    {
        playerHiding = playerHiding ? false : true;
        if (playerHiding) player = col;
        else player = null;
    }
}