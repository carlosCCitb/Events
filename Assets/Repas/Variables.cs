using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum States
{
    Idle,
    Run,
    Attack,
    Death
}

public class Variables : MonoBehaviour
{
    [SerializeField] private int Health;
    public string Name;
    protected float Velocity;
    public Vector3 Position;
    public Variables variables;
    public List<string> ListA3D;
    public string[] ArrayA3D = new string[3];
    public States state;
    // Start is called before the first frame update

    void Start()
    {
        Health = 3;
        Name = "asdas";
        Position = new Vector3(3f, 3f, 3f);
        variables = this;
        ListA3D.Add(Name);
        ListA3D.Add("Anselmo");
        ArrayA3D[1] = "Anselmo";
        state = States.Attack;
        ListA3D[2] = "ASDsad";
        ListA3D.RemoveAt(2);
        ArrayA3D[2] = "";
        if(state == States.Idle)
        {
            Idle();
        }
        else if(state == States.Attack)
        {
            Attack();
        }
        else if (state == States.Death)
        {
            Death();
        }
        else
        {
            Run();
        }
    }
    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case (States.Idle):
                Idle();
                break;
            case (States.Run):
                Run();
                break;
        }
        int counter = 0;
        while(counter <2)
        {
            ListA3D[counter] = "" + counter + 1;
            counter = counter + 1; // counter++;
        }
        
        for (int i=0; i<3; i++)
        {
            ArrayA3D[i] = "" + (i + 1);
        }
        foreach (string value in ArrayA3D)
            Debug.Log(value);
        for (int i = 0; i < 3; i++)
        {
            Debug.Log(ArrayA3D[i]);
        }

    }
    public void Idle()
    {
        Debug.Log("Idle");
    }
    public void Run()
    {
        Debug.Log("Run");

    }
    public void Attack()
    {
        Debug.Log("Attack");

    }
    public void Death()
    {
        Debug.Log("Death");


    }
}

