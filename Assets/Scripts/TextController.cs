using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextController : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
     texto.text="Pedido: ";   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A)){
            texto.text="Pedido: Burger King";
        }

        else if (Input.GetKeyDown(KeyCode.B)){
            texto.text="Pedido: McDonals";
        } 

        else if (Input.GetKeyDown(KeyCode.C)){
            texto.text="Pedido: KFC";
        }

        else if (Input.GetKeyDown(KeyCode.D)){
            texto.text="Pedido: Little Caesars";
        } 
    }
}
