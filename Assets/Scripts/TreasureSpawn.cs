using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureSpawn : MonoBehaviour
{
    [SerializeField]
    private GameObject[] spawnObjects;
    [SerializeField]
    private Transform[] spawners;
    private GameObject treasure;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2f, 4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Spawn(){
        int indexTreasure = Random.Range(0, 3);
        int indexSpawner = Random.Range(0, 3);
        treasure = Instantiate(spawnObjects[indexTreasure]);
        treasure.transform.position = spawners[indexSpawner].transform.position;

    }
}
