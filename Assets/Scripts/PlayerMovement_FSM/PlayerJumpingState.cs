using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJumpingState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        player.animator.SetBool("isJumping", true);
        player.jumpingSource.PlayOneShot(player.jumpingAudio);
        
    }

    public override void OnCollisionEnter2D(PlayerController player)
    {
        player.animator.SetBool("isJumping", false);
        player.TransitionToState(player.RunningState);
    }

    public override void Update(PlayerController player)
    {
        Vector3 v = player.rigidbody.velocity;
        v.x = player.speed;
        player.rigidbody.velocity = v;
    }
    public override void FixedUpdate(PlayerController player)
    {

    }
}
