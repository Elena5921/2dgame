using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class player : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float force;
    public Text balltext;
    private int ball = 0;
    public AudioSource audio_bonus;

    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Rb.velocity = Vector2.up * force;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "block")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            PlayerPrefs.SetInt("bal", ball);
        }
        if(collision.tag == "ball")
        {
            ball++;
            balltext.text = ball.ToString();
            Destroy(collision.gameObject);
        }
        if (collision.tag == "kristal")
        {
            Rb.velocity = Vector2.right * 3;
            Destroy(collision.gameObject);
            audio_bonus.Play();
        }
    }

}
