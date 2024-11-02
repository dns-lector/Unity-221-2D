using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    // [SerializeField]
    private TMPro.TextMeshProUGUI scoreText;
    // [SerializeField]
    private TMPro.TextMeshProUGUI timeText;

    private float gameTime;

    void Start()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<TMPro.TextMeshProUGUI>();
        timeText = GameObject.Find("TimeText").GetComponent<TMPro.TextMeshProUGUI>();
        gameTime = 0f;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        timeText.text = gameTime.ToString();

        scoreText.text = CircleScript.score.ToString();
    }

}
/* Взаємодія з полотном Display - зображення динамічних показників
 */
