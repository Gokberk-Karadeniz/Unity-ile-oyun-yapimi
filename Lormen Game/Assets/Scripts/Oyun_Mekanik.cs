using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Oyun_Mekanik : MonoBehaviour
{
    

    Rigidbody2D kurbagaRB;
    Vector3 kurbaga_hareket;
    public int score;
    public TextMeshProUGUI playerScoreText;
    public bool isGround = false;
    Transform tagGround;
    public LayerMask layer;
    public float hInput = 0;
    float kurbaga_hiz = 7f;
    float kurbaga_ziplama = 10f;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        kurbagaRB = GetComponent<Rigidbody2D>();
        tagGround = GameObject.Find(this.name + "/tag_Ground").transform;
    }

     //Update is called once per frame
    void Update()
    {
        Move(hInput);
        transform.position += kurbaga_hareket * kurbaga_hiz * Time.deltaTime;
        isGround= Physics2D.Linecast(this.transform.position, tagGround.position, layer);


        
        playerScoreText.text ="Score : "+ score.ToString();
        kurbaga_hareket = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += kurbaga_hareket * kurbaga_hiz * Time.deltaTime;

        if (Input.GetButtonDown("Jump") && Mathf.Approximately(kurbagaRB.velocity.y,0))
        {
            kurbagaRB.AddForce(Vector3.up * kurbaga_ziplama, ForceMode2D.Impulse);
        }
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
       

    }
   private void Move(float horizontal)
    {
        Vector2 vel = kurbagaRB.velocity;
        vel.x = horizontal * kurbaga_hiz;
        kurbagaRB.velocity = vel;
    }
  public void MobileMove(float input)
    {
        hInput = input;
    }
    public void Jump()
    {
        if (isGround)
        {            
            kurbagaRB.velocity += Vector2.up * kurbaga_ziplama;
        }
    }
 
}
