using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class soundManager : MonoBehaviour
{
    public AudioClip clip;
    public static soundManager instance;
    public AudioSource audio;
    public TMP_Text currentscore;
    public TMP_Text healths;
    public int score = 0;
    public int health = 50;
    private void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        currentscore.text = score.ToString();
        healths.text = health.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void playAudio()
    {
        audio.PlayOneShot(clip);
    }
    public void Add()
    {
        score += 1;
        currentscore.text = score.ToString();
    }
    public void healthloss()
    {
        health -= 5;
        healths.text = health.ToString();

    }

}
