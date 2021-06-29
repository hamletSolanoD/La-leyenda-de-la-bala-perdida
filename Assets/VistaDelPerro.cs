using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VistaDelPerro : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerController>().DanioPersonaje(50f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
