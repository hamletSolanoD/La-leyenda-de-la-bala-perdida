using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Calavera : MonoBehaviour
{
    // Start is called before the first frame update
    public float velocidad;
    public float Destroy;
    private float direction = 1;
    void Start()
    {
        Destroy(this.gameObject, Destroy);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Vector3 dir = (collision.gameObject.transform.position - gameObject.transform.position).normalized;
       
            if (dir.x > 0)
            {
            direction = -1;
            }
            else if (dir.x < 0)
            {
            direction = 1;
        }
        if (collision.transform.tag == "Player") {
            collision.gameObject.GetComponent<PlayerController>().DanioPersonaje(20f);

        }
        }
  
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = new Vector3(transform.position.x + (direction*velocidad), transform.position.y, transform.position.z);
    }
}
