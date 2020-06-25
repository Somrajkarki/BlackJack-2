using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRunningState : PlayerBaseState
{
    private float time;

    private bool isGrounded;

    public override void EnterState(PlayerController player)
    {
        player.runningSource.PlayOneShot(player.runningAudio);
    }

    public override void OnCollisionEnter2D(PlayerController player)
    {
        
    }

    public override void Update(PlayerController player)
    { 
        if (Input.GetButtonDown("Jump"))
        {
            player.rigidbody.AddForce(Vector3.up * player.jumpForce);
            player.TransitionToState(player.JumpingState);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            player.rigidbody.AddForce(Vector3.forward * player.jumpForce);
            player.TransitionToState(player.SlidingState);
        }
    }

    public override void FixedUpdate(PlayerController player)
    {
        isGrounded = Physics2D.OverlapCircle(player.grounCheck.position, player.checkRadius, player.whatIsGround);

        time += Time.deltaTime;

        Vector3 v = player.rigidbody.velocity;
        v.x = player.speed;
        player.rigidbody.velocity = v;

        if (time >= .5 && isGrounded)
        {
            player.runningSource.PlayOneShot(player.runningAudio);
            time = 0;
        }
    }
}
