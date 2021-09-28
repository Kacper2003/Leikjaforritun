using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Daudi : MonoBehaviour
{
    public Transform leikmadur;
    
    void Update()
    {
        //Debug.Log("halló");
        if (transform.position.y<=0)
        {
           SceneManager.LoadScene("Menu");//byrja á byrjun ef leikmaður fellur fram af brún eða í vatnið
        }
    }
}
