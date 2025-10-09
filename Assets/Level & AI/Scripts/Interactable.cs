using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D col)
    {
        if (!col.CompareTag("Player")) return;
        if (Input.GetAxisRaw("Horizontal") != 0) return;
        if (Input.GetKeyDown("E")) Interact(col);
    }
    public abstract void Interact(Collider2D col);
}