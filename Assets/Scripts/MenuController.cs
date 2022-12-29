using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    [SerializeField]
    private GameObject[] players;

    [HideInInspector]
    public GameObject chosenPlayer;

    public static MenuController instance;

    void Awake() {
        if(!instance){
            instance = this;
        } 
        else {
            Destroy(gameObject);
        }
    }

    public void PlayGame(){

        string indexPlayer = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        
            if(indexPlayer == "0"){
                chosenPlayer = players[0];
            } 
            else if(indexPlayer == "1") {
                chosenPlayer = players[1];
            }

        SceneManager.LoadScene("Gameplay");

        

        }

   
}
