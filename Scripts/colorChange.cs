using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChange : MonoBehaviour
{
    // Nesnenin Renderer bile�eni
    private Renderer objectRenderer;

    // Kodun ba�lang�c�nda �al��an fonksiyon
    void Start()
    {
        // Nesnenin Renderer bile�enine eri�im sa�lama
        objectRenderer = GetComponent<Renderer>();

        // E�er nesnenin Renderer bile�eni yoksa uyar� ver
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

    // Herhangi bir tu�a bas�ld���nda �al��an fonksiyon
}
