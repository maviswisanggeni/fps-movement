using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookRotate : MonoBehaviour
{
    float xRotation = 0f;

    [SerializeField]
    private float mouseSensitifitas = 100f;
    [SerializeField]
    private Transform playerBody;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitifitas * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitifitas * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
