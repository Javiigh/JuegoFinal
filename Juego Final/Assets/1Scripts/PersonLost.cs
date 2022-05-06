using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonLost : MonoBehaviour
{
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
        FoundTitle.SetActive(true);
        Instantiate(personLost, new Vector3(0, -4f, 0), Quaternion.identity);
    }

    void Awake()
    {

    }
}
