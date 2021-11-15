using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    Rigidbody2D Rb;
    private float ms = 3.5f;
    private int score = 0;

    public Text scoreTxt;
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");
        float dirY = Input.GetAxisRaw("Vertical");
        Rb.velocity = new Vector2(ms * dirX, ms * dirY);

        batas();

        scoreTxt.text = "" + score;
    }

    void batas()
    {
        Vector2 ScreenPotition = Camera.main.WorldToScreenPoint(transform.position);
        if (ScreenPotition.y > Screen.height || ScreenPotition.y < 0)
        {
            Die();
        }
    }

    public static void Die()
    {
        Debug.Log("Game Over");
        SceneManager.LoadScene("Menu");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "batu")
        {
            Nyawa.health -= 1;
        }
        if (collision.gameObject.tag == "batas")
        {
            score++;
        }
        if (collision.gameObject.tag == "heart")
        {
            Nyawa.health += 1;
            Destroy(GameObject.FindGameObjectWithTag("heart"));
        }
    }
}
