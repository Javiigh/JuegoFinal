using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PersonLost : MonoBehaviour
{
    public GameObject[] Persons;
    int Person;

    public GameObject personLost;

    public GameObject JugarMenu;
    public GameObject Found;
    public GameObject FoundTitle;

    void Start()
    {
        StartCoroutine(LoadFound());
    }

    void Update()
    {
        
    }

    IEnumerator LoadFound()
    {
        yield return new WaitForSeconds(1);
        //JugarMenu.SetActive(true);
        StartCoroutine(LoadFound2());
    }

    IEnumerator LoadFound2()
    {
        yield return new WaitForSeconds(0.5f);
        //Found.SetActive(true);
        //StartCoroutine(LoadPerson());
        SelectPerson();
    }

    /*public IEnumerator LoadPerson()
    {
        yield return new WaitForSeconds(0.3f);
        //FoundTitle.SetActive(true);
        //Instantiate(personLost, new Vector3(0, -4f, 0), Quaternion.identity);
        SelectPerson();
       
        //Instantiate(Persons[Person], new Vector3(0, -4f, 0), Quaternion.identity);
    }*/

    public void SelectPerson()
    {
        Person = Random.Range(1, 3);
        Debug.Log("Persona" + Person);

        Instantiate(Persons[Person], new Vector3(-23.64f, 14.355f, -109.97f), Quaternion.identity);
        //Instantiate(Persons[Person], new Vector3(2.205227f, 1.192093e-06f, -0.4245048f), Quaternion.identity);

        /*for (int Person = 0; Person < Persons.Length; Person++)
        {
            Instantiate(Persons[Person], new Vector3(0, -4f, 0), Quaternion.identity);
        }*/
    }

    void Awake()
    {

    }
}
