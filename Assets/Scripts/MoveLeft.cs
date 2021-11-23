using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 25;

    private PlayerController playerControllerScript;
    private float lowerLimit = -1;

    void Start()
    {
        // Nos comunicamos con el Script PlayerController
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }
    }
}
