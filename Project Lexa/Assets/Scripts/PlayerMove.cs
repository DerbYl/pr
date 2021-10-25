using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private ControlType controlType;
    [SerializeField] private AudioSource footsteps;

    AudioSource playerAudio;
    private Rigidbody2D rb;
    private Vector2 moveInput;
    private Vector2 moveVelocity;

    private bool FacingRight = true;

    [SerializeField] private Joystick joystick;
    [SerializeField] private enum ControlType { PC, Androud }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (controlType == ControlType.PC)
        {
            moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        else if (controlType == ControlType.Androud)
        {
            moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
 
        }

        moveVelocity = moveInput.normalized * speed;

        if (!FacingRight && moveInput.x > 0)
        {
            Flip();
        }
        else if (FacingRight && moveInput.x < 0)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.A))
            footsteps.Play();

        else if (Input.GetKeyUp(KeyCode.A))
            footsteps.Stop();
        if (Input.GetKeyDown(KeyCode.W))
            footsteps.Play();
        else if (Input.GetKeyUp(KeyCode.W))
            footsteps.Stop();
        if (Input.GetKeyDown(KeyCode.S))
            footsteps.Play();
        else if (Input.GetKeyUp(KeyCode.S))
            footsteps.Stop();
        if (Input.GetKeyDown(KeyCode.D))
            footsteps.Play();
        else if (Input.GetKeyUp(KeyCode.D))
            footsteps.Stop();
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + moveVelocity * Time.fixedDeltaTime);
    }
    private void Flip()
    {
        FacingRight = !FacingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;
    }
}