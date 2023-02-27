using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StartScript : MonoBehaviour
{
    public Button btn;

    void Start()
    {
        Button b = btn.GetComponent<Button>();
        b.onClick.AddListener(IniciarJogo);
    }

    void IniciarJogo()
    {
        SceneManager.LoadScene("GameScene");
    }

    
}
