using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPicker : MonoBehaviour
{
    private float _range = 100f;
    [SerializeField] private Stack<GameObject> keysInventory = new Stack<GameObject>();
    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(ray.origin, ray.direction);
            //Debug.DrawRay(ray.origin, ray.direction);
            if (hit.collider!= null)
            {
                /*if(hit.collider.TryGetComponent<ICollectable>(out ICollectable icoll))
                {
                    icoll.Collected();
                    keysInventory.Push(hit.collider.gameObject);
                }
                else */
                if (hit.collider.TryGetComponent<IDisposer>(out IDisposer idisp))
                {
                    try
                    {
                        var obj = keysInventory.Pop();
                        idisp.Dispose(obj);
                        obj.transform.position = hit.collider.gameObject.transform.position;
                    }
                    catch
                    {
                        Debug.Log("No Keys Left");
                    }
                }
            }
        }
    }
}
