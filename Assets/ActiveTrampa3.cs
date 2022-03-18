using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveTrampa3 : MonoBehaviour {
    public GameObject activarTrampa;
    public Rigidbody rock;
    
    void OnTriggerEnter(Collider other){
        if (other.gameObject.tag == "Carro") {
            rock.GetComponent<Rigidbody> ().useGravity = true;
        }  
    }
}
