using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Suya_Dustun : MonoBehaviour
{
    public GameObject kaybettinEkrani;
    public GameObject yenidenbaslatButton;
    public AudioClip basaramadim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Dalga")
        {
            Time.timeScale = 0;
            kaybettinEkrani.SetActive(true);
            yenidenbaslatButton.SetActive(true);
            FindObjectOfType<Ses_Kontrol>().Play("basaramadim");
            FindObjectOfType<Ses_Kontrol>().Stop("arkaplan");
            //AudioSource.PlayClipAtPoint(basaramadim, Camera.main.transform.position);
        }
    }
}
