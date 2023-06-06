using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cat : Animal
{
    private Rigidbody rbCat;
    public GameObject catTick;
    public GameObject catShield;
    public string nameCat;
    public int moveInfo = 0;
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
        catShield.SetActive(true);
    }

    public override void Attack(int damage)
    {
        rbCat.velocity = power;
    }

    public void TypeHealth()
    {
        healthTextCat.text = nameAnimal + " " +healthAnimal; 
    }

    private void GetActInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            moveInfo = 1;
            catTick.SetActive(true);
            
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            moveInfo = -1;
            catTick.SetActive(true);
        }
    }

}
