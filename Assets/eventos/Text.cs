using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Text : MonoBehaviour
{
    public TextMeshProUGUI texto;
    // Start is called before the first frame update
    void Start()
    {
        texto.text="Haga click para escoger su pedido. Presione espacio para confirmar";   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            texto.text="Pedido realizado correctamente!";
        }
    }
}