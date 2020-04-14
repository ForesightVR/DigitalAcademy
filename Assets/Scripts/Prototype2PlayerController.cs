using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prototype2PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    // Boundary range for player's horizontal movement
    public float xRange = 10.0f;
    // Start is called before the first frame update
    public GameObject projectilePrefab; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep the player in bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
