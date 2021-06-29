using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollower : MonoBehaviour
{
    private bool Centered;
    public GameObject CameraGame;
    public float velocityX;
    public float velocityY;
    public float acelerationX;
    public float acelerationY;
    private float firstVelocityX;
    private float firstVelocityY;
    void Start()
    {


        firstVelocityX = velocityX;
        firstVelocityY = velocityY;
}
    private void OnTriggerExit(Collider other)
    {
        if (other.transform.name == "Knight")
        {

            Centered = false;
            Debug.Log("Is not  Centered");
        }
    }



    private void MoveCamera()
    { 

            if (RayCubeFollowerSides.getSide() == -1 || RayCubeFollowerSides.getSide() == 1)
            {
            velocityX += acelerationX * Time.deltaTime;
                CameraGame.transform.position = new Vector3(CameraGame.transform.position.x + ((RayCubeFollowerSides.getSide()) * velocityX), CameraGame.transform.position.y, CameraGame.transform.position.z);
            }

        if (RayCubeFollowerSides.getSide() == 5 || RayCubeFollowerSides.getSide() == -5)
        {
            velocityY += acelerationY * Time.deltaTime;
            CameraGame.transform.position = new Vector3(CameraGame.transform.position.x, CameraGame.transform.position.y + ((RayCubeFollowerSides.getSide() / 5) * velocityY), CameraGame.transform.position.z);
        }
       
        if (RayCubeFollowerSides.getSide() == 0 )
        {
           
            CameraGame.transform.position = new Vector3(CameraGame.transform.position.x , CameraGame.transform.position.y, CameraGame.transform.position.z);
            velocityX = firstVelocityX;
            velocityY = firstVelocityY;
        }
      
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            Centered = true;
            Debug.Log("Is  Centered");

        }
    }

    public bool GetCenteredKnight()
    {
        return Centered;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }
}
