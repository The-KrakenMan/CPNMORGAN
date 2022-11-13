using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public Rigidbody PlayerRB;
    public GameObject GameMan;
    float MoveSpeed = 5;
    Vector3 Move;
    float RightLeftMove;

    float Timer;
    int RandomSway;
    bool Sway = false;
    bool canJump = true;

    // Start is called before the first frame update
    void Start()
    {
        RandomSway = Random.Range(1, 5);
        Timer = Time.time + RandomSway;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float SpeedUp = GameMan.GetComponent<Game_Manager>().Score / 20;
        Move = transform.forward * (MoveSpeed + SpeedUp) * Time.fixedDeltaTime;
        PlayerRB.MovePosition(PlayerRB.position + Move);

        RightLeftMove = Input.GetAxis("Horizontal");
        Move = transform.right * RightLeftMove * 5f * Time.fixedDeltaTime;
        PlayerRB.MovePosition(PlayerRB.position + Move);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump == true)
            {
                
                PlayerRB.AddForce(Vector3.up*5f);
                canJump = false;
            }   
        }



    }

    private void Drunkify()
    {
        int RandomDir = 0;     
        float SwayTimer = 0;
        bool SwayLeft = false;
        bool SwayRight = false;


        //Checks When to Sway
        

        
        //Checks which direction and for how long
        

           while (SwayLeft == true)
            {
                PlayerRB.AddRelativeForce(Vector3.left);
            }

            while (SwayRight == true)
            {
                PlayerRB.AddRelativeForce(Vector3.right);
            }


      

    }

    public void OnCollisionEnter(Collision collision)
    {
        if ((collision.gameObject.tag == "Ground")|| (collision.gameObject.tag == "Obstacle"))
        {
            canJump = true;
        }
    }
}
