using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;



public class PlayerController : MonoBehaviour
{
    public float Velocity;
    public float Aceleration;
    private float VelocityI;
    public float Jump;
    public float Fly;
    private bool Grounded;
    private Slider PowerBar;
    private Animator AnimatorController;
    
    void KeyMap() {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x + Velocity, GetComponent<Transform>().position.y);
            GetComponent<Transform>().localScale = new Vector2(1, 1);
            Velocity += Aceleration;
            AnimatorController.SetBool("Caminando", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().position = new Vector2(GetComponent<Transform>().position.x - Velocity, GetComponent<Transform>().position.y);
            GetComponent<Transform>().localScale = new Vector2(-1, 1);
            Velocity += Aceleration;
            AnimatorController.SetBool("Caminando", true);
        }
        else {
            Velocity = VelocityI;
            AnimatorController.SetBool("Caminando", false);
        }

        if ((Input.GetKey(KeyCode.UpArrow)|| Input.GetKey(KeyCode.W)) && Grounded)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetX(),Jump);
            AnimatorController.SetBool("Saltar", true);
        }
        

      

        if (Input.GetKey(KeyCode.Q) && PowerBar.value >= 5)
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(GetX(), GetY() + Fly);
            AnimatorController.SetBool("Saltar", true);
            PowerBar.value -= 5;
            Debug.Log("volando");
        }
    
    }
    public void DanioPersonaje(float danio) {

        PowerBar.value -= danio;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Grounded = true;
            Debug.Log("grounded");
            AnimatorController.SetBool("Saltar", false);
        }
        if (collision.transform.tag == "PanDeMuerto")
        {
            PowerBar.value++;
            Debug.Log("Pan");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.transform.tag == "PanDeMuerto")
        {
            PowerBar.value++;
            Debug.Log("Pan");
        }
    }
 

private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            Grounded = false;
            Debug.Log("UNgrounded");
        }
    }



    private float GetX() {
        return GetComponent<Rigidbody2D>().velocity.x;
    }
    private float GetY()
    {
        return GetComponent<Rigidbody2D>().velocity.y;
    }



    void Start()
    {
        VelocityI = Velocity;
        AnimatorController = GetComponent<Animator>();
        PowerBar = FindObjectOfType<Slider>();


    }

    private void FixedUpdate()
    {
        KeyMap();
        PowerBar.value += 0.05f;

    }
}
