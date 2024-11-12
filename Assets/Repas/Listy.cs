using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listy : MonoBehaviour
{
    public List<Enumy> list;
    public Enumy[] array;

    private void Start()
    {
        array = new Enumy[3];
    }
}
