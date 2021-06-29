using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PerroMovimiento : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform DestinationSpot;
    public Transform OriginSpot;
    public float Speed;
    public bool Switch;

    void Start() {

        InvokeRepeating("Saltar",0.4f,0.5f);
        

    }

    private void Saltar() {

        transform.position = new Vector3(transform.position.x, transform.position.y + 1.5f,transform.position.z);
    }
    // Update is called once per frame
    void Update()
    {
        if(transform.position == DestinationSpot.position)
        {
            Switch = true;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);

        }

        if (transform.position == OriginSpot.position)
        {
            Switch = false;
            transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);

        }

        if (Switch)
        {

            transform.position = Vector3.MoveTowards(transform.position, OriginSpot.position, Speed * Time.deltaTime);


        }

        else
        {
           transform.position = Vector3.MoveTowards(transform.position, DestinationSpot.position, Speed * Time.deltaTime);

        }

    }
}
