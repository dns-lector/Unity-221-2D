using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField]
    private GameObject content;
    [SerializeField]
    private TMPro.TextMeshProUGUI messageText;

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Time.timeScale = content.activeInHierarchy ? 1.0f : 0.0f;
            content.SetActive( ! content.activeInHierarchy );
        }
    }

    public void ShowMessage(string message)
    {
        Time.timeScale = 0.0f;
        content.SetActive(true);
        messageText.text = message;
    }

    public void OnResumeClick()
    {
        Time.timeScale = 1.0f;
        content.SetActive(false);
    }
    public void OnRestartClick()
    {
        // перезапуск сцени !! необхідно додати сцену до Build
        // File -- Build profile -- Scene List
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
        content.SetActive(false);
    }
}
/* Робота меню паузи
 * - включення/виключення за кнопкою ESC 
 *    !! деактивація об'єкта призводить до деактивації
 *    його скриптів, через що активація вже не є можливою
 * - пауза фізичних процесів задається введенням нульового
 *    масштабу часу
 *    !! час впливає на обрахунок законів фізики, але не
 *    зупиняє виконання методів Update(). Якщо рух забезпечується
 *    примусовим переміщенням, то він буде продовжуватись.
 *    Також будуть враховуватись усі дії на кшталт AddForce()
 *    !! якщо передбачається пауза гри, то всі дії та переміщення
 *    мають враховувати або Time.deltaTime, або Time.timeScale
 */
// Д.З. Завершити роботу з проєктом 2D