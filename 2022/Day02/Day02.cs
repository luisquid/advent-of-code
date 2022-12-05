using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day02 : MonoBehaviour
{
    [SerializeField] private TextAsset puzzleInput;
    [SerializeField] private string [] data;

    // Start is called before the first frame update
    void Start()
    {
        data = puzzleInput.text.Split('\n');
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int sum = 0;

            //for(int i = 0; i < data.Length; i++)
            //{
            //    switch(data[i][2])
            //    {
            //        case 'X':
            //            sum += 1;
            //            break;
            //        case 'Y':
            //            sum += 2;
            //            break;
            //        case 'Z':
            //            sum += 3;
            //            break;
            //    }

            //    sum += EvaluateMatch(data[i]);
            //}

            //print(sum);

            for (int i = 0; i < data.Length; i++)
            {
                switch (data[i][2])
                {
                    case 'Y':
                        sum += 3;
                        break;
                    case 'Z':
                        sum += 6;
                        break;
                }

                sum += AddResult(data[i]);
            }

            print(sum);
        }
    }

    public int AddResult(string _result)
    {
        int value = 0;

        switch(_result[0])
        {
            case 'A':
                if (_result[2] == 'X')
                    value += 3;
                else if (_result[2] == 'Y')
                    value += 1;
                else
                    value += 2;
                break;
            case 'B':
                if (_result[2] == 'X')
                    value += 1;
                else if (_result[2] == 'Y')
                    value += 2;
                else
                    value += 3;
                break;
            case 'C':
                if (_result[2] == 'X')
                    value += 2;
                else if (_result[2] == 'Y')
                    value += 3;
                else
                    value += 1;
                break;
        }

        return value;
    }

    public int EvaluateMatch(string _matchData)
    {
        int points = 0;
        
        if(_matchData[0] == 'A' && _matchData[2] == 'X' ||
           _matchData[0] == 'B' && _matchData[2] == 'Y' ||
           _matchData[0] == 'C' && _matchData[2] == 'Z')
        {
            points = 3;
        }
        else if(_matchData[0] == 'A' && _matchData[2] == 'Y' ||
                _matchData[0] == 'B' && _matchData[2] == 'Z' ||
                _matchData[0] == 'C' && _matchData[2] == 'X')
        {
            points = 6;
        }
        return points;
    }
}
