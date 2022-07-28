using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    private void Awake()
    {
        Debug.LogError("hay un error");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.LogWarning("Aqui hay un error");
    }
    private void FixedUpdate()
    {
        Debug.Log("Error continuo");  
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Error");
    }
}
