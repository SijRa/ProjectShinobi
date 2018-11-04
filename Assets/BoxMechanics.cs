using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMechanics : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Empty")
        {
            collision.transform.tag = "Full";
            BoxTransport thisBox = gameObject.AddComponent<BoxTransport>();
            thisBox.PlayerModel = collision.gameObject;

        }
        else
        {
            Debug.Log("You're full");
        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
