using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

public class Animal : MonoBehaviour
{
    public int healthAnimal;
    private string nameanimal;

    public string nameAnimal
    {
        get { return nameanimal; }
        set
        {
            if (value.Length <= 20)
            {
                nameanimal = value;
            }
            else
            {
                Debug.LogError("Animal name cant be longer than 20 char"); 
            }
        }
    }

    public virtual void Defence()
    {

    }
    public virtual void Attack(int damage)
    {

    }


    public virtual void SetAnimalName(string name)
    {
        this.nameAnimal = name;
    }

    public void TypeName()
    {
        Debug.Log(this.nameAnimal);
    }

}
