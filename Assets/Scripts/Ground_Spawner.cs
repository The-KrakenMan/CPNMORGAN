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
    int spawnInc = -456;
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

       switch (randomnum)
        {
            case 0:  
                 GameObject Ground = Instantiate(Lane, new Vector3(spawnInc,0,0), Quaternion.identity);
                 break;
            case 1:
                 GameObject Ground2 = Instantiate(Lane, new Vector3(spawnInc,0, 0), Quaternion.identity);
                break;
            case 2:
                GameObject ObstacleSpawn1 = Instantiate(ObstacleLane1, new Vector3(spawnInc, 0, 0), Quaternion.identity);
                break;
            case 3:
                GameObject ObstacleSpawn2 = Instantiate(ObstacleLane2, new Vector3(spawnInc, 0, 0), Quaternion.identity);
                break;
            case 4:
                GameObject ObstacleSpawn3 = Instantiate(ObstacleLane3, new Vector3(spawnInc, 0, 0), Quaternion.identity);
                break;
        }

        spawnInc -= 76;

    }
}
