using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;       // Referência ao transform do jogador
    public Vector3 offset;         // Deslocamento da câmera em relação ao jogador
    public float smoothSpeed = 0.125f; // Velocidade de suavização do movimento da câmera

    void LateUpdate()
    {
        // Posição desejada da câmera em relação ao jogador
        Vector3 desiredPosition = player.position + offset;

        // Interpolação suave entre a posição atual da câmera e a posição desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Aplicar a posição suavizada à câmera
        transform.position = smoothedPosition;

        // Opcional: Manter a câmera sempre olhando para o jogador (dependendo do estilo desejado)
        transform.LookAt(player);
    }
}
