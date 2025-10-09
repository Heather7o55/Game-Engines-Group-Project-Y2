using UnityEngine;

public class Enemy : Entity
{
    public float Speed = 6f;
    public float SprintSpeed = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Setup();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public override void OnTakeDamage()
    {

    }
    public override void OnDie()
    {

    }
}