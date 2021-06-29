using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject calaveras;
    public float tiempo;
    void Start()
    {
        InvokeRepeating("invocable", 2.0f, tiempo);
    }
    void invocable() {
        Instantiate(calaveras, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
