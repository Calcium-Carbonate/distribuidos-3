using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // Para reiniciar la escena

public class GameManager : MonoBehaviour
{
    public TMP_Text scoreText; // Referencia al objeto Text para mostrar la puntuación
    private int score = 0; // Puntuación del jugador

    public GameObject gameOverPanel; // Referencia al panel de Game Over
    public Button restartButton; // Referencia al botón de reinicio
    
    private bool gameIsOver = false;
    
    private void Start()
    {
        // Oculta el panel de Game Over al inicio
        gameOverPanel.SetActive(false);

        // Asigna una función al botón de reinicio
        restartButton.onClick.AddListener(RestartLevel);
    }

    // Método para incrementar la puntuación y actualizar el marcador
    public void IncreaseScore()
    {
        if (!gameIsOver)
        {
            score++;
            scoreText.text = "Puntuación: " + score;
        }
    }

    // Método para manejar la pérdida del jugador
    public void PlayerLost()
    {
        if (!gameIsOver)
        {
            // Muestra el panel de Game Over
            gameOverPanel.SetActive(true);
            gameIsOver = true;
        }
    }
    
    // Método para reiniciar el nivel
    public void RestartLevel()
    {
        // Carga la escena actual (esto reiniciará el nivel)
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}