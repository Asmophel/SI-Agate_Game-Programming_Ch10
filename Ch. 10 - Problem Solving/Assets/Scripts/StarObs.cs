using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StarObs : MonoBehaviour
{
    [SerializeField] private GameObject Star;
    [SerializeField] private float timeOnScreen;
    private float timer;
    public UnityAction<StarObs> OnSquareDestroyed = delegate { };
    // Start is called before the first frame update

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeOnScreen)
        {
            //Destroy(Star, timeOnScreen);
            OnSquareDestroyed(this);
            Star.SetActive(false);
            timer = 0;
        }
    }
}
