using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject plane;
    public float speed = 20.0f;
    public float turnSpeed = 5.0f;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public Text countText;
    private Text count;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        Vector3 rotOffset = player.transform.rotation * offset;
        transform.position = player.transform.position + rotOffset;
        transform.rotation = player.transform.rotation;

        // Moves the car forward based on vertical input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        // Rotates the car based on horizontal input
        transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime);
    }
}
