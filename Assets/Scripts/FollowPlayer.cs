using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public GameObject PlayerObject;


    public float xMin = -1.5f;
    public float xMax = 1.5f;
    public float yMin = -5.5f;
    public float yMax = 5.5f;


	// Use this for initialization
	void Start () {
        transform.position = new Vector3(PlayerObject.transform.position.x, PlayerObject.transform.position.y, -5);
    }
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 newPos = PlayerObject.transform.position;

        if (newPos.x > xMin && newPos.x < xMax && newPos.y > yMin && newPos.y < yMax)
        {
            transform.position = new Vector3(newPos.x, newPos.y, -5);
        }
    }
}
