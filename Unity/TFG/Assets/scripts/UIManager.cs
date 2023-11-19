using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    //instancia singleton
    private static UIManager instance;
    //getter
    public static UIManager Instance { get { return instance; } }

    [SerializeField]
    TextMeshProUGUI text;

    [SerializeField]
    int lifes = 10;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        text.text = "Vidas restantes: " + lifes;
    }

    public void DecreaseLife()
    {
        if (lifes == 0)
            return;
        lifes--;
        text.text = "Vidas restantes: " + lifes;
    }



}
