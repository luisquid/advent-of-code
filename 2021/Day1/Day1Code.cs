using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day1Code : MonoBehaviour
{
    public TextAsset day1Input;
    string[] inputArray;

    void Start()
    {
        inputArray = day1Input.text.Split('\n');
        Day1Part1();
        Day1Part2();
    }

    public void Day1Part1()
    {
        int depthSum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            if (i != 0)
            {
                if (int.Parse(inputArray[i]) > int.Parse(inputArray[i - 1]))
                {
                    depthSum++;
                }
            }
        }

        Debug.Log("DAY 1 PART 1 ANSWER: " + depthSum);
    }

    public void Day1Part2()
    {
        int depthSum = 0;

        for (int i = 0; i < inputArray.Length; i++)
        {
            int tempSumCurrent = 0;
            int tempSumNext = 0;

            if (i + 3 < inputArray.Length)
            {
                for (int j = 0; j < 3; j++)
                {
                    print("ARRAY i: " + i + "\nARRAY j: " + j + "\nCURRENT NUMBER: " + inputArray[i + j]);
                    tempSumCurrent += int.Parse(inputArray[i + j]);
                    tempSumNext += int.Parse(inputArray[i + j + 1]);
                }

                print("Temp Current: " + tempSumCurrent + "\nTemp Next: " + tempSumNext);
                if (tempSumCurrent < tempSumNext)
                {
                    print("CONDITION TRUE WHEN\nTemp Current: " + tempSumCurrent + "\nTemp Next: " + tempSumNext);

                    depthSum++;
                }
            } 
        }

        Debug.Log("DAY 1 PART 2 ANSWER: " + depthSum);
    }
}
