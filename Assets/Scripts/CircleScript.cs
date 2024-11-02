using UnityEngine;

public class CircleScript : MonoBehaviour
{
    public static int score;

    [SerializeField]
    private float forceFactor = 400f;

    private Rigidbody2D rb2d;
    private PauseScript pauseScript;   // посилання на об'єкт скрипту

    void Start()
    {
        rb2d = this.GetComponent<Rigidbody2D>();
        score = 0;
        GameObject pauseCanvas = GameObject.Find("PauseCanvas");
        if( pauseCanvas != null )
        {
            pauseScript = pauseCanvas.GetComponent<PauseScript>();
        }
        else
        {
            Debug.LogError("PauseCanvas not found");
        }
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.AddForce(forceFactor * Time.timeScale * Vector2.up);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.name + " " + other.tag);
        if(other.CompareTag("Fault"))
        {
            if(pauseScript != null)
            {
                pauseScript.ShowMessage("Game over");
            }
            else
            {
                Debug.Log("Game over");
            }
            
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Tube"))
        {
            score += 1;
        }
    }
}
