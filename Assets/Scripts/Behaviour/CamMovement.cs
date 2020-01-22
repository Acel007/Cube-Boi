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

    }

    private void moveCamera()
    {
        float xMovement = Input.GetAxis("Horizontal")    * moveSpeed * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical")      * moveSpeed * Time.deltaTime;

        playerCam.transform.Translate(xMovement, zMovement, 0);
    }
    
}