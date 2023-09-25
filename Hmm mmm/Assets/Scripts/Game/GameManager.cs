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
    
    public Button restartButton; // Referencia al botón de reinicio
    public GameObject ball;
    
    public bool gameIsOver = false;
    

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

            score = 0;
            scoreText.text = "Puntuación: " + score;
            gameIsOver = true;
        }
    }

    public void InitiateGame()
    {
        Instantiate(ball);
        Debug.LogWarning("Instanciado papaaaaaaaaa");
    }
    


}