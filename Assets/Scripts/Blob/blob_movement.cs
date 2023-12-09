using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blob_movement : MonoBehaviour
{
    public combat_script combat;
    public Animator anmtr;
    public Vector2 speed = new Vector2(5, 5);
    public Transform blob_bottom;
    public LayerMask groundLayers;
    public float interJumpTime = 0.5f;
    private bool dir_right = true;
    private bool canJump = true;
    private bool jumpingRight = false, jumpingLeft = false;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            combat.MeleeAttack();
        }
        //jumpLogic();

        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(speed.x * inputX, speed.y * inputY) * Time.deltaTime;

        //move
        transform.Translate(movement);
        anmtr.SetFloat("inputX", inputX);

        // Set direction
        if (inputX > 0) dir_right = true;
        else if (inputX < 0) dir_right = false;
    }


    void jumpLogic()
    {
        if (Physics2D.OverlapCircle(blob_bottom.position, 0.15f) != null)
        {
            if (canJump && (jumpingRight || jumpingLeft))
            {
                if (jumpingRight)
                {
                    jumpingRight = false;
                    anmtr.SetBool("jumping_Right", false);
                }
                if (jumpingLeft)
                {
                    jumpingLeft = false;
                    anmtr.SetBool("jumping_Left", false);
                }
            }
            else if (!((dir_right && anmtr.GetBool("Attacking_Right") == true) || (!dir_right && anmtr.GetBool("Attacking_Left") == true)))
            {
                

                if (canJump && Input.GetKey("w"))
                {

                    gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, speed.y * 10));
                    if (dir_right)
                    {
                        anmtr.SetBool("jumping_Right", true);
                        jumpingRight = true;
                    }
                    else
                    {
                        anmtr.SetBool("jumping_Left", true);
                        jumpingLeft = true;
                    }
                    canJump = false;
                    StartCoroutine(allowJump(interJumpTime));

                }
            }
        }
    }

    public bool getDirRight()
    {
        return dir_right;
    }

    private IEnumerator allowJump(float secs)
    {
        yield return new WaitForSeconds(secs);
        canJump = true;
    }
}

