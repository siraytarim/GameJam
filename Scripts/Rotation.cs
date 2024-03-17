using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationAmount = 90f; 

    void Update()
    {
       
        if (Input.GetMouseButtonDown(0))
        {
      
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

        
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    // Objeyi belirtilen miktarda döndür
                    transform.Rotate(0,0,rotationAmount);
                }
            }
        }
    }
}
