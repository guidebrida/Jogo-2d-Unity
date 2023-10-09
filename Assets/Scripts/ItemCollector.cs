using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    public int apples = 0;

    [SerializeField] public TextMeshProUGUI texto;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            Destroy(collision.gameObject);
            apples++;
            Debug.Log(apples);
            texto.text = "Pontos: " + apples.ToString();

        }
    }
}
