using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go2 : MonoBehaviour
{


    public bool colorGo2;

    private MeshRenderer go_2;

    private void Awake()
    {
        go_2 = GetComponent<MeshRenderer>();
    }

    private void FixedUpdate()
    {
        if (colorGo2 == true)
        {
            go_2.GetComponent<MeshRenderer>().material.color = Color.white;

            Debug.Log("El color es Blanco");

            colorGo2 = false;
        }
        else
        {
            go_2.GetComponent<MeshRenderer>().material.color = Color.black;

            Debug.Log("El color es Negro");

            colorGo2 = true;
        }

    }







}
