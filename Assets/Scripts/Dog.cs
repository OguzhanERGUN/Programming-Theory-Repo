using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dog : Animal
{
    private Rigidbody rbDog;
    public GameObject dogTick;
    public string nameDog;
    private int moveInfo = 0;
    public Vector3 power;
    [SerializeField] private Text healthTextDog;
    // Start is called before the first frame update
    void Start()
    {
        SetAnimalName(nameDog);
        TypeHealth();
        rbDog = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        GetActInput();
    }

    private void TypeHealth()
    {
        healthTextDog.text = nameAnimal + " " + healthAnimal;
    }

    public override void Defence()
    {

    }

    public override void Attack(int damage)
    {
        rbDog.velocity = power;

    }

    private void GetActInput()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            moveInfo = 1;
            dogTick.SetActive(true);
            Attack(1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            moveInfo = -1;
            dogTick.SetActive(true);
        }
    }
}
