using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float Bonks = 0f;

    [SerializeField] [Range(1f,100f)] float moveSpeed = 10f;
    [SerializeField] [Range(1f,100f)] float jumpHeight = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game start");
    }

    // Update is called once per frame
    void Update()
    {
        //Makes the cursor not visible
        Cursor.visible = false;

        //Input variables
        float x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float y = Input.GetAxis("Jump") * jumpHeight * Time.deltaTime;
        float z = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        
        transform.Translate(x, y, z);
    }
    void OnCollisionEnter(Collision other) 
    {
        Bonker bonker = GetComponent<Bonker>();
        if(other.gameObject.tag == "Bonk")
        {
            Bonks++;
            Debug.Log(Bonks);
        }
    }
}
