using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class menu : MonoBehaviour
{
    public GameObject Spawnblock;
    public player Dragon;
    public GameObject panel;
    public GameObject tumba;
    public AudioSource audio_menu;
    public AudioSource audio_fon;
    public GameObject text_game;
    public GameObject text_menu;
    public Text textm;
    public GameObject text_record;
    public Text textr;
    private int record;
    // Start is called before the first frame update
    void Start()
    {
        Spawnblock.SetActive(false);
        Dragon.enabled = false;
        audio_menu.Play();
        textm.text = PlayerPrefs.GetInt("bal").ToString();
        record = PlayerPrefs.GetInt("record");
        if (PlayerPrefs.GetInt("bal") > record)
        {
            record = PlayerPrefs.GetInt("bal");
            PlayerPrefs.SetInt("record", record);
        }
       
        textr.text = "Рекорд: " + record.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void buttonplay()
    {
        panel.SetActive(false);
        tumba.SetActive(false);
        Dragon.enabled = true;
        Spawnblock.SetActive(true);
        audio_menu.Stop();
        audio_fon.Play();
        text_game.SetActive(true);
        text_menu.SetActive(false);
        text_record.SetActive(false);
    }
    //public void buttonexit()
    //{
    //    if (Input.GetKey("Exit"))
    //    {
    //        Application.Quit();
    //    }



 }

