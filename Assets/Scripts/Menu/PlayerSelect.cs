using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSelect : MonoBehaviour
{

    public static PlayerSelect instance;
    [SerializeField]
    private GameObject[] players;

    [HideInInspector]
    public GameObject chosenPlayer;

    public GameObject secondPlayer;

    void Awake(){

        if(!instance){
        instance = this;
    } else {
        Destroy(gameObject);
    }
}

    public void PlayGame(){

        string indexPlayer = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        
            if(indexPlayer == "0"){
                chosenPlayer = players[0];
                secondPlayer = players[1];
            } 
            else if(indexPlayer == "1") {
                chosenPlayer = players[1];
                secondPlayer = players[0];
            }

        SceneManager.LoadScene("Gameplay");

        

        }

}
