using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MensagemCode : MonoBehaviour
{
    public GameObject MensagemDiamante;

    void Start()
    {
        MensagemDiamante.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            ContinueGame();
        }
    }

    public void SopraTestar()
    {
        Debug.Log("Cliciou hein, eu vi");
    }

    public void ContinueGame()
    {
        MensagemDiamante.SetActive(false);
    }
}
