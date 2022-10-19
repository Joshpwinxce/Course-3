using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefabs;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float spawnDelay = 2;
    private float repeatRate = 2;
    private PlayerControl PlayerControlScript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnDelay, repeatRate);
        PlayerControlScript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void  SpawnObstacle()
    {
        if (PlayerControlScript.gameOver == false)
        {
            Instantiate(obstaclePrefabs, spawnPos, obstaclePrefabs.transform.rotation);
        }
        
    }
}
