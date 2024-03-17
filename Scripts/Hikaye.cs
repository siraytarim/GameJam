using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hikaye : MonoBehaviour
{
    public Text textComponent; 
    public string yazilacakMetin;
    public float harfGecikmeSuresi = 0.1f; 

    private void Start()
    {
        StartCoroutine(YaziYazdir());
    }

    IEnumerator YaziYazdir()
    {
     
        for (int i = 0; i < yazilacakMetin.Length; i++)
        {
        
            textComponent.text += yazilacakMetin[i];

            yield return new WaitForSeconds(harfGecikmeSuresi);
        }
    }
}
