using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class Rock5 : MonoBehaviour {
   
    void OnCollisionEnter(Collision collision){
        if (collision.gameObject.tag=="Carro") {
        
            Debug.Log ("Game Over");
            Destroy(collision.gameObject);
        }
    }
}
