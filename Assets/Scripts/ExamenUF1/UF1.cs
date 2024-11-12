using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UF1_1 : MonoBehaviour
{
    public GameObject Arrow;
    public Transform spawnPoint;
    private Stack<GameObject> _stack;
    public float TimeBetweenSpawns;
    private void Start()
    {
        _stack = new Stack<GameObject>();
        StartCoroutine(SpawnArrow());
    }
    public void Pop()
    {
        GameObject arrow = _stack.Pop();
        arrow.transform.position = spawnPoint.position;
        arrow.SetActive(true);
    }
    public void Push(GameObject arrow)
    {
        _stack.Push(arrow);
        arrow.SetActive(false);
    }
    private IEnumerator SpawnArrow()
    {
        yield return new WaitForSeconds(TimeBetweenSpawns);
        if (_stack.Count < 1)
            Instantiate(Arrow, spawnPoint.position, Quaternion.identity);
        else
            Pop();
    }

}
