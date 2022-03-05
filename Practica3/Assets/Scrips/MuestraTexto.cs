using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuestraTexto : MonoBehaviour
{
    public GameObject dialogo;
    // Start is called before the first frame update
    void Start()
    {
        dialogo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if(!other.CompareTag("Player"))return;
        dialogo.SetActive(true);
    }

    private void OnTriggerExit(Collider other) {
        if(!other.CompareTag("Player"))return;
        dialogo.SetActive(false);
    }
}
