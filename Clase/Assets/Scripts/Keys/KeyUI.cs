using TMPro;
using UnityEngine;

public class KeyUI : MonoBehaviour
{
    [SerializeField] private TMP_Text textKeys;

    private IKeyProgress progress;

    private void Awake()
    {
        // 1. Busca el KeyManager en la escena y gu�rdalo en progress
        progress = FindAnyObjectByType<KeyManager>();
    }

    private void OnEnable()
    {
        // 2. Suscr�bete a OnKeyCountChanged
        progress.OnKeyCountChanged += ActualizarTexto;
    }

    private void OnDisable()
    {
        // 3. Desuscr�bete
        progress.OnKeyCountChanged-= ActualizarTexto;
    }

    private void ActualizarTexto(int x, int y)
    {
        // 4. Escribe el texto "Llaves: X/Y"
        textKeys.text = $"{x}x{y}";
    }
}