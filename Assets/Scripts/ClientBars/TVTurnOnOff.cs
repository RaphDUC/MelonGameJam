using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVTurnOnOff : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Client")){
            TVSlider.tv += 30f;
            Destroy(gameObject);
        }
    }
}
