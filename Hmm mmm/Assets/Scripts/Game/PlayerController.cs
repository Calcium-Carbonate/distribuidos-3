using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 100f; // Velocidad de rotación del jugador

    void Update()
    {
        // Captura la entrada del jugador para la rotación
        float rotationInput = Input.GetAxis("Horizontal");

        // Calcula la cantidad de rotación basada en la entrada del jugador
        float rotationAmount = rotationInput * rotationSpeed * Time.deltaTime;

        // Aplica la rotación al objeto del jugador alrededor del eje vertical (Y)
        transform.Rotate(Vector3.up * rotationAmount);
    }
}

