using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadMovement: MonoBehaviour
{
    // Sensibilidade do mouse
    public float mouseSensitivity = 100f;

    // Referência ao transform do jogador
    public Transform playerBody;

    // Rotação vertical da câmera
    float xRotation = 0f;

    void Start()
    {
        // Travar o cursor no centro da tela
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        // Capturar o movimento do mouse
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotação vertical da câmera
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        // Aplicar a rotação da câmera
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Rotacionar o jogador horizontalmente
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
