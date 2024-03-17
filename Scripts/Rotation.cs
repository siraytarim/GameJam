using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotationAmount = 90f; // Dönme miktarý

    void Update()
    {
        // Farenin sol düðmesine basýldýðýnda
        if (Input.GetMouseButtonDown(0))
        {
            // Fare týklamasýnýn konumunu 3D dünyadaki bir noktaya dönüþtür
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // Eðer bir objeye týklanýrsa
            if (Physics.Raycast(ray, out hit))
            {
                // Týklanan obje bu script'e ait obje mi diye kontrol et
                if (hit.collider.gameObject == gameObject)
                {
                    // Objeyi belirtilen miktarda döndür
                    transform.Rotate(0,0,rotationAmount);
                }
            }
        }
    }
}
