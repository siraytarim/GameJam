sing System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class dönüsKOntrol : MonoBehaviour
{

    public Transform transform;

 
    public Animator animator;
    

        private void Start()
    {
       
    }
    void Update()
    {
      
        if (transform.rotation == Quaternion.Euler(-90, 0, 90))
        {
            animator.enabled = false;
        }
        else 
            animator.enabled = true;
   

        
    }

}
