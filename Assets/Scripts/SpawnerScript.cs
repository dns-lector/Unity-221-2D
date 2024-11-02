using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField]
    private GameObject TubePrefab;
    [SerializeField]
    private float TubeSpawnShift = 1.0f;
    [SerializeField]
    private float timeout = 4.0f;
    private float leftTime;

    void Start()
    {
        // leftTime = timeout;  // перший запуск - через timeout
        leftTime = 0f;          // перший запуск - одразу
    }

    void Update()
    {
        leftTime -= Time.deltaTime;
        if (leftTime <= 0)
        {
            SpawnTube();
            leftTime = timeout;
        }
    }

    private void SpawnTube()
    {
        var tube = GameObject.Instantiate(TubePrefab);   // ~new TubePrefab()
        tube.transform.position = this.transform.position;
        tube.transform.position += Vector3.up * 
            Random.Range(-TubeSpawnShift, TubeSpawnShift);
    }
}
/* Скрипт, що відповідає за появу об'єктів
 * Ідея: відлік часу (таймер)
 */
