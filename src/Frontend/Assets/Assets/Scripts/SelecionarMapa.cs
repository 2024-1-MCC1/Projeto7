using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelecionarMapa : MonoBehaviour
{
    // Método que carrega a cena "Ilha" quando chamado
    public void CarregarCenaIlha()
    {
        // Usa o SceneManager para carregar a cena "Ilha"
        SceneManager.LoadScene("Ilha");
    }

    // Método que carrega a cena "Barco" quando chamado
    public void CarregarCenaOceano()
    {
        // Usa o SceneManager para carregar a cena "Barco"
        SceneManager.LoadScene("Barco");
    }
}
