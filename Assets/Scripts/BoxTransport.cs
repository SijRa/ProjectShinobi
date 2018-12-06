using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxTransport : MonoBehaviour {

    public GameObject PlayerModel;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = PlayerModel.transform.position;
    }
}
