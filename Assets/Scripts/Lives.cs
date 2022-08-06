using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lives : MonoBehaviour
{

    public GameObject strike1, strike2, strike3;
    public Timer time;
    public static int strikes;

    // Start is called before the first frame update
    void Start()
    {
        strikes = 3;
        strike1.gameObject.SetActive(true);
        strike2.gameObject.SetActive(true);
        strike3.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (strikes > 3)
            strikes = 3;
        switch (strikes)
        {
            case 3:
                strike1.gameObject.SetActive(true);
                strike2.gameObject.SetActive(true);
                strike3.gameObject.SetActive(true);
                break;

            case 2:
                strike1.gameObject.SetActive(false);
                strike2.gameObject.SetActive(true);
                strike3.gameObject.SetActive(true);
                break;

            case 1:
                strike1.gameObject.SetActive(false);
                strike2.gameObject.SetActive(false);
                strike3.gameObject.SetActive(true);
                break;

            case 0:
                strike1.gameObject.SetActive(false);
                strike2.gameObject.SetActive(false);
                strike3.gameObject.SetActive(false);
                time.StopWatchStop();
                break;
        }
    }
}
