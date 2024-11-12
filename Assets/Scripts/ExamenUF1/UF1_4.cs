using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UF1_4 : MonoBehaviour
{
    public GameObject Arrow;
    public Transform SpawnPoint;
    private GameObject[] _array;
    public float TimeBetweenSpawns;
    public float ArrowSpeed, RoomLenght;
    private int _arrayLength;
    private void Start()
    {
        float maxArrows = RoomLenght / (ArrowSpeed * TimeBetweenSpawns);
        if (maxArrows % 1 != 0)
            //% returns the remainder when dividing maxArrows / 1
            _arrayLength = Mathf.FloorToInt(10.0F) + 1;
            //FloorToInt truncates a float into int
        else
            _arrayLength = Mathf.FloorToInt(10.0F);
        _array = new GameObject[_arrayLength];
        for (int i = 0; i < _arrayLength; i++)
            _array[i] = null;
        StartCoroutine(SpawnArrow());
    }
    public void Pop(int i)
    {
        GameObject arrow = _array[i];
        _array[i] = null;
        arrow.transform.position = SpawnPoint.position;
        arrow.SetActive(true);
    }
    public void Push(GameObject arrow)
    {
        bool foundArrow = true;
        int location = 0;
        while (foundArrow && location < _arrayLength + 1)
        {
            foundArrow = _array[location] == null ? false : true;
            location++;
        }
        _array[location-1] = arrow;
        arrow.SetActive(false);
    }
    private IEnumerator SpawnArrow()
    {
        yield return new WaitForSeconds(TimeBetweenSpawns);
        bool foundArrow = false;
        int location = 0;
        while(!foundArrow && location < _arrayLength+ 1)
        {
            foundArrow = _array[location] == null ? false : true;
            location++;
        }
        if (!foundArrow)
            Instantiate(Arrow, SpawnPoint.position, Quaternion.identity);
        else
            Pop(location-1);
    }
}

