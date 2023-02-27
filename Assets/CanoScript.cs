using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanoScript : MonoBehaviour
{

    public float velocidade;
    public float limiteX;
    public float limiteSuperiorY;
    public float limiteInferiorY;

    private Vector2 posicaoInicial;


    void Start()
    {
        posicaoInicial = transform.position;
        EscolherAltura(limiteInferiorY, limiteSuperiorY);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocidade * Time.deltaTime);

        if(transform.position.x < limiteX)
        {
            transform.position = posicaoInicial;
            EscolherAltura(limiteInferiorY, limiteSuperiorY);
        }

    }

    void EscolherAltura(float a, float b)
    {
        float alturaY = Random.Range(a, b);
        transform.position = new Vector2(transform.position.x, alturaY);
    }


}
