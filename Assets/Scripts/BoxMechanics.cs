using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMechanics : MonoBehaviour {

    public GameObject Score;
    public float BoxWeight;
    BoxTransport boxTrans;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "Empty")
        {
            collision.gameObject.tag = "Full";
            boxTrans = gameObject.AddComponent<BoxTransport>();
            boxTrans.PlayerModel = collision.gameObject;
            PlayerMovement playerMovement = collision.transform.GetComponent<PlayerMovement>();
            playerMovement.SetSwimSpeed(BoxWeight);
        }
        else
        {
            Debug.Log("You're full");
        }
    }

    // Use this for initialization
    void Start () {
        BoxWeight = Random.Range(0.5f, 1f);

	}
	
	// Update is called once per frame
	void Update () {

        if(transform.position.y > 5.8f)
        {
            Destroy(gameObject);
            boxTrans.PlayerModel.tag = "Empty";
            Score.GetComponent<GameManager>().BoxCollected();
        }
		
	}
}
