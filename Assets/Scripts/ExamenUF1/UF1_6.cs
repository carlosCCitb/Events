using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UF1_6 : MonoBehaviour
{
    private float velocity, FPS;
    private Vector3 direction;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hit();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Hit();
    }
    private void Update()
    {
        RaycastHit2D ray = Physics2D.Raycast(transform.position, direction, velocity/FPS );
        //velocity is the distance / time, FPS frames / 1second
        if (ray.collider != null)
            Hit();
    }

    public void Hit()
    {

    }
}
