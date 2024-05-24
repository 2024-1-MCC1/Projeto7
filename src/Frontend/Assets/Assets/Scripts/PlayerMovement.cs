using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Velocidade de movimento do objeto
    public float velocity = 15.0f;

    // Velocidade de rotação do objeto
    public float rotation = 0.01f;

    // Método chamado antes do primeiro frame de atualização
    void Start()
    {
        // Bloqueia o cursor do mouse para que o jogador possa controlar a câmera
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Método chamado a cada frame
    void Update()
    {
        // Lê as entradas do teclado para o movimento horizontal e vertical
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        // Lê as entradas do mouse para a rotação horizontal e vertical
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        // Calcula a direção de movimento com base nas entradas do teclado
        Vector3 dir = new Vector3(x, 0, y) * velocity;

        // Move o objeto na direção calculada com a velocidade especificada
        transform.Translate(dir * Time.deltaTime);

        // Rotaciona o objeto com base na entrada do mouse
        transform.Rotate(new Vector3(0, mouseX * rotation * Time.deltaTime, 0));
    }
}
