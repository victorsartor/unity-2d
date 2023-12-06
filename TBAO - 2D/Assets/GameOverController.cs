using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("player"))
        {
            // Colidir com o jogador, então carregar a cena de Game Over
            SceneManager.LoadScene(0); // Substitua "GameOverScene" pelo nome da sua cena de Game Over
        }
    }
}
