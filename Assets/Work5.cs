using System;
using System.Security.AccessControl;
using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Work5 : MonoBehaviour
{
    private int[] array = new int[] {81, 22, 13, 34, 10, 34, 15, 26, 71, 68};

    public void Ex1()
    {
        int result = 0; 
        for (var i = 7; i < 22; i++)
        {
            if (i % 2 == 0) result += i;
        }

        Debug.Log(result.ToString());
    }

    public void Ex2()
    {
        int[] arr = new int[] {81, 22, 13, 54, 10, 34, 15, 26, 71, 68};
        int result = 0; 

        for (var i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) result += arr[i];
        }

        Debug.Log(result);
    }

    public void Ex3()
    {
        Debug.Log(FindIndex(34));
        Debug.Log(FindIndex(55));
    }

    private int FindIndex(int ind) 
    {
        int res = -1;

        for (var i = 0; i < array.Length; i++)
        {
            if (array[i] == ind) 
            {
                res = i;
                break;
            }
        }

        return(res);
    }

    public void Ex4()
    {
        foreach (int i in array)
        {
            Debug.Log(i);
        }

        int[] arr = array;
 
        for (var i = 0; i < arr.Length; i++)
        {
            for (var j = 0 + i; j < arr.Length; j++)
            {
                if (arr[i] > arr[j])
                {
                    arr[i] = arr[i] + arr[j];
                    arr[j] = arr[i] - arr[j];
                    arr[i] = arr[i] - arr[j];
                }
            }
        }

        Debug.Log("------------------------------");
        foreach (int i in arr)
        {
            Debug.Log(i);
        }
    }
}
