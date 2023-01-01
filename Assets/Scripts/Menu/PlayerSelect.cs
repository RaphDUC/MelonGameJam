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
    [HideInInspector]
    public GameObject secondPlayer;

    void Awake(){

        if(!instance){
        instance = this;
        DontDestroyOnLoad(this.gameObject);
    } else {
        Destroy(gameObject);
    }
}

    public void PlayGame(){

        string indexPlayer = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;
        
            if(indexPlayer == "0"){
                secondPlayer = players[1];
                chosenPlayer = players[0];
                
            } 
            else if(indexPlayer == "1") {
                secondPlayer = players[0];
                chosenPlayer = players[1];
                
            }

        SceneManager.LoadScene("Gameplay");

        

        }

}
