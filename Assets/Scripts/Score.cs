using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    public Snake snake;




    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        score.text = $"Score: {Snake.score}";
        Debug.Log($"Score: {Snake.score}");

    }
}
