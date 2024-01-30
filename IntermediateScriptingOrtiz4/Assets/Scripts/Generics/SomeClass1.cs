using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass1 : MonoBehaviour
{
    // Start is called before the first frame update
    public T GenericMethod<T>(T param)
    {
        return param;
    }
}
