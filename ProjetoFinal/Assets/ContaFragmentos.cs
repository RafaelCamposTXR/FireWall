using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContaFragmentos : MonoBehaviour
{
    public InventarioJogador fragmentos;
    // Start is called before the first frame update
    void Start()
    {
        //InventarioJogador inventario = fragmentos.GetComponent<InventarioJogador>();
    }

    // Update is called once per frame
    void Update()
    {
        if (fragmentos != null)
        {
            if (fragmentos.QtdFragmentos >= 7) {
                Invoke("Vitoria", 4f);
            }
        }
    }
    void Vitoria()
    {
        Time.timeScale = 0;
        SceneManager.LoadScene("TESTE");
    }
}
