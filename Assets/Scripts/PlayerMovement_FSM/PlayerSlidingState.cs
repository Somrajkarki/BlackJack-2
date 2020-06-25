using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlidingState : PlayerBaseState
{
    public override void EnterState(PlayerController player)
    {
        player.animator.SetBool("isSliding", true);
    }

    public override void FixedUpdate(PlayerController player)
    {
        
    }

    public override void OnCollisionEnter2D(PlayerController player)
    {
        
    }

    public override void Update(PlayerController player)
    {
        //throw new System.NotImplementedException();
        if (Input.GetKeyUp(KeyCode.DownArrow))
        { 
            player.animator.SetBool("isSliding", false);
            player.TransitionToState(player.RunningState);
        }
        
    }

}

