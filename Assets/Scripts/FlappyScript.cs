using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyScript : MonoBehaviour
{
    
    public float impulso;
    public float intensidadeRotacao;
    public AudioClip[] clips;

    
    private Rigidbody2D rb;
    private AudioSource au;
 
    private CanoScript canoScript;

    private bool impulsionando;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        au = GetComponent<AudioSource>();        
        rb.gravityScale = 0.0f;

        canoScript = GameObject.FindGameObjectWithTag("Cano").GetComponent<CanoScript>();
        canoScript.enabled = false;
    }
    
    
    void Update()
    {

        // INPUT PARA APLICAR O IMPULSO
        if (Input.GetButtonDown("Fire1"))
        {
            // ATIVA A GRAVIDADE
            if(rb.gravityScale == 0.0f)
            {
                rb.gravityScale = 1.0f;
                canoScript.enabled = true;
            }

            // FLAG IMPULSO
            impulsionando = true;

        }

        // ROTACAO DO PERSONAGEM
        transform.rotation = Quaternion.Euler(0.0f, 0.0f, rb.velocity.y * intensidadeRotacao);

    }

    private void FixedUpdate()
    {
        if (impulsionando)
        {
            au.clip = clips[0];
            au.Play();

            rb.velocity = new Vector2(rb.velocity.x, impulso);
            impulsionando = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        au.clip = clips[1];
        au.Play();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<AudioSource>().Play();
        GameObject.Find("Canvas").GetComponent<PlacarScript>().pontos++;
    }


}
