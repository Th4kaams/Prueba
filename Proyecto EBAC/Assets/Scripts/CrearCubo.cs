using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearCubo : MonoBehaviour
{
    public GameObject cubo;
    public List<GameObject> listaDeCubos;
    public float escalamiento = .95f;

    private void Start()
    {
        listaDeCubos = new List<GameObject>();
    }

    void Update()
    {
        GameObject Crear = Instantiate < GameObject > (cubo);
        Crear.transform.position = Random.insideUnitSphere;
        listaDeCubos.Add(Crear);

        List<GameObject> elimiar = new List<GameObject>();

        foreach (GameObject go in listaDeCubos)
        {
            float escala = go.transform.localScale.x;
            escala *= escalamiento;

            go.transform.localScale = Vector3.one * escala;

            if (escala <= 0.1)
            {
                elimiar.Add(go);


            }
        }

        foreach (GameObject go in elimiar)
        {
            listaDeCubos.Remove(go);
            Destroy(go);
        }

    }
}
