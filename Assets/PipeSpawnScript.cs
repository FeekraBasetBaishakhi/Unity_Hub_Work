using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(pipe, transform.position, transform.rotation); //it will create an object specified position and rotation
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            Instantiate(pipe, transform.position, transform.rotation); //it will create an object specified position and rotation
            timer = 0;
        }
    }
}
