using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float volume=PlayerPrefs.GetFloat("Volume", 1);
        AudioListener.volume = volume;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenSettings()
    {
        SceneManager.LoadScene("settings");
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGameA()
    {
        Debug.Log("Game's launched !");
        //SceneManager.LoadScene("House");
    }

    
}
