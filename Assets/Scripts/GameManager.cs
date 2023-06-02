using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject cat;
    public GameObject dog;
    public Text timeCountText;
    public int timeCountValue;
    public static bool gameStatus;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Game(timeCountValue));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Game(int count)
    {
        for (int k = 0; k >= 0; k++)
        {

            for (int i = count; i >= 0; i--)
            {
                timeCountText.text = "Chose Your Move " + "Time: " + i;
                yield return new WaitForSeconds(1f);
            }
            ResetTick();
            yield return new WaitForSeconds(3f);


        }

    }

    private void ResetTick()
    {
        cat.GetComponent<Cat>().catTick.SetActive(false);
        dog.GetComponent<Dog>().dogTick.SetActive(false);
    }
}
