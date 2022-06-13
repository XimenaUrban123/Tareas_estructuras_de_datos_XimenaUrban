using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour 
{
    [SerializeField]
    //se crea variable audioS asociada al componente AudioSource
    AudioSource audioS;
    //se crea  variable listaAudio asociado a un arreglo del componente AudioClip en el cual se gurdaran los audios
    public AudioClip[] ListaAudio; 
    //se crea variable de tipo entero con nombre indice y valor inicial 0. Con esta variable se recorrera el arreglo listaAudio
    public int indice = 0;

    // Start is called before the first frame update
    void Start()
    {
        //se obtiene el componente asociado a AudioSource y se asigna a audioS
        audioS = GetComponent<AudioSource>();
        //se asigna a audioS.Clip el audio que se encuentra en el arreglo ListaAudio en la posicion del valor de la variable indice, en este caso 0
        audioS.clip = ListaAudio[indice];
    }

    // Update is called once per frame
    void Update()
    {
        //condicional. en caso de que se apriete la tecla w, se ejecutaran las instrucciones que contiene
        if (Input.GetKey(KeyCode.W))
        {
            //condicional. En caso de que el largo del arreglo ListaAudio sea mayor a indice+1 se ejecutaran las instrucciones que contiene
            if (ListaAudio.Length > indice+1){
                //se suma 1 a la variable indice 
                indice++;
            }  
            else{
                //en caso de que indice+1 sea igual al largo del arreglo, se reinicia a 0 el valor de indice
                indice=0;
            }

        }
        //se asigna a AudioS.Clip el audio correspondiente al arreglo listaAudio para la posicion  del valor actual de indice
        audioS.clip = ListaAudio[indice];
    }   
}    