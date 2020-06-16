using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    public float mouseSensitivity = 100f; // adds mouse sensitivity

    public Transform playerBody;

    float xRotation = 0f;

    // Called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // hides and locks the cursor in the middle of the screen
    }

    // Called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // getting the mouse position multiplying it with sensitivity and multiplying it with time deltatime
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // this makes sure the camera doesnt move faster/slower if you have high/low frames per second

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); // Makes sure the player cant look behind the player on the y axis

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);


        playerBody.Rotate(Vector3.up * mouseX); // Makes the player character turn left/right

    }
}
