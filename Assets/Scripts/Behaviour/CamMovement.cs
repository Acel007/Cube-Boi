using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
	
    private Camera playerCam;

    public float moveSpeed = 1.0f;
    public float rotationSpeed = 1.0f;
    public float zoomSpeed = 1.0f;
    public float minimumZoomY = 20.0f;
    public float maximumZoomY = 4.0f;

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

        zoomCamera(minimumZoomY, maximumZoomY);

    }

    private void moveCamera()
    {
        float xMovement = Input.GetAxis("Horizontal")    * moveSpeed * Time.deltaTime;
        float yMovement = Input.GetAxis("Vertical")      * moveSpeed * Time.deltaTime;

        playerCam.transform.Translate(xMovement, yMovement, yMovement);
    }

    private void zoomCamera(float minZoom, float maxZoom)
    {
        float zoom = Input.mouseScrollDelta.y;
        float currentCamY = playerCam.transform.position.y;

        if( (currentCamY > minZoom && currentCamY < maxZoom) || (currentCamY <= minZoom && zoom < 0) || (currentCamY >= maxZoom && zoom >= 1) )
        {
        
            playerCam.transform.Translate(0, 0, zoom);
        
        }
    }

    private void rotateCamera()
    {
        float camRotationX = Input.GetAxis("Mouse X") * rotationSpeed * Time.deltaTime;

        if(Input.GetMouseButton(1))
        {
        
          playerCam.transform.Rotate(Vector3.up, camRotationX, Space.World);
        
        }
        
    }
    
}