using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedorControl : MonoBehaviour
{


    public Transform bloque;
    public Vector3[] direcciones;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        bloque.position += Vector3.right * Time.deltaTime;
        if(bloque.position.x > 4)
        {
            bloque.position += Vector3.left * Time.deltaTime;
        }
        else if (bloque.position.x < 0)
        {
            bloque.position += Vector3.right * Time.deltaTime;
        }

    }
}
