using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn_Trigger : MonoBehaviour
{
    public GameObject GameMan;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameMan.GetComponent<Ground_Spawner>().Spawn(this.gameObject);
        }
    }
}
