using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    //instancia singleton
    private static UIManager instance;
    //getter
    public static UIManager Instance { get { return instance; } }

    [SerializeField]
    TextMeshProUGUI text;

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

    public void setLifes(int lifes)
    {
        text.text = "Vidas restantes: " + lifes;
    }


}
