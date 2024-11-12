using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UF1_5 : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D _rb;
    private Vector2 _direction;
    [SerializeField] private bool Grounded = false;
    private float _raycastDistance;
    public float TimeJumping;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        _rb.velocity = _direction * Speed;
        RaycastHit2D GroundChecker = Physics2D.Raycast(transform.position, - transform.up, _raycastDistance);
        if (GroundChecker.collider != null)
        {
            if (GroundChecker.collider.gameObject.layer == 8) //Layer 8 = Ground.
                Grounded = true;
            else
                Grounded = false;
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A))
            _direction.x = -1f;
        else if (Input.GetKey(KeyCode.D))
            _direction.x = 1f;
        else
            _direction.x = 0;
        if (Input.GetKeyDown(KeyCode.Space) && Grounded)
        {
            _direction.y = 1f;
            StartCoroutine(Jump());
        }
    }
    private IEnumerator Jump()
    {
        yield return new WaitForSeconds(TimeJumping);
        _direction.y = -1;
        yield return Fall();
    }
    private IEnumerator Fall()
    {
        yield return new WaitForSeconds(TimeJumping);
        _direction.y = 0;
    }
}
