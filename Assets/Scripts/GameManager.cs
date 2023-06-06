using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Cat cat;
    public Dog dog;
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
            DoDogAct(dog);
            DoCatAct(cat);
            GameTurn(dog, cat);
            cat.TypeHealth();
            dog.TypeHealth();
            yield return new WaitForSeconds(3f);
            cat.CloseDefenceTab(cat.catShield);
            dog.CloseDefenceTab(dog.dogShield);
            dog.moveInfo = 0;
            cat.moveInfo = 0;

        }

    }
    private void GameTurn(Dog dog,Cat cat)
    {
        int dogmoveinfo = dog.moveInfo;
        int catmoveinfo = cat.moveInfo;

        if (dogmoveinfo == 0 && catmoveinfo == 0)
        {
            return;
        }
        else if (dogmoveinfo == 1 && catmoveinfo == 0)
        {
            cat.healthAnimal -= 20;
        }
        else if (dogmoveinfo == -1 && catmoveinfo == 0)
        {
            return;
        }
        else if (dogmoveinfo == 1 && catmoveinfo == 1)
        {
            cat.healthAnimal -= 10;
            dog.healthAnimal -= 10;

        }
        else if (dogmoveinfo == -1 && catmoveinfo == 1)
        {
            dog.healthAnimal += 10;
        }
        else if (dogmoveinfo == 0 && catmoveinfo == 1)
        {
            dog.healthAnimal -= 20;
        }
        else if (dogmoveinfo == 1 && catmoveinfo == -1)
        {
            cat.healthAnimal += 10;
        }
        else if (dogmoveinfo == 0 && catmoveinfo == -1)
        {
            return;
        }
        else if (dogmoveinfo == -1 && catmoveinfo == -1)
        {
            return;
        }
        
    }
    private void DoDogAct(Dog dog)
    {
        if (dog.moveInfo == 0)
        {
            return;
        }
        else if (dog.moveInfo == 1)
        {
            dog.Attack(10);
        }
        else if (dog.moveInfo == -1)
        {
            dog.Defence();
        }
    }
    private void DoCatAct(Cat cat)
    {
        if (cat.moveInfo == 0)
        {
            return;
        }
        else if (cat.moveInfo == 1)
        {
            cat.Attack(10);

        }
        else if (cat.moveInfo == -1)
        {
            cat.Defence();
        }
    }
    private void ResetTick()
    {
        cat.catTick.SetActive(false);
        dog.dogTick.SetActive(false);
    }
}
