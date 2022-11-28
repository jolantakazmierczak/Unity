using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad4lab6 : MonoBehaviour
{
    public GameObject player;

    Vector3 direction;

    public float jumpForce = 5f;


    void Update()
    {
        direction = transform.TransformDirection(Vector3.up * jumpForce);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszed³ na wyrzutniê xx.");
        }
    }
            void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player wszed³ na wyrzutnie.");
            player = collision.gameObject;

            player.GetComponent<Rigidbody>().AddForce(direction, ForceMode.Impulse);
        }
    }

}
