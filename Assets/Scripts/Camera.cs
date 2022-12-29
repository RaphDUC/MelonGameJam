using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private Transform player;

    private Vector3 currentPos; 

    [SerializeField]
    private float minX, maxX;

    private GameObject newPlayer;

    // Start is called before the first frame update
    void Start()
    {

        newPlayer = Instantiate(MenuController.instance.chosenPlayer);
        player = newPlayer.transform;
    
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player){
            return;
        }
        currentPos = transform.position;

        currentPos.x = player.position.x;

        if(currentPos.x > maxX){
            currentPos.x = maxX;
        }else if(currentPos.x < minX){
            currentPos.x = minX;
        }

        transform.position = currentPos;
    }
}
