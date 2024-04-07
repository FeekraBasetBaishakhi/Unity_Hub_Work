using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;// myRigidbody name for reference
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive =true;
    
    void Start()
    {
       logic =GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive ==true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        //if (transform.position.y > 17||)
        //{

        //}
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
