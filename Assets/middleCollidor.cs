using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class middleCollidor : MonoBehaviour
{
    public LogicScript logic;
    
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>(); // works excectly like adragging dropping but its work instantly
    }

    
    void Update()//codes needed for fixing so updating thscreene score in 
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collison)// whenver object hot the trigger
    {
        if (collison.gameObject.layer == 3)
        {
            logic.scoreAdd(1);//another layer
        }
    }
}
