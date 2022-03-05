using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema_P3 : MonoBehaviour
{   
    public int[] nums = new int [9];
    // Start is called before the first frame update
    void Start()
    {        
        int maxValue = nums[0];
        
        for(int i=1; i<9; i++) {
            if(nums[i-1] >= 0) nums[i] += nums[i-1];
            
            if(maxValue < nums[i]) maxValue = nums[i];
        }
        Debug.Log( maxValue);
    }
    

     
}
