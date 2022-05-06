using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
    public float speed = 2f;
    public float timer;
    
    public GameObject EmptyCM1;

    void Update()
    {
        timer = timer + Time.deltaTime;
        //Debug.Log(timer);
        
        if(timer < 5)
        {
            Derecha();
        }
        else if(timer < 8)
        {
            Abajo();
        }
        else if(timer < 11)
        {
            Izquierda();
        }
        else if (timer < 13)
        {
            Abajo();
        }
        else if (timer < 16)
        {
            Derecha();
        }
        else if (timer < 18)
        {
            Abajo();
        }
        else if (timer < 23)
        {
            Izquierda();
        }
    }

    void Abajo()
    {
        transform.Translate(0, 0, Time.deltaTime * 20);
    }

    void Derecha()
    {
        EmptyCM1.transform.Translate(Time.deltaTime * 20, 0, 0);
    }

    void Izquierda()
    {
        EmptyCM1.transform.Translate(Time.deltaTime * -20, 0, 0);
    }
}
