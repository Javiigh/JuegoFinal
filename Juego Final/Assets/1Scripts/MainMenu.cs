using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject JugarB;
    public GameObject OpcionesB;
    public GameObject salirB;

    public GameObject Menu;
    public GameObject JugarMenu;
    public GameObject Found;
    public GameObject Person;
    public GameObject Nemo;
    public GameObject Title;

    float timer;

    void Start()
    {
        StartCoroutine(LoadMenu());
        StartCoroutine(LoadTitle());
    }

    void Update()
    {

    }

    IEnumerator LoadTitle()
    {
        yield return new WaitForSeconds(0.7f);
        Title.SetActive(true);
        Nemo.SetActive(false);
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(1.3f);
        Menu.SetActive(true);
        Title.SetActive(true);
        Nemo.SetActive(false);
    }

    public void ActiveButtonJugar()
    {
        JugarB.SetActive(true);
        OpcionesB.SetActive(false);
        salirB.SetActive(false);

        LoadNextLevel();
    }

    public void LoadNextLevel()
    {
        StartCoroutine(Scene(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator Scene(int LevelIndex)
    {
        yield return new WaitForSeconds(1);

        SceneManager.LoadScene(LevelIndex);
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
