using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Snake snake;
    public Text score;

    void Start()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Highcore: {Snake.highscore}";
    }


    void Update()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Highcore: {Snake.highscore}";
    }
}
