using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    public GameObject copy;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Enemy";
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.useGravity = false;
        InvokeRepeating("SpawnObject", 1f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody rb = GetComponent<Rigidbody>();

        if (Time.time >= Random.Range(1f,10f))
        {
            rb.useGravity = true;
        }
    }
   
    void SpawnObject()
    {
        float positionx = Random.Range(-18.5f,18.5f);
        float positiony = Random.Range(0f,10f);
        float positionz = Random.Range(-18.5f,18.5f);
        
        Instantiate(copy, new Vector3(positionx,positiony,positionz), Quaternion.identity);
    }
}
