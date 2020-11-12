using System.Collections;
using System.Collections.Generic;
using BuddyDomain;
using UnityEngine;

public class Hello : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Class1.Test);
    }

    public static string Sample() => "Sample";
}
