using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsula_se_mueve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 5f; // Velocidad de movimiento

    private void Update()
    {
        // Capturar entrada del teclado
        float moveX = Input.GetAxis("Horizontal"); // A y D
        float moveZ = Input.GetAxis("Vertical");   // W y S

        // Crear vector de movimiento
        Vector3 move = new Vector3(moveX, 0, moveZ) * speed * Time.deltaTime;

        // Aplicar movimiento
        transform.Translate(move);
    }
}
