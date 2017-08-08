using UnityEngine;
using System.Collections;

public class TiggerCollision : MonoBehaviour {

    void Start()
    {
        gameObject.AddComponent<GlobalVariable>();
    }
    void OnTriggerEnter(Collider other)
    {
        gameObject.GetComponent<GlobalVariable>().getScore();
        // gameObject.GetComponent<GlobalVariable>().test();
        Destroy(gameObject);
    }
        
    void OnTriggerStay(Collider other)
    {

    }

    void OnTriggerExit(Collider other)
    {

    }
}
