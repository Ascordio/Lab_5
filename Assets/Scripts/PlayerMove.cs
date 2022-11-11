using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _speed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Animator anim;
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        float r = Input.GetAxis("Mouse X");

        Vector3 velocity = new Vector3(h, 0, v) * _speed;
        velocity.y =_rigidbody.velocity.y;
        Vector3 worldVelocity = transform.TransformVector(velocity);
        _rigidbody.velocity = worldVelocity;

        _rigidbody.angularVelocity = new Vector3(0f, r * _rotationSpeed, 0f);

        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D))
        {
            anim.SetBool("isRun", true);
        }
        else { anim.SetBool("isRun", false); }
    }
}
