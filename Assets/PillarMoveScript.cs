using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PillarMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    public float deadZone = -35;


    // feekraaaa is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;//ensure the multiplication happens the same, jekono frame rate er jonno and also needed prefrabricated gameobject
        if(transform.position.x < deadZone)
        {
            Destroy(gameObject);    
        }
    }
}
