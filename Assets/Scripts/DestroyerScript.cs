using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.name);
        Transform parent = other.transform.parent;
        if (parent != null)
        {
            Destroy(parent.gameObject);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
/* Д.З. Створити проєкт 2D
 * Налаштувати сцену, розмістити рухомі та нерухомі об'єкти
 * Реалізувати рух об'єктів, керування ними, знищення при 
 * виході за сцену.
 * Додати рухомих та нерухомих об'єктів
 * - рослини / будівлі (нерухомі)
 * - хмари / птахи (рухомі)
 * * додати управління персонажем не тільки вгору, а й в боки
 * ! до репозиторію додати скріншоти / відеозаписи
 */
