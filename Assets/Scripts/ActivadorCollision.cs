using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivadorCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Activar;
    public GameObject Activador;

    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == Activador.name) {
            foreach(GameObject i in Activar)
            {
                i.SetActive(true);
                Debug.Log("activador colison");
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == Activador.name)
        {
            foreach (GameObject i in Activar)
            {
                i.SetActive(false);
                Debug.Log("desactivar colison");
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
