using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int BoxesRemaining = 6;
    public int BoxesCollected = 0;

    public TextMesh collect;
    public TextMesh remain;

	// Use this for initialization
	void Start () {
        BoxesRemaining = 0;
        BoxesCollected = 0;
    }
	
	// Update is called once per frame
	void Update () {
    
	}

    public void BoxCollected()
    {
        BoxesRemaining--;
        BoxesCollected++;
    }
}
