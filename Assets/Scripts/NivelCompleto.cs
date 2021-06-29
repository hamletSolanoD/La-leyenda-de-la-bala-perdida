using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NivelCompleto : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas Final;
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") {
            Final.enabled = true;
            Debug.Log("nivel completado");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
