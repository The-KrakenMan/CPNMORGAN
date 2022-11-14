using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kill_Player : MonoBehaviour
{
    
    public bool isDead;
    GameObject GameMan;
    
    // Start is called before the first frame update
    void Start()
    {
      GameMan =  GameObject.FindGameObjectWithTag("Game_Manager");
      
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {           
            isDead = true;
            GameMan.GetComponent<Game_Manager>().GameOver();
<<<<<<< HEAD
            failureSound.Play();
            
        }
        
        
=======
        } 
>>>>>>> 609f85d68a9b7a60ff337e17f9e72f4337a7fe6b
    }
}
