using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorHorizontal : MonoBehaviour
{

    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    public float distance = 6.6f;
    private bool isRunningRight = true;
    private bool isRunningLeft = false;
    private float leftPosition;
    private float rightPosition;

    private bool goBack = false;

    void Start()
    {
        rightPosition = transform.position.x + distance;
        leftPosition = transform.position.x;
    }

    void Update()
    {
        if (isRunningRight && transform.position.x >= rightPosition)
        {
            isRunning = false;
            goBack = true;

        }
        else if (isRunningLeft && transform.position.x <= leftPosition)
        {
            isRunning = false;
        }

        if (isRunning)
        {

            Vector3 move = transform.right * elevatorSpeed * Time.deltaTime;
            transform.Translate(move);
            goBack = false;
        }

        if (goBack)
        {
            Vector3 move = transform.right * -1 * elevatorSpeed * Time.deltaTime;
            transform.Translate(move);
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszed³ na windê.");

            if (transform.position.y >= rightPosition)
            {
                isRunningLeft = true;
                isRunningRight = false;
                elevatorSpeed = -elevatorSpeed;
            }
            else if (transform.position.y <= leftPosition)
            {
                isRunningRight = true;
                isRunningLeft = false;
                elevatorSpeed = Mathf.Abs(elevatorSpeed);
            }
            isRunning = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player zszed³ z windy.");
        }
    }


}
