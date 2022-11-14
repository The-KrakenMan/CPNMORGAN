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
        UIMan.GetComponent<UI_Manager>().GrogUp();
        Destroy(this.gameObject);
    }
}
