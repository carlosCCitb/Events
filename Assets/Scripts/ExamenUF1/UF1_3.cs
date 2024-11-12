using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UF1_3 : MonoBehaviour
{
    public GameObject Arrow;
    public Transform spawnPoint;
    private List<GameObject> _list;
    public float TimeBetweenSpawns;
    private void Start()
    {
        _list = new List<GameObject>();
        StartCoroutine(SpawnArrow());
    }
    public void Dequeue()
    {
        GameObject arrow = _list[0];
        _list.RemoveAt(0);
        arrow.transform.position = spawnPoint.position;
        arrow.SetActive(true);
    }
    public void Enqueue(GameObject arrow)
    {
        _list.Add(arrow);
        arrow.SetActive(false);
    }
    private IEnumerator SpawnArrow()
    {
        yield return new WaitForSeconds(TimeBetweenSpawns);
        if (_list.Count < 1)
            Instantiate(Arrow, spawnPoint.position, Quaternion.identity);
        else
            Dequeue();
    }
}
