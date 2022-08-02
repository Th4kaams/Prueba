using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go3 : MonoBehaviour
{
    public MeshRenderer _GO3;

    public Go1 _go1;

    public Go2 _go2;
     


    private void Awake()
    {
        _GO3 = GetComponent<MeshRenderer>();

        _go2 = GetComponentInChildren<Go2>();

        _go1 = GetComponentInChildren<Go1>();

       

    }


    public void FixedUpdate()
    {
        

        if (_go1.colorGo1! && _go2.colorGo2! == true )
        {
            _GO3.material.color = Color.white;

            

        }
        else
        {
            _GO3.material.color = Color.black;
        }
        
        
    }
}
