using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
	
    private Camera playerCam;

    public float moveSpeed = 1.0f;
    public float rotationSpeed = 1.0f;



    // Start is called before the first frame update
    void Start()
    {

        playerCam = GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {

        moveCamera();

        rotateCamera();

    }

    private void moveCamera()
    {
        float xMovement = Input.GetAxis("Horizontal")    * moveSpeed * Time.deltaTime;
        float yMovement = Input.GetAxis("Vertical")      * moveSpeed * Time.deltaTime;

        playerCam.transform.Translate(xMovement, yMovement, yMovement);
    }

    private void rotateCamera()
    {
        float camRotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        if(Input.GetMouseButton(1))
        {
        
            playerCam.transform.RotateAround(Vector3.up, camRotationX);
        
        }
        
    }
    
}