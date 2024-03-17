using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
 
    private Renderer objectRenderer;

   
    void Start()
    {
       
        objectRenderer = GetComponent<Renderer>();

       
        if (objectRenderer == null)
        {
            Debug.LogWarning("Renderer component not found on object!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "kavanoz")
        {
            objectRenderer.material.color = new Color(255,162,0) ;
        }
    }

  
}
