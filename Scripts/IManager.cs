using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class IManager : MonoBehaviour

//1 
public interface IManager
{
    //2 
    string State { get; set; }
    //3
    void Initialize();
}

