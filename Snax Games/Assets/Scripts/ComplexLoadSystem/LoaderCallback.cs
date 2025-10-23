using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoaderCallback : MonoBehaviour
{
    private bool isFirstUpdate = true;
    private float timer = 0f;
    [SerializeField] private float minimumLoadingTime = 3f;

    private void Update() {
        if (isFirstUpdate)
        {
            timer += Time.deltaTime;
            if (timer >= minimumLoadingTime)
            {
                isFirstUpdate = false; //Prevents multiple calls
                 
                // Allow scene to finish loading after minimum time
                Loader.LoaderCallback();
            }
        }
    }
}
