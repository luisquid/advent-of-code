using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day04 : MonoBehaviour
{
    [SerializeField] private TextAsset puzzleInput;
    [SerializeField] private string[] data;

    void Start()
    {
        data = puzzleInput.text.Split('\n');
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
