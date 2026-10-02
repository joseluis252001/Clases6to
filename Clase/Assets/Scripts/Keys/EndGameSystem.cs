using UnityEngine;

public class EndGameSystem : MonoBehaviour
{
    [SerializeField] private Canvas endGameCanvas;

    private void Awake()
    {
        // 1. Deja el menú oculto al iniciar
        endGameCanvas.enabled = false;
        
    }

    private void OnTriggerEnter(Collider other)
    {
      
        // 2. Si no es el Player, no hagas nada
        if (other.tag != "Player")
        {
            return;
        }
        // 3. Muestra el menú
        endGameCanvas.enabled = true;
        // 4. Detén el juego
        Time.timeScale = 0;
        // 5. Haz desaparecer el objeto dorado
        gameObject.GetComponent<EndGameSystem>().enabled = false;
        // 6. WUUUUUUUU
        
    }
}