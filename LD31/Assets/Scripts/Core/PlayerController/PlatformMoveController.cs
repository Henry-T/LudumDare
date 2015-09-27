using UnityEngine;
using System.Collections;

public class PlatformMoveController : MonoBehaviour, IAnimatorEventListener {

    public float Speed = 2;
    public float JumpSpeed = 20;
    public Vector3 Velocity;

    public Animator Animator;
    public AnimatorEventDispatcher AnimatorEventDispatcher;

    public EPlatformMoveState State = EPlatformMoveState.Idle;

	// Use this for initialization
	void Start () {
        Animator = gameObject.GetComponentInChildren<Animator>();
        AnimatorEventDispatcher = gameObject.GetComponentInChildren<AnimatorEventDispatcher>();
        if (AnimatorEventDispatcher)
            AnimatorEventDispatcher.Listener = this;
	}
	
	// Update is called once per frame
	void Update () {
        Velocity = Vector3.zero;
        bool isMove = false;
        bool attack = false;
	    if (Input.GetKey(KeyCode.D))
        {
            isMove = true;
            Velocity = Vector3.right;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            isMove = true;
            Velocity = Vector3.left;
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            Velocity = Vector3.up * JumpSpeed;
        }
        
        if (Input.GetKeyDown(KeyCode.J))
        {
            attack = true;
            Velocity = Vector3.zero;
            isMove = false;
        }

        if (isMove)
            Velocity *= Speed;

        if (Animator)
        {
            Animator.SetFloat("speedX", Mathf.Abs(Velocity.x));
            if (attack)
                Animator.SetTrigger("attack");

            if (Velocity.x > 0)
            {
                Animator.gameObject.transform.rotation = Quaternion.identity;
            }
            else if (Velocity.x < 0)
            {
                Animator.gameObject.transform.rotation = Quaternion.EulerAngles(0, Mathf.PI, 0);
            }
        }

        transform.position += Velocity * Time.deltaTime;
	}

    public void HandleEvent(string name)
    {
        if (name == "attack")
        {
             foreach(var col2d in Physics2D.OverlapCircleAll(transform.position, 2, Util.GetLayerMask(GameManager.Instance.LayerNameEnemy)))
             {
                 GameObject.Destroy(col2d.gameObject);
             }
        }
    }
}

public enum EPlatformMoveState
{
    Idle,
    Walk,
    Jump,
    Fall,
}