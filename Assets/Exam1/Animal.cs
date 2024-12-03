using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    protected string animalName;
    public string AnimalName
    {
        get
        {

        }
        set
        {
            name = value;
        }
    }

    public void Init(string name, string sound)
    {
        name = animalName;
    }

    public abstract float CalculateFoodRequirement();

    public virtual void MakeSound()
    {
        Debug.Log("The animal makes a sound.");
        Debug.Log($"{name}: ");
    }

}
