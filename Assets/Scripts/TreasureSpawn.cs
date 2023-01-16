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
    private bool left = false;
    private bool right = false;
    private bool center= false;
    private List<bool> position = new List<bool>();

    void Awake(){
        position.Add(left);
        position.Add(right);
        position.Add(center);
    }
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
    
    while(position[indexSpawner] == false){
        treasure = Instantiate(spawnObjects[indexTreasure]);
        treasure.transform.position = spawners[indexSpawner].transform.position;
        position[indexSpawner] = true;
        StartCoroutine(DestroyAfter(treasure, position, indexSpawner));        
    } 


    }

    private IEnumerator DestroyAfter(GameObject obj, List<bool> pos, int index)
    {
            yield return new WaitForSeconds(Random.Range(0, 20));
            Destroy(obj);
            pos[index] = false;

    }
}
