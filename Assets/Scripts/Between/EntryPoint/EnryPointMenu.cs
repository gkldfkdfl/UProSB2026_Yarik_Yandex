using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnryPointMenu : MonoBehaviour
{
    [SerializeField] private SetLanguageLocalization sll;
   
    void Start()
    {
        CSVReader.LoadCSV();
        sll.Init();

    }

   
}
