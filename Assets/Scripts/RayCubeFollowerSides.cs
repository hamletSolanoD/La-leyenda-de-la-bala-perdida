using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCubeFollowerSides : MonoBehaviour
{
    // Start is called before the first frame 
    public int Side;

    private static int CourrentSide;

    void Start()
    {

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            CourrentSide = Side;
        }
    }
    public static int getSide()
    {
        return CourrentSide;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log(CourrentSide);
    }
}
