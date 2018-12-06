using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testScript : MonoBehaviour {

    public float speed = 0.5f;
    public float speed1 = 1f;
    public bool activateme;
    public GameObject Player;
    public GameObject Player1;
    private Transform target;
    public float y;
    public float a = -5;
    public float xa;
    // Vector2 pos;
    // Use this for initialization
    //debug log is like console.writeline
    Vector2  ball;
    public Transform follow;
    Vector2 player2;
    Vector2 temp;
    void Start()
    {
        // pos = new Vector2(5f, 6f);
        // Debug.Log(pos.x);
        // Debug.Log(pos.y);

        temp = transform.position;
        target = Player.GetComponent<Transform>();
       

        //gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        //findout x val
        //Debug.Log(transform.position.x);

        ball = Player.transform.position;
        Debug.Log(ball.y);

        

        if (ball.y < -1)
        {
            
            Vector2 stopper = Player.transform.position;
            Debug.Log(stopper.y);
            Debug.Log("stopper");                 
            ball.y = stopper.y;
        }
        

       
       
        Debug.Log(ball.y);
        Debug.Log("here");
        //gameObject.SetActive(false);

        // y = ball.y;
        //  xa = ball.x;
        //transform.Translate(xa*Time.deltaTime, y* (Time.deltaTime), 0);
        transform.Rotate(0, 0 , 0);
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);

        // temp.x += 1f;
        // transform.position = temp;

       
    }
    void OnCollissionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag.Equals("killer"))
        {
            Destroy(col.gameObject);
            Destroy(gameObject);
        }
    }
}
