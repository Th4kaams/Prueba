using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go5 : MonoBehaviour
{
    private MeshRenderer _mesh;

     public GameObject _go3;

     public GameObject _go4;

    public Material m3;

    public Material m4;

    private void Awake()
    {

        _go3 = GameObject.FindGameObjectWithTag("Player");

        _go4 = GameObject.FindGameObjectWithTag("Finish");

        m3 = _go3.GetComponent<Material>();

        m4 = _go4.GetComponent<Material>();

        _mesh = GetComponent<MeshRenderer>();

    }


    private void FixedUpdate()
    {
        if (m4 == m3)
        {
            _mesh.material.color = Color.black;
        }
        else
        {
            _mesh.material.color = Color.red;
        }

        
    }


}
