using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class MainMenu : MonoBehaviour
{
    public GameObject JugarB;
    public GameObject OpcionesB;
    public GameObject salirB;

    public GameObject Menu;
    public GameObject JugarMenu;
    public GameObject Found;
    public GameObject Person;

    float timer;
    public float delay;

    void Start()
    {
        StartCoroutine(LoadMenu());
    }

    void Update()
    {
       
    }
    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(1.3f);
        Menu.SetActive(true);
    }

    public void ActiveButtonJugar()
    {
        JugarB.SetActive(true);
        OpcionesB.SetActive(false);
        salirB.SetActive(false);
    }

    public void ActiveButtonOpciones()
    {
        JugarB.SetActive(false);
        OpcionesB.SetActive(true);
        salirB.SetActive(false);
    }

    public void ActiveButtonSalir()
    {
        JugarB.SetActive(false);
        OpcionesB.SetActive(false);
        salirB.SetActive(true);
    }

    public void ClickJugarB()
    {
        Menu.SetActive(false);
        //LoadLevel();
        StartCoroutine(LoadFound());
        
        //Found.SetActive(true);
    }

    IEnumerator LoadFound()
    {
        yield return new WaitForSeconds(1);
        JugarMenu.SetActive(true);
        StartCoroutine(LoadFound2());
    }

    IEnumerator LoadFound2()
    {
        yield return new WaitForSeconds(0.5f);
        Found.SetActive(true);
        StartCoroutine(LoadPerson());
    }

    IEnumerator LoadPerson()
    {
        yield return new WaitForSeconds(0.3f);
        Person.SetActive(true);
    }
}
