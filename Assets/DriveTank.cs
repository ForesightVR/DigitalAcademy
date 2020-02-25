using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DriveTank : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public Rigidbody tankPhysics;

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;


        tankPhysics.AddForce(transform.forward * Time.deltaTime * translation, ForceMode.Acceleration);
        //transform.Translate(Vector3.forward * Time.deltaTime * translation);
        transform.Rotate(Vector3.up * Time.deltaTime * rotation);

        Vector3 clampedCoords = new Vector3(Mathf.Clamp(transform.position.x, -8, 8), transform.position.y, transform.position.z);

        transform.position = clampedCoords;

        float distanceFromEdgeL = Vector3.Distance(transform.position, new Vector3(7.9f, transform.position.y, transform.position.z));
        float distanceFromEdgeR = Vector3.Distance(transform.position, new Vector3(-7.9f, transform.position.y, transform.position.z));

        if (distanceFromEdgeL <= 0.1f) { tankPhysics.velocity = (Vector3.zero); }

        if (distanceFromEdgeR <= 0.1f) { tankPhysics.velocity = (Vector3.zero); }
    }
}
