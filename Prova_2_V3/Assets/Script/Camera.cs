using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;       // Refer�ncia ao transform do jogador
    public Vector3 offset;         // Deslocamento da c�mera em rela��o ao jogador
    public float smoothSpeed = 0.125f; // Velocidade de suaviza��o do movimento da c�mera

    void LateUpdate()
    {
        // Posi��o desejada da c�mera em rela��o ao jogador
        Vector3 desiredPosition = player.position + offset;

        // Interpola��o suave entre a posi��o atual da c�mera e a posi��o desejada
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        // Aplicar a posi��o suavizada � c�mera
        transform.position = smoothedPosition;

        // Opcional: Manter a c�mera sempre olhando para o jogador (dependendo do estilo desejado)
        transform.LookAt(player);
    }
}
