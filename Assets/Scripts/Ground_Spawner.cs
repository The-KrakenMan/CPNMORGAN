using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground_Spawner : MonoBehaviour
{
    public GameObject Lane;
    public GameObject ObstacleLane1;
    public GameObject ObstacleLane2;
    public GameObject ObstacleLane3;

    public Vector3 NewLane;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spawn(GameObject Spawner)
    {
        int randomnum = Random.Range(0, 5);
        
        
        NewLane = Spawner.transform.position;
        NewLane.x = NewLane.x - 76;
        NewLane.y += 4;
        NewLane.z += 3;

       switch (randomnum)
        {
            case 0:  
                    GameObject Ground = Instantiate(Lane, NewLane, Quaternion.identity);
                     break;
            case 1:
                 GameObject Ground2 = Instantiate(Lane, NewLane, Quaternion.identity);
                break;
            case 2:
                GameObject ObstacleLane1 = Instantiate(Lane, NewLane, Quaternion.identity);
                break;
            case 3:
                GameObject ObstacleLane2 = Instantiate(Lane, NewLane, Quaternion.identity);
                break;
            case 4:
                GameObject ObstacleLane3 = Instantiate(Lane, NewLane, Quaternion.identity);
                break;
        }

        

    }
}
