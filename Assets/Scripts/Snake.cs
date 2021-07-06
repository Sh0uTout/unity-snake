using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Handles the movement of the snake and growing in size.
/// </summary>
[RequireComponent(typeof(BoxCollider2D))]
public class Snake : MonoBehaviour
{
 
    private List<Transform> _segments = new List<Transform>();
    public int kostil;



   //public Text score;



    [Tooltip("The object that is cloned when creating a new segment to grow the snake.")]
    public Transform segmentPrefab;
    public GameObject Canvas;


    [Tooltip("The number of segments the snake has initially.")]
    public static int initialSize = 4;
    public static int score = 0;
    public static int highscore = 0;


    [HideInInspector]
    public Vector2 direction = Vector2.right;

    private void Start()
    {
        ResetState();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        if (Input.GetKeyDown(KeyCode.R))
            ResetState();
        if (Input.GetKeyDown(KeyCode.Space))
            this.direction = Vector2.zero;




        if (this.direction == Vector2.zero)
        {
            if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
            {
                this.direction = Vector2.up;
            }
            else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow))
            {
                this.direction = Vector2.down;
            }
            else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            {
                this.direction = Vector2.right;
            }
            else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            {
                this.direction = Vector2.left;
            }

        }
         if (this.direction.x != 0.0f)
          {

        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow)) {
                this.direction = Vector2.up;
            } else if (Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow)) {
                this.direction = Vector2.down;
            }
          }

          else if (this.direction.y != 0.0f)
          {

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow)) {
                this.direction = Vector2.right;
            } else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow)) {
                this.direction = Vector2.left;
            }
        }

        




      //  score = (Text)gameObject.Find("Score").GetComponent(typeof(Text));
      //  score = (Text)gameObject.GetComponent(typeof(Text));
      //  score.text = "dfsdfsdf";







    }

    private void FixedUpdate()
    {
        kostil++;
        if (kostil % 2 == 1 && this.direction != Vector2.zero)
        {

            for (int i = _segments.Count - 1; i > 0; i--)
            {
                _segments[i].position = _segments[i - 1].position;
            }

            this.transform.position = new Vector3(
                Mathf.Round(this.transform.position.x) + this.direction.x,
                Mathf.Round(this.transform.position.y) + this.direction.y);
        }
    }

    public void Grow()
    {
            
        Transform segment = Instantiate(this.segmentPrefab);
        SpriteRenderer st = (SpriteRenderer)segment.gameObject.GetComponent(typeof(SpriteRenderer));
        
        st.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));

        segment.position = _segments[_segments.Count - 1].position;

        score++;
        _segments.Add(segment);
    }

    public void ResetState()
    {
        //this.direction = Vector2.right;

        this.direction = Vector2.zero;

        this.transform.position = Vector3.zero;

        



            for (int i = 1; i < _segments.Count; i++) {
            Destroy(_segments[i].gameObject);
        }

        _segments.Clear();
        _segments.Add(this.transform);

        for (int i = 0; i < initialSize - 1; i++) {

            Grow();
        }
        kostil = 0;
        if (score - 3 > highscore) highscore = score - 3;
        score = 0;
     
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Grow();
        }
        else if (other.tag == "Obstacle")
        {
            ResetState();
        }
    }

}
