using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Coin))]
[RequireComponent(typeof(CheckGround))]
public class Player : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpforce;
    [SerializeField] private CheckGround _isGround;
    [SerializeField] private Coin _coins;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        _isGround = GetComponent<CheckGround>();
    }

    void Update()
    {
        float Horizontal = Input.GetAxisRaw("Horizontal");
        _rigidbody.velocity = new Vector2(Horizontal* _speed, _rigidbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (_isGround.Check())
            {
                _rigidbody.AddForce(Vector2.up * _jumpforce, ForceMode2D.Impulse);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Coinz>())
        {
            _coins.Add(1);
            Destroy(collision.gameObject);
        }
    }
}
