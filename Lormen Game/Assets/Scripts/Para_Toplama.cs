using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Para_Toplama : MonoBehaviour
{
    public AudioClip paratoplamasesi;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            Oyun_Mekanik player= collision.gameObject.GetComponent<Oyun_Mekanik>();      
            player.score += 10;
            gameObject.SetActive(false);
            FindObjectOfType<Ses_Kontrol>().Play("coin");
            //AudioSource.PlayClipAtPoint(paratoplamasesi, Camera.main.transform.position);
        }
    }
}
