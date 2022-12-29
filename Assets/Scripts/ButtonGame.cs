using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonGame : MonoBehaviour
{
    public void buttonGame(){
        string button = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        if(button == "Restart"){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else if(button == "Home") {
            SceneManager.LoadScene("Menu");
        } 
         
    }

   
}
