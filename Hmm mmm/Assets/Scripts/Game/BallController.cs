using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed = 5f; // Velocidad inicial de la pelota
    private int score = 0;   // Puntuación del jugador

    private Rigidbody rb;
    private Vector2 initialDirection; // Dirección inicial de la pelota
    
    private GameManager gameManager;
    private FirebaseManager fireManager;
    private UIManager uiManager;
   
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        fireManager = FindObjectOfType<FirebaseManager>();
        uiManager   = FindObjectOfType<UIManager>();
        
        rb = GetComponent<Rigidbody>();
        
        // Inicializa la dirección aleatoria de la pelota
        initialDirection = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;

        // Aplica la velocidad inicial a la pelota
        rb.velocity = initialDirection * speed;
    }

    // Detecta colisiones con otros objetos
    private void OnCollisionEnter(Collision collision)
    {
        // Verifica si la colisión ocurrió con el objeto controlado por el jugador
        if (collision.gameObject.CompareTag("Player"))
        {
            // Calcula la nueva dirección de la pelota basada en la posición de la colisión
            Vector2 newDirection = (transform.position - collision.transform.position).normalized;

            // Actualiza la velocidad y dirección de la pelota
            rb.velocity = newDirection * speed;

            // Incrementa la puntuación del jugador
            score++;

            gameManager.IncreaseScore();
            // Puedes mostrar la puntuación en pantalla aquí o en otro lugar
            Debug.Log("Score: " + score);
        }
        else if (collision.gameObject.CompareTag("GameOverTrigger"))
        {
            // La pelota colisiona con el objeto transparente que indica la derrota
            // Llama al método PlayerLost() del GameManager
            
            
            fireManager.SaveDataButton(score);
            uiManager.LostGame();
            gameManager.PlayerLost();
            
            
        }
    }
}