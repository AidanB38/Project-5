using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwards : MonoBehaviour
{
    public float speed = 40.0f;
    public float zPos = 30;
    private GameObject obstacle;
    void Start()
    {
        
    }


    void Update()
    {
        

        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        if (transform.position.z > zPos)
        {

            Destroy(gameObject);
        }
    }

}