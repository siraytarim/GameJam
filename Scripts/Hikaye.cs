using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hikaye : MonoBehaviour
{
    public Text textComponent; // Unity aray�z�ndeki Text bile�enini referans almak i�in bir de�i�ken
    public string yazilacakMetin; // Ekrana yaz�lacak metni buraya atay�n
    public float harfGecikmeSuresi = 0.1f; // Her harf aras�ndaki gecikme s�resi

    private void Start()
    {
        StartCoroutine(YaziYazdir());
    }

    IEnumerator YaziYazdir()
    {
        // Metindeki her harfi tek tek yazd�rmak i�in d�ng�
        for (int i = 0; i < yazilacakMetin.Length; i++)
        {
            // Ekrana bir harf ekleyin
            textComponent.text += yazilacakMetin[i];

            // Belirli bir s�re bekleyin
            yield return new WaitForSeconds(harfGecikmeSuresi);
        }
    }
}
