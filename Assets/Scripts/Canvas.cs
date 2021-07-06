using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Canvas : MonoBehaviour
{
    public Text score, highscore;



    // Start is called before the first frame update
    void Start()
    {
        score = (Text)gameObject.GetComponent(typeof(Text));
        highscore = (Text)gameObject.GetComponent(typeof(Text));
        score.text = "dsfsdfsdf";
        //highscore.text = "12345";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
