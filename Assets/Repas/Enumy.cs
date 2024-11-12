using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum State
{
    Attack,
    Idle,
    Run,
    Die
}
public class Enumy : MonoBehaviour
{
    public State state;
}
