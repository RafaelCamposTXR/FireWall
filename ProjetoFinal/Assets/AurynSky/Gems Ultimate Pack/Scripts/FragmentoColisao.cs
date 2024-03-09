using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FragmentoColisao : MonoBehaviour
{
    public AudioSource source;
    public Canvas TelaMensagensDiamante;

    IEnumerator OnTriggerEnter(Collider other)
    {
        InventarioJogador inventario = other.GetComponent<InventarioJogador>();
        if (inventario != null)
        {
            source.Play();
            inventario.ColetarFragmento();

            yield return new WaitForSeconds(0.4f);
            gameObject.SetActive(false);
 

        }
    }

}
