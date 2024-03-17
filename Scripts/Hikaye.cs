using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hikaye : MonoBehaviour
{
    public Text textComponent; // Unity arayüzündeki Text bileþenini referans almak için bir deðiþken
    public string yazilacakMetin; // Ekrana yazýlacak metni buraya atayýn
    public float harfGecikmeSuresi = 0.1f; // Her harf arasýndaki gecikme süresi

    private void Start()
    {
        StartCoroutine(YaziYazdir());
    }

    IEnumerator YaziYazdir()
    {
        // Metindeki her harfi tek tek yazdýrmak için döngü
        for (int i = 0; i < yazilacakMetin.Length; i++)
        {
            // Ekrana bir harf ekleyin
            textComponent.text += yazilacakMetin[i];

            // Belirli bir süre bekleyin
            yield return new WaitForSeconds(harfGecikmeSuresi);
        }
    }
}
