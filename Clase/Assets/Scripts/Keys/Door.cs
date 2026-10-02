using System;
using UnityEngine;
using TMPro;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject puertaVisual;
    [SerializeField] private Collider puertaCollider;
    [SerializeField] private TMP_Text textMensaje;

    private IKeyProgress progress;

    private void Awake()
    {
        progress = FindAnyObjectByType<KeyManager>();
        // 1. Busca el KeyManager
    }

    private void OnEnable()
    {
        // 2. Suscríbete a OnAllKeysCollected
        progress.OnAllKeysCollected +=AbrirPuerta ;
        
    }

    private void OnDisable()
    {
        // 3. Desuscríbete
        progress.OnAllKeysCollected -=AbrirPuerta ;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            textMensaje.enabled = true;
            textMensaje.text = textMensaje.text;
        }
    }

    private void AbrirPuerta()
    {
        // 4. Apaga lo visual y desactiva el collider
            puertaVisual.SetActive(false);
            puertaCollider.enabled = false;
    }
}