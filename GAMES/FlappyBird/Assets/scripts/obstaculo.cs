using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade = 0.6f;

    [SerializeField]
    private float variacaoY;

    private Vector3 posicaoPassaro;

    private bool ponto;

    private UIScript scriptDaUI;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Start()
    {
        this.posicaoPassaro = GameObject.FindObjectOfType<bird>().transform.position;
        this.scriptDaUI = GameObject.FindObjectOfType<UIScript>();
    }

    void Update()
    {
        if (!this.ponto && this.transform.position.x<posicaoPassaro.x)
        {
            Debug.Log("Pontuou");
            this.ponto = true;
            this.scriptDaUI.addPontos();
        }
        this.transform.Translate(Vector3.left * velocidade * Time.deltaTime);
    }


 //   void OnTriggerEnter2D(Collider2D collision)
  //  {
   //     this.Destruir();
  //  }

 //   void Destruir()
//    {
//        GameObject.Destroy(this.gameObject);
 //   }

}
