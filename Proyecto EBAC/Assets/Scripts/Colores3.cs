using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colores3 : MonoBehaviour
{
    private void FixedUpdate()
    {
        GameObject cubo = this.gameObject;

        Color c = new Color(Random.value, Random.value, Random.value);

        cubo.GetComponent<MeshRenderer>().material.color = c;
    }
}
