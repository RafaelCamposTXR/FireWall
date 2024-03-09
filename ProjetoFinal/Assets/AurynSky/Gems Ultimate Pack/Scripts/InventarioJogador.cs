using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventarioJogador : MonoBehaviour
{
    public int QtdFragmentos {  get; private set; }

    public void ColetarFragmento()
    {
        QtdFragmentos++;
    }


}
