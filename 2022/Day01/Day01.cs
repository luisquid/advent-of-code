using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day01 : MonoBehaviour
{
    [SerializeField] private TextAsset puzzleInput;
    [SerializeField] private string[] data;
    [SerializeField] private int[] topThree;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            data = puzzleInput.text.Split('\n');

            int sum = 0;
            int biggestSum = 0;
            topThree = new int[3];

            for (int i = 0; i < topThree.Length; i++)
                topThree[i] = 0;

            for(int i = 0; i < data.Length; i++)
            {
                if(char.IsWhiteSpace(data[i].ToCharArray()[0]))
                {
                    for(int j = 0; j < topThree.Length; j++)
                    {
                        if(sum > topThree[j])
                        {
                            switch(j)
                            {
                                case 0:
                                    topThree[1] = topThree[0];
                                    topThree[2] = topThree[1];
                                    topThree[j] = sum;
                                    break;

                                case 1:
                                    topThree[2] = topThree[1];
                                    topThree[j] = sum;
                                    break;

                                case 2:
                                    topThree[j] = sum;
                                    break;
                            }
                            break;
                        }
                    }
                    
                    //if (sum > biggestSum)
                    //    biggestSum = sum;
                    sum = 0;

                    continue;
                }
                sum += int.Parse(data[i]);
            }

            //print(biggestSum);

            int tempSum = 0;
            for (int i = 0; i < topThree.Length; i++)
                tempSum += topThree[i];

            print(tempSum);
        }
    }
}
