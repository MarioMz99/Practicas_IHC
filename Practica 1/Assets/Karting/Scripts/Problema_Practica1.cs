using System;
using UnityEngine;

public class Problema_Practica1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] numbers = {0,1,2,4,5};
        print(numbers);
    }

    private static int[] numbersLessThan(int[] numbers)
    {
        int[] result = new int[numbers.Length];

        return result;
    }

    public static void print(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("[{0}]", numbers[i]);
        }
    }
}
