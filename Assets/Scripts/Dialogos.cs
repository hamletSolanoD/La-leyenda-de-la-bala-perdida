using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Dialogos : MonoBehaviour
{
    // Start is called before the first frame update
    public string[] dialogos;
    public Text texto;
    private int contador;
    void Start()
    {
        
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Player" && Input.GetKeyDown(KeyCode.B)){
            texto.text = dialogos[contador];
            if ((dialogos.Length - 1) <= contador) { contador = 0; }
            contador++;     
            Debug.Log("imprimiendo");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
