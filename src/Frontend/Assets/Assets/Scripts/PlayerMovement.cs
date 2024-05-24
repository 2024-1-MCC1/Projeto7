using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Velocidade de movimento do objeto
    public float velocity = 15.0f;

    // Velocidade de rota��o do objeto
    public float rotation = 0.01f;

    // M�todo chamado antes do primeiro frame de atualiza��o
    void Start()
    {
        // Bloqueia o cursor do mouse para que o jogador possa controlar a c�mera
        Cursor.lockState = CursorLockMode.Locked;
    }

    // M�todo chamado a cada frame
    void Update()
    {
        // L� as entradas do teclado para o movimento horizontal e vertical
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // L� as entradas do mouse para a rota��o horizontal e vertical
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calcula a dire��o de movimento com base nas entradas do teclado
        Vector3 dir = new Vector3(x, 0, y) * velocity;

        // Move o objeto na dire��o calculada com a velocidade especificada
        transform.Translate(dir * Time.deltaTime);

        // Rotaciona o objeto com base na entrada do mouse
        transform.Rotate(new Vector3(0, mouseX * rotation * Time.deltaTime, 0));
    }
}
