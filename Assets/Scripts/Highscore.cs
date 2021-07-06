using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public Snake snake;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Highcore: {Snake.highscore}";
        Debug.Log($"Highcore: {Snake.highscore}");
    }

    // Update is called once per frame
    void Update()
    {
        //
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Highcore: {Snake.highscore}";
        Debug.Log($"Highcore: {Snake.highscore}");
    }
}
