using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basardin : MonoBehaviour
{
    public GameObject TebriklerEkrani;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bayrak")
        {
            Time.timeScale = 0;
            TebriklerEkrani.SetActive(true);
            FindObjectOfType<Ses_Kontrol>().Play("basardimanne");
            FindObjectOfType<Ses_Kontrol>().Stop("arkaplan");
        }
    }
}
