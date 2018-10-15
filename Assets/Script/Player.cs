using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    private float energy;
    private float[] location;
    public Checkpoint lastCheckpoint;

    private bool secondJump, isJumping;
    private float verticalVelocity;
    private float gravity = 30.0f;
    private float speed = 5.0f;
    private CharacterController controller;
    private Vector3 moveVector, lastMoveVector;
    private float jumpForce = 10;
    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
        secondJump = false;
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            verticalVelocity = isJumping ? verticalVelocity : 0;
            isJumping = false;

        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }

        moveVector.y = verticalVelocity;
        controller.Move(moveVector * Time.deltaTime);
        lastMoveVector = moveVector;
    }

    public void forward()
    {
        moveVector.x = 1 * speed;
    }

    public void backward()
    {
        moveVector.x = -1 * speed;
    }

    public void jump()
    {
        isJumping = true;
        if (!controller.isGrounded)
        {
            if (!secondJump)
            {
                secondJump = true;
                verticalVelocity = 10;
            }

        }
        else
        {
            secondJump = false;
            verticalVelocity = 10;
        }
    }

    public void stop()
    {
        moveVector.x = 0;
    }

    public void reset()
    {
        this.transform.position = lastCheckpoint.transform.position;
    }

    public void setLastCheckpoint(Checkpoint c)
    {
        lastCheckpoint = c;
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (controller.collisionFlags == CollisionFlags.CollidedSides)
        {
            secondJump = false;

        }

        if (controller.collisionFlags == CollisionFlags.CollidedAbove)
        {
            verticalVelocity = 0;

        }
        switch (hit.gameObject.tag)
        {
			case "Checkpoint":
				Debug.Log ("Checkpoint");
			setLastCheckpoint (hit.gameObject.GetComponents<Checkpoint>()[1]);
				break;
            case "Coin":
                levelManager.instance.collectCoin();
                Destroy(hit.gameObject);

                break;
            case "life":
                levelManager.instance.collectLife();
                Destroy(hit.gameObject);
                break;
            case "JumpPad":
                verticalVelocity = jumpForce * 2;
                break;
            case "Telepoter":
                transform.position = hit.transform.GetChild(0).position;
                break;
            case "winposition":
                levelManager.instance.win();
                break;
            default:
                break;


        }

    }

}
