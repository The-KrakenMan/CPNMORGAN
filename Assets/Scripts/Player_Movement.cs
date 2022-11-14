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
    public int DrunkMeter;
    float Timer;
    int RandomSway;
    bool Sway = false;
    bool canJump = true;
    bool SwayLeft;

    // Start is called before the first frame update
    void Start()
    {
        Timer = 0; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float SpeedUp = GameMan.GetComponent<Game_Manager>().Score / 500;
        Move = transform.forward * (MoveSpeed + SpeedUp) * Time.fixedDeltaTime;
        PlayerRB.MovePosition(PlayerRB.position + Move);

        RightLeftMove = Input.GetAxis("Horizontal");
        Move = transform.right * RightLeftMove * (5 + DrunkMeter) * Time.fixedDeltaTime;
        PlayerRB.MovePosition(PlayerRB.position + Move);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (canJump == true)
            {
                Debug.Log("Jumping");
                PlayerRB.AddRelativeForce(Vector3.up*5f, ForceMode.Impulse);
                canJump = false;
            }   
        }

        
        Drunkify();



    }

  

    IEnumerator DirectionSwap()
    {
        int r = Random.Range(5, 10);
        yield return new WaitForSecondsRealtime(r);
        if (SwayLeft == true)
        {
            SwayLeft = false;
        }
        else
        {
            SwayLeft = true;
        }

    }
    public void Drunkify()
    {
        Timer -= Time.fixedDeltaTime;
        if (Timer<= 0)
        {     
            StartCoroutine(DirectionSwap());
            Timer = Random.Range(3, 5);
        }
        //Checks which direction and for how long
        
        if (SwayLeft == true)
        {   
            PlayerRB.AddRelativeForce(Vector3.left*DrunkMeter);
            Debug.Log("Swaying Left");
        }
        else
        {
            PlayerRB.AddRelativeForce(Vector3.right*DrunkMeter);
            Debug.Log("Swaying Right");
        }
       



    }

    public void OnCollisionEnter(Collision collision)
    {
       
        if ((collision.gameObject.tag == "Ground") || (collision.gameObject.tag == "Obstacle"))
        {
            canJump = true;
        }
    }
}
