using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : Animal
{
    private Rigidbody rbCat;
    public GameObject catTick;
    public string nameCat;
    private int moveInfo = 0;
    public Vector3 power;
    [SerializeField] private Text healthTextCat;



    // Start is called before the first frame update
    void Start()
    {
        rbCat = GetComponent<Rigidbody>();
        SetAnimalName(nameCat);
        TypeHealth();
    }
    // Update is called once per frame
    void Update()
    {
        GetActInput();
    }


    public override void Defence()
    {
        
    }

    public override void Attack(int damage)
    {
        rbCat.velocity = power;
    }

    private void TypeHealth()
    {
        healthTextCat.text = nameAnimal + " " +healthAnimal; 
    }

    private void GetActInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveInfo = 1;
            catTick.SetActive(true);
            Attack(1);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveInfo = -1;
            catTick.SetActive(true);
        }
    }

}
