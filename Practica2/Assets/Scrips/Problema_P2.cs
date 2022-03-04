using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class Problema_P2 : MonoBehaviour
{
    public int[] input;
    public int num;

    // Start is called before the first frame update
    void Start() 
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RevisarSuma(input,num);  
    }

    private void RevisarSuma(int [] arr, int num){
        for (int i = 0; i < arr.Length; i++){
            if(arr[i]<num){
                for(int j = 0; j<arr.Length; j++){
                    if(arr[i] + arr[j] == num){
                        Debug.Log(i + " " + j); 
                    }
                }
            }            
        }
    }

}
