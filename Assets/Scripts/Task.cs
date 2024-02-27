using System.Collections.Generic;
using UnityEngine;

public class Task : MonoBehaviour
{
    private List<int> _inList1 = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15};
    private List<int> _inList2 = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 60, 105, 420};
    private List<string> _outList = new List<string>();

    private void Start()
    {
        _outList.AddRange(DivisionBy(_inList2));
        
        for (int i = 0; i < _outList.Count; i++)
        {
            Debug.Log("Input: " + _inList2[i] + " Output: " + _outList[i]);
        }
    }

    private List<string> DivisionBy(List<int> numbers)
    {
        List<string> outList = new List<string>();
       
        for (int i = 0; i < numbers.Count; i++)
        {
            string temp = null;

            temp = CheckDivisionBy3(numbers[i]);
            temp = CheckDivisionBy4(numbers[i], temp);
            temp = CheckDivisionBy5(numbers[i], temp);
            temp = CheckDivisionBy7(numbers[i], temp);

            if(temp != null)
            {
                outList.Add(temp);
                continue;
            }
            
            outList.Add(numbers[i].ToString());
        }
        
        return outList;
    }

    private bool IsExactDivision(int numberThatIsDivided, int numberToDiviteBy)
    {
        return numberThatIsDivided % numberToDiviteBy == 0;
    }

    private string CheckDivisionBy3(int number)
    {
        if (IsExactDivision(number, 3))
            return "dog";
        else 
            return null;
    }

    private string CheckDivisionBy4(int number, string str)
    {
        if(IsExactDivision(number, 4))
        {
            if (str != null)
                str += "-";

            str += "muzz";
            return str;
        }
        else
            return str;
    }

    private string CheckDivisionBy5(int number, string str)
    {
        if (IsExactDivision(number, 5))
        {
            if (str != null)
                str += "-";

            str += "cat";

            if (IsExactDivision(number, 3))
            {
                str = null;
                str += "good-boy";

                if (IsExactDivision(number, 4))
                    str += "-muzz";
            }

            return str;
        }
        else
            return str;
    }

    private string CheckDivisionBy7(int number, string str)
    {
        if(IsExactDivision(number, 7))
        {
            if (str != null)
                str += "-";

            str += "guzz";
            return str;
        }
        else
            return str;
    }
}
