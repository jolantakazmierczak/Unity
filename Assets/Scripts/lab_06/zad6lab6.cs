using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad6lab6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("cube"))
        {
            Debug.Log("Player uderzył w przeszkodę");
        }
    }

}
