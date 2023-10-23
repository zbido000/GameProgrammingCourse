using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestMovements : MonoBehaviour
{
    bool isitColliding;
    Rigidbody myObstacles; 

    // Start is called before the first frame update
    void Start()
    {
        myObstacles = GetComponent<Rigidbody>();
        isitColliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(isitColliding == false){
            transform.position += new Vector3(0, 0, 2 * Time.deltaTime);

        }

        if (isitColliding == true){

            transform.position += new Vector3(0, 0, -2 * Time.deltaTime);
        }
    }



    void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag == "WallNorth")
        {
            isitColliding = true;
            transform.position += new Vector3(0, 0, 0);
            // tranform.Translate(0,0, -4);
        }


        if (other.gameObject.tag == "WallSouth" && isitColliding == true)
        {
            isitColliding = false;
            transform.position += new Vector3(0, 0, 0);
            // transform.Translate(0,0, -4);



        }

    }
}




