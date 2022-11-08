using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zad_5 : MonoBehaviour
{
    public GameObject myPrefab;
    public int numberOfObjects = 10;


    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < numberOfObjects; i++)
        {
            Vector3 position = new Vector3(Random.Range(-5, 5), 0, Random.Range(-5, 5));
            Instantiate(myPrefab, position, Quaternion.identity);

        }
        // Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);  

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
