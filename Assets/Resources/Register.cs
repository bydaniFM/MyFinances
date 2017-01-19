using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Register {

    [XmlAttribute("name")]
    public string name;

    [XmlElement("value")]
    public float value;

    //public Register() {
    //    name = "";
    //    value = 0;
    //}
    //public Register(string name, float value) {
    //    this.name = name;
    //    this.value = value;
    //}

    //public string getName() {
    //    return name;
    //}

    //public float getValue() {
    //    return value;
    //}

    //public float getBalance(Register[] registers) {
    //    float balance = 0;
    //    for (int i = 0; i < registers.Length; i++) {
    //        balance += registers[i].getValue();
    //    }
    //    return balance;
    //}
}
