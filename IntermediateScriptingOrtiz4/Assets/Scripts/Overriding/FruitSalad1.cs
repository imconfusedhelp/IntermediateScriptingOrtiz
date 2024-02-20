using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Apple1 myApple = new Apple1();

        myApple.SayHello();
        myApple.Chop();

        Fruit1 myFruit = new Apple1();
        myFruit.SayHello();
        myFruit.Chop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
