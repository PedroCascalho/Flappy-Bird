using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlacarScript : MonoBehaviour
{
    public Text txtPontos;
    public int pontos;

    void Start()
    {
        pontos = 0;
    }
    
    void Update()
    {
        txtPontos.text = pontos.ToString();        
    }
}
