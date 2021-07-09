using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Snake snake;

    void Start()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Score: {Snake.score}";
    }


    void Update()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Score: {Snake.score}";
    }
}
