using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControleDeMovimentacao : MonoBehaviour
{
    public Animator animator; // Referência ao Animator do personagem
    public AudioSource audioSource; // Referência ao AudioSource do personagem

    // Sons correspondentes a cada animação
    public AudioClip som1; // Som para o botão "ac"
    public AudioClip som2; // Som para o botão "ad"
    public AudioClip som3; // Som para o botão "ae"
    public AudioClip som4; // Som para o botão "bc"
    public AudioClip som5; // Som para o botão "bd"
    public AudioClip som6; // Som para o botão "be"
    public AudioClip som7; // Som para o botão "fg"
    public AudioClip som8; // Som para o botão "fh"

    // Função para o botão "ac" (Movimentar Direita + Agarrar bola baixa)
    public void ac()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(0, 1); // Ativa a camada de movimentar para direita
        animator.SetLayerWeight(1, 1); // Ativa a camada de agarrar bola baixa
        audioSource.clip = som1;
        audioSource.Play();
    }

    // Função para o botão "ad" (Movimentar Direita + Agarrar bola média)
    public void ad()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(0, 1); // Ativa a camada de movimentar para direita
        animator.SetLayerWeight(2, 1); // Ativa a camada de agarrar bola média
        audioSource.clip = som2;
        audioSource.Play();
    }

    // Função para o botão "ae" (Movimentar Direita + Agarrar bola alta)
    public void ae()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(0, 1); // Ativa a camada de movimentar para direita
        animator.SetLayerWeight(3, 1); // Ativa a camada de agarrar bola alta
        audioSource.clip = som3;
        audioSource.Play();
    }

    // Função para o botão "bc" (Movimentar Esquerda + Agarrar bola baixa)
    public void bc()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(4, 1); // Ativa a camada de movimentar para esquerda
        animator.SetLayerWeight(1, 1); // Ativa a camada de agarrar bola baixa
        audioSource.clip = som4;
        audioSource.Play();
    }

    // Função para o botão "bd" (Movimentar Esquerda + Agarrar bola média)
    public void bd()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(4, 1); // Ativa a camada de movimentar para esquerda
        animator.SetLayerWeight(2, 1); // Ativa a camada de agarrar bola média
        audioSource.clip = som5;
        audioSource.Play();
    }

    // Função para o botão "be" (Movimentar Esquerda + Agarrar bola alta)
    public void be()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(4, 1); // Ativa a camada de movimentar para esquerda
        animator.SetLayerWeight(3, 1); // Ativa a camada de agarrar bola alta
        audioSource.clip = som6;
        audioSource.Play();
    }

    // Função para o botão "fg" (Matar no peito + Embaixadinha joelho direito)
    public void fg()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(5, 1); // Ativa a camada de matar no peito
        animator.SetLayerWeight(6, 1); // Ativa a camada de embaixadinha com joelho direito
        audioSource.clip = som7;
        audioSource.Play();
    }

    // Função para o botão "fh" (Matar no peito + Embaixadinha joelho esquerdo)
    public void fh()
    {
        if (audioSource.isPlaying)
        {
            audioSource.Stop();
        }

        animator.SetLayerWeight(5, 1); // Ativa a camada de matar no peito
        animator.SetLayerWeight(7, 1); // Ativa a camada de embaixadinha com joelho esquerdo
        audioSource.clip = som8;
        audioSource.Play();
    }
}
