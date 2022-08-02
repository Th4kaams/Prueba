using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go1 : MonoBehaviour
{
    public bool colorGo1;

     private MeshRenderer go_1;

    private void Awake()
    {
        go_1 = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        if (colorGo1 == true)
        {
            go_1.GetComponent<MeshRenderer>().material.color = Color.white;

            Debug.Log("El color es Blanco");

            colorGo1 = false;
        }
        else 
        {
            go_1.GetComponent<MeshRenderer>().material.color = Color.black;

            Debug.Log("El color es Negro");

            colorGo1 = true;
        }
        
    }









}
