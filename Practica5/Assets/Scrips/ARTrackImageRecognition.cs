using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class ARTrackImageRecognition : MonoBehaviour
{
    private ARTrackedImageManager _arTrackedImageManager;
    public GameObject[] prefabs;
    public Dictionary<string,GameObject> prefabDictionary = new Dictionary<string,GameObject>();

    // Start is called before the first frame update
    void Awake()
    {
        _arTrackedImageManager = GetComponent<ARTrackedImageManager>();
        foreach (GameObject prefab in prefabs)
        {
            GameObject instantiatedPrefab = Instantiate(prefab, Vector3.zero,Quaternion.identity);
            instantiatedPrefab.name = prefab.name;
            prefabDictionary.Add(prefab.name,instantiatedPrefab);
        }
    }

    private void OnEnable(){
        _arTrackedImageManager.trackedImagesChanged += OnImageChange;
    }

    private void OnDisable(){
        _arTrackedImageManager.trackedImagesChanged -= OnImageChange;
    }

    public void OnImageChange(ARTrackedImagesChangedEventArgs eventsArgs){
        //Swap de los modelos
        foreach(ARTrackedImage trackedImage in eventsArgs.added){
            setPrefab(trackedImage);

        }
        foreach(ARTrackedImage trackedImage in eventsArgs.updated){
            setPrefab(trackedImage);
        }
        foreach(ARTrackedImage trackedImage in eventsArgs.removed){
            prefabDictionary[trackedImage.name].SetActive(false);
        }
    }

    private void setPrefab(ARTrackedImage trackedImage){
        string name = trackedImage.referenceImage.name;
        Vector3 position = trackedImage.transform.position;
        GameObject prefab = prefabDictionary[name];

        if (trackedImage.referenceImage.name == "lava")
        {
            float var;
            for (int i = 0; i < 200; i++)
            {
                var = (float) i*0.01f;
                prefab.transform.position = new Vector3(var+0.15f,var+0.15f,var+0.15f);
            }
        }

        prefab.transform.position = position;
        prefab.SetActive(true);
    }
}
