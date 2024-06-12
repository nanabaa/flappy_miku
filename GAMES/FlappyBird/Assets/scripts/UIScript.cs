using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIScript : MonoBehaviour
{
    private int pontos;
    private Label textoPontuacao;
    // Start is called before the first frame update
    public void addPontos()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    private void Start()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        textoPontuacao = root.Q<Label>("pontos");
    }
}
