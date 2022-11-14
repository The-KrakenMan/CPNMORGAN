using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Manager : MonoBehaviour
{
    public AudioSource deathSound;
    public AudioSource failureSound;
    public AudioSource collectSound;
    public int GrogCount;
    public int Score;
    public GameObject UIMan;
    public bool isdead = false;

<<<<<<< HEAD
    
    public Text challenge;
    
=======
>>>>>>> 609f85d68a9b7a60ff337e17f9e72f4337a7fe6b
    // Start is called before the first frame update
    void Start()
    {
       
       
    }

    // Update is called once per frame
    void Update()
    {
        if (isdead == false)
        {
            Score++;
        }
        
    }

    public void GameOver()
    {
        
        deathSound.Play();
        UIMan.GetComponent<UI_Manager>().DeathScreenUP(Score);
<<<<<<< HEAD
        
        GameObject.FindWithTag("challenge1").SetActive(true);
        

        
=======
        failureSound.Play();
        isdead = true;
    }

    public void PickUpCollect()
    {
        collectSound.Play();
>>>>>>> 609f85d68a9b7a60ff337e17f9e72f4337a7fe6b
    }
    
}
