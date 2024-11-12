using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UF1_2 : MonoBehaviour
{
    public GameObject Arrow;
    public Transform spawnPoint;
    private Queue<GameObject> _queue;
    public float TimeBetweenSpawns;
    private void Start()
    {
        _queue = new Queue<GameObject>();
        StartCoroutine(SpawnArrow());
    }
    public void Dequeue()
    {
        GameObject arrow = _queue.Dequeue();
        arrow.transform.position = spawnPoint.position;
        arrow.SetActive(true);
    }
    public void Enqueue(GameObject arrow)
    {
        _queue.Enqueue(arrow);
        arrow.SetActive(false);
    }
    private IEnumerator SpawnArrow()
    {
        yield return new WaitForSeconds(TimeBetweenSpawns);
        if (_queue.Count < 1)
            Instantiate(Arrow, spawnPoint.position, Quaternion.identity);
        else
            Dequeue();
    }
}
