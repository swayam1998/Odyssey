using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float zSpeedFactor;
    public Camera mainCam;
    private Vector3 CamPos;
    private float zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        CamPos = mainCam.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(zSpeed);
        zSpeed += zSpeedFactor * Time.deltaTime;
        Vector3 moveInput = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), zSpeed);
        transform.position = transform.position + moveInput * moveSpeed * Time.deltaTime;
    
        mainCam.transform.position = new Vector3(0, 0, transform.position.z) + CamPos;
    }
}
