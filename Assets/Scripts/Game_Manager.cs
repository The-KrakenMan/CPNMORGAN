using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    public int GrogCount;
    public int Score;
    public GameObject UIMan;
    // Start is called before the first frame update
    void Start()
    {
        UIMan = GameObject.FindGameObjectWithTag("UI_Manager");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        UIMan.GetComponent<UI_Manager>().DeathScreenUP(Score);
    }
    
}