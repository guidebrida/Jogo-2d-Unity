using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class PlayerLife : MonoBehaviour
{
    Vector2 startPos;
    [SerializeField] public TextMeshProUGUI texto2;
    private int vidas = 3;


    private void Start()
    {
        startPos = transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstaculo")
        {
            Die();
        }
        if (collision.gameObject.tag == "Enemy")
        {
            Die();
        }

        if (collision.gameObject.tag == "trofeu")
        {
            winGame();
        }
    }

    void Update()
    {
        if (transform.position.y <= -10)
        {
            Die();
        }
    }

        void Die()
    {
      
        Respawn();
        vidas--;
        if (vidas < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        texto2.text = "Vidas: " + vidas;
    }

    void Respawn()
    {
   
        transform.position = startPos;
    }

    void winGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

}