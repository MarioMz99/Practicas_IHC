using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema_P1 : MonoBehaviour
{
    // Start is called before the first frame update

   void Start(){
       int[] nums = {8,1,2,2,3};
       nums = NumbersLessThan(nums);
       foreach (int n in nums)
       {
           Debug.Log(n);
       }
       
   }

   void update(){

   }

   private static int[] NumbersLessThan(int[] numbers) {
            int[] result = new int[numbers.Length];
            int cont;
            for (int i = 0; i < numbers.Length; i++)
            {
                cont = 0;
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j]) {
                        cont++;
                    }
                }
                result[i] = cont;
            }

            return result;
        }
}
