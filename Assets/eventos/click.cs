using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour 
{
    public string mensaje;

    Color clickedColor = Color.green;
    public Color originalColor;
    public bool clicked;


    void Start()
    {
        clicked = false;
        originalColor = GetComponent<Renderer>().material.color;
    }

    void OnMouseDown()
    {
        if (clicked == true){
            clicked = false;
            this.GetComponent<SpriteRenderer>().color = originalColor;
        } else {
            clicked = true;
            this.GetComponent<SpriteRenderer>().color = clickedColor;
        }

        Debug.Log(mensaje);
    }

    public void OnMouseEnter()
    {
        if (clicked == true)
        {
            this.GetComponent<SpriteRenderer>().color = clickedColor;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            clicked = false;
            this.GetComponent<SpriteRenderer>().color = originalColor;
        }
    }

}