using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueControl : MonoBehaviour
{
    public Color color;
    public MeshRenderer meshRenderer;
    public bool espInzone, taskInput;
    public int rssi, rssiTrigger, repeticiones;
    public int[] lastNRssi;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer.material.color = color;
        rssi = 0;
        taskInput = false;
    
        /*
        for (int i=0; i < lastNRssi.Length; i++)
        {
            print($"Número de repeticiones -> {lastNRssi}");
            lastNRssi[i] *= 10;
        }*/



        
    }

    // Update is called once per frame
    void Update()
    {
        /*if (taskInput == true) {
            meshRenderer.material.color = Color.grey;
            if (rssi < rssiTrigger) {
                espInzone = true;
                //taskLight = !espInzone;
                meshRenderer.material.color = Color.grey;
            }
            else if (rssi > rssiTrigger) {
                meshRenderer.material.color = Color.blue;
            }
        }
        else {
            meshRenderer.material.color = Color.grey;
        }*/
    }
}
