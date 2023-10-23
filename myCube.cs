using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCube : MonoBehaviour
{
    float moveX;
    float moveY;
    float moveZ;
    float leftSide;
    float rightSide;
    float topSide;
    float bottomSide;
    float movementSpeed;
    float horiMovement;
    float vertMovement;
    Rigidbody myCubey;
   


    // Start is called before the first frame update
    void Start()
    {
        myCubey = GetComponent<Rigidbody>();

        movementSpeed = 8;
        moveX = 0;
        moveY = 0;
        moveZ = 0;

    }

    // Update is called once per frame
    void Update()
    {
        horiMovement = Input.GetAxis("Horizontal");
        vertMovement = Input.GetAxis("Vertical");

        transform.Translate(0, 0, vertMovement * Time.deltaTime * movementSpeed);
        transform.Translate(horiMovement * Time.deltaTime * movementSpeed, 0, 0);



    }
}
