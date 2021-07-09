using UnityEngine;


public class Food : MonoBehaviour
{
    public Collider2D gridArea;

    private void Start()
    {
        RandomizePosition();
    }

    public void RandomizePosition()
    {
        Bounds bounds = this.gridArea.bounds;
        float x = Random.Range(bounds.min.x + 1, bounds.max.x - 1);
        float y = Random.Range(bounds.min.y + 1, bounds.max.y - 1);
        this.transform.position = new Vector2(Mathf.Round(x), Mathf.Round(y));
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        RandomizePosition();
    }
 
}
