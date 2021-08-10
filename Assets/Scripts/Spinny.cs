using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinny : MonoBehaviour
{
    [SerializeField] [Range(1,100)]float rotateSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.tag = "Enemy";
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }
}
