using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cruz : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().DanioPersonaje(100f);

        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
