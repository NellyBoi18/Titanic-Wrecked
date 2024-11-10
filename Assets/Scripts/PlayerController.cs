using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float rotationSpeed = 100f;
    public float verticalSpeed = 3f;

    //Depth Meter
    public Slider depthSlider;
    public Transform destinationObject;
    float distanceToDestination;

    private void Update()
    {
        // Calculate movement direction based on input
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // Translate the submarine's position based on movement input
        transform.Translate(movement * moveSpeed * Time.deltaTime);

        // Calculate rotation based on horizontal input for turning left and right
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);

        // Calculate vertical movement based on input
        if(Input.GetKey(KeyCode.Space))
        {
            transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }
        else if(Input.GetKey(KeyCode.LeftControl))
        {
            transform.Translate(Vector3.up * -verticalSpeed * Time.deltaTime);
        }


        //Depth Check
        checkDistanceToDestination();
    }

    public void checkDistanceToDestination()
    {
        // Calculate the distance between this GameObject and the targetObject
        distanceToDestination = Vector3.Distance(transform.position, destinationObject.position);

        // Print the distance to the console
        //Debug.Log("Distance to target: " + distanceToDestination);

        depthSlider.value = distanceToDestination;
    }
}
