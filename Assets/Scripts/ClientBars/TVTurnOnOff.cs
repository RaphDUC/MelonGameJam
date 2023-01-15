using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVTurnOnOff : MonoBehaviour
{
    [HideInInspector]
    public bool isOn = false;
    [HideInInspector]
    public static TVTurnOnOff instance;
    // Start is called before the first frame update

        void Awake(){
        if(!instance){
            instance = this;
        } else {
            Destroy(gameObject);
        }
    }

    void Update() {

        while(isOn == true){
            TVSlider.tv += 30f;
            Destroy(gameObject);
        }
            
    }
            

}
