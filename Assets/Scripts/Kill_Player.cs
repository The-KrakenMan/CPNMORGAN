using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Kill_Player : MonoBehaviour
{
    public AudioSource deathSound;
    public AudioSource failureSound;
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
            deathSound.Play();
            isDead = true;
            GameMan.GetComponent<Game_Manager>().GameOver();
            failureSound.Play();
            
        }
        
        
    }
}
