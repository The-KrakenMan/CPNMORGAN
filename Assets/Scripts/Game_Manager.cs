using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public AudioSource deathSound;
    public AudioSource failureSound;
    public AudioSource collectSound;
    public int GrogCount;
    public int Score;
    public GameObject UIMan;
    public bool isdead = false;

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
        failureSound.Play();
        isdead = true;
    }

    public void PickUpCollect()
    {
        collectSound.Play();
    }
    
}
