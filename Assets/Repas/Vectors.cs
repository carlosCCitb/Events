using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vectors : MonoBehaviour
{
    public Vector2 vector2D;
    public Vector3 vector3D;

    private void Start()
    {
        vector2D = new Vector2(3f, 3f);
        vector3D = new Vector3(3f, 3f, 3f);
        Debug.Log(vector3D.x);
        Debug.Log(vector3D.magnitude);
        Debug.Log(vector3D.normalized);
        Debug.Log(Vector3.Cross(vector3D, vector3D));
        Debug.Log(Vector3.Dot(vector3D, vector3D));
        float alpha = Mathf.Atan2(vector2D.y, vector2D.x);
        Debug.Log(alpha);
    }
}
