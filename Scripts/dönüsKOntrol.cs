using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dönüsKOntrol : MonoBehaviour
{

    public Transform transform;

    // Animasyon kontrolcüsü
    public Animator animator;
    

        private void Start()
    {
       
    }
    void Update()
    {
        // Nesnenin rotasyonunu kontrol edin ve istenilen açıya ulaştığında animasyonu kapatın
        if (transform.rotation == Quaternion.Euler(-90, 0, 90))
        {
            animator.enabled = false;
        }
        else 
            animator.enabled = true;
            // Animasyonu kapatma

        
    }

}