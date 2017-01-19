using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    public const string path = "Data";

    void Start() {
        RegisterCollection data = RegisterCollection.Load(path);
        foreach(Register register in data.registers) {
            Debug.Log("Register: " + register.name + " " + register.value.ToString());
        }
    }
}