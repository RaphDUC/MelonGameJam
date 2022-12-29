using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.CompareTag("Monster")){
            Destroy(collision.gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Monster")){
            Destroy(collision.gameObject);
        }
    }
}
