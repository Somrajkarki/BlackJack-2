using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Player Variables
    public float jumpForce = 1000.0f ;
    public float speed = 10.0f;

    private Rigidbody2D rbody;
    private Animator anim;


    public AudioClip runningAudio;
    public AudioSource runningSource;
    public AudioClip jumpingAudio;
    public AudioSource jumpingSource;

    public Transform grounCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    new public Rigidbody2D rigidbody
    {
        get { return rbody; }
    }
    public Animator animator
    {
        get { return anim; }
    }
    #endregion
    private PlayerBaseState currentState;

    public readonly PlayerRunningState RunningState = new PlayerRunningState();
    public readonly PlayerJumpingState JumpingState = new PlayerJumpingState();
    public readonly PlayerSlidingState SlidingState = new PlayerSlidingState();
    void Awake()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void Start()
    {
        TransitionToState(RunningState);
    }
    public void TransitionToState(PlayerBaseState state)
    {
        currentState = state;
        currentState.EnterState(this);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        currentState.OnCollisionEnter2D(this);
    }

    void Update()
    {
        currentState.Update(this);
    }

    void FixedUpdate()
    {
        currentState.FixedUpdate(this);
    }
}
