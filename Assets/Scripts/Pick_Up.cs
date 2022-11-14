using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Pick_Up : MonoBehaviour
{
  
    public GameObject UIMan;
    public GameObject GameMan;
    // Start is called before the first frame update
    void Start()
    {
        UIMan = GameObject.FindGameObjectWithTag("UI_Manager");
        GameMan = GameObject.FindGameObjectWithTag("Game_Manager");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            PickedUP();
           
            other.GetComponent<Player_Movement>().DrunkMeter++;
        }
    }
    public void PickedUP()
    { 
        GameMan.GetComponent<Game_Manager>().GrogCount++;
        GameMan.GetComponent<Game_Manager>().PickUpCollect();
        UIMan.GetComponent<UI_Manager>().GrogUp();
        GameMan.GetComponent<Game_Manager>().Score = GameMan.GetComponent<Game_Manager>().Score +100;

        Destroy(this.gameObject);
    }
}
