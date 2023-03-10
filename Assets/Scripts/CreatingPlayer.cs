using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CreatingPlayer : MonoBehaviour
{
    public GameObject newPlayer; 
    public GameObject otherPlayer;
    public PlayerInputManager manager;

    void Awake(){
         newPlayer = Instantiate(PlayerSelect.instance.chosenPlayer);
         otherPlayer = PlayerSelect.instance.secondPlayer;
         
    }

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    public void PlayerJoinCalled(){
     StartCoroutine(PlayerJoined());
    }
     public IEnumerator PlayerJoined() { 
          yield return new WaitForSeconds(2f);
    manager.playerPrefab = otherPlayer;
 }
}
