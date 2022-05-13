using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoDestroy : MonoBehaviour
{
    public static NoDestroy instance;


    void Awake()
    {
        if (MainMenu.instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
