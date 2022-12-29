using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterSpawning : MonoBehaviour
{
    [SerializeField]
    private GameObject[] monsterReference;

    private GameObject spawnedMonster;
    private int randomIndex, randomSide;

    [SerializeField]
    private Transform leftPos, rightPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnMonsters());
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnMonsters () {

        while(true){
            yield return new WaitForSeconds(Random.Range(1, 5));

            randomIndex = Random.Range(0, monsterReference.Length);
            randomSide = Random.Range(0, 2);
            spawnedMonster = Instantiate(monsterReference[randomIndex]);

            if(randomSide == 0){
                spawnedMonster.transform.position = leftPos.transform.position;
                spawnedMonster.GetComponent<Monster>().speed = Random.Range(4, 10);
            }
            else {
                spawnedMonster.transform.position = rightPos.transform.position;
                spawnedMonster.GetComponent<Monster>().speed = -Random.Range(4, 10);
                spawnedMonster.transform.localScale = new Vector3(-1f, 1f, 1f);
            }
        }            
    }

}
