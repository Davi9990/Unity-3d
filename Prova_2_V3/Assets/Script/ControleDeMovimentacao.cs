using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDeMovimentacao : MonoBehaviour
{
    public Animator animator; // Refer�ncia ao Animator do personagem
    public AudioSource audioSource; // Refer�ncia ao AudioSource do personagem

    // Sons correspondentes a cada anima��o
    public AudioClip som1; // Som para o bot�o "ac"
    public AudioClip som2; // Som para o bot�o "ad"
    public AudioClip som3; // Som para o bot�o "ae"
    public AudioClip som4; // Som para o bot�o "bc"
    public AudioClip som5; // Som para o bot�o "bd"
    public AudioClip som6; // Som para o bot�o "be"
    public AudioClip som7; // Som para o bot�o "fg"
    public AudioClip som8; // Som para o bot�o "fh"

    // Fun��o para resetar todas as camadas do Animator
    void ResetAllLayers()
    {
        for (int i = 1; i < animator.layerCount; i++)
        {
            animator.SetLayerWeight(i, 0);  // Reseta o peso de todas as camadas para 0
        }
    }

    // Fun��o para o bot�o "ac" (Movimentar Direita + Agarrar bola baixa)
    public void ac()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(1, 1);  // Ativa a camada de movimenta��o direita
        animator.SetLayerWeight(3, 1); // Ativa a camada de agarrar bola baixa
        audioSource.clip = som1;
        audioSource.Play();
    }

    // Fun��o para o bot�o "ad" (Movimentar Direita + Agarrar bola m�dia)
    public void ad()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(1, 1); // Ativa a camada de movimentar para direita
        animator.SetLayerWeight(4, 1); // Ativa a camada de agarrar bola m�dia
        audioSource.clip = som2;
        audioSource.Play();
    }

    // Fun��o para o bot�o "ae" (Movimentar Direita + Agarrar bola alta)
    public void ae()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(1, 1); // Ativa a camada de movimentar para direita
        animator.SetLayerWeight(5, 1); // Ativa a camada de agarrar bola alta
        audioSource.clip = som3;
        audioSource.Play();
    }

    // Fun��o para o bot�o "bc" (Movimentar Esquerda + Agarrar bola baixa)
    public void bc()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(2, 1); // Ativa a camada de movimentar para esquerda
        animator.SetLayerWeight(3, 1); // Ativa a camada de agarrar bola baixa
        audioSource.clip = som4;
        audioSource.Play();
    }

    // Fun��o para o bot�o "bd" (Movimentar Esquerda + Agarrar bola m�dia)
    public void bd()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(2, 1); // Ativa a camada de movimentar para esquerda
        animator.SetLayerWeight(4, 1); // Ativa a camada de agarrar bola m�dia
        audioSource.clip = som5;
        audioSource.Play();
    }

    // Fun��o para o bot�o "be" (Movimentar Esquerda + Agarrar bola alta)
    public void be()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(2, 1); // Ativa a camada de movimentar para esquerda
        animator.SetLayerWeight(5, 1); // Ativa a camada de agarrar bola alta
        audioSource.clip = som6;
        audioSource.Play();
    }

    // Fun��o para o bot�o "fg" (Matar no peito + Embaixadinha joelho direito)
    public void fg()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(6, 1); // Ativa a camada de matar no peito
        animator.SetLayerWeight(7, 1); // Ativa a camada de embaixadinha com joelho direito
        audioSource.clip = som7;
        audioSource.Play();
    }

    // Fun��o para o bot�o "fh" (Matar no peito + Embaixadinha joelho esquerdo)
    public void fh()
    {
        ResetAllLayers(); // Reseta as camadas antes de ativar a nova anima��o

        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(6, 1); // Ativa a camada de matar no peito
        animator.SetLayerWeight(8, 1); // Ativa a camada de embaixadinha com joelho esquerdo
        audioSource.clip = som8;
        audioSource.Play();
    }
}
