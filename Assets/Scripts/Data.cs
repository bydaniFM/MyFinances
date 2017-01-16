using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("Data")]
public class Data {

    [XmlAttribute("balance")]
    public int balance;

    public static Data Load(string path) {
        var serializer = new XmlSerializer(typeof(DataLoader));
        using (var stream = new FileStream(path, FileMode.Open)) {
            return serializer.Deserialize(stream) as Data;
        }
    }

    public void Save(string path) {
        var serializer = new XmlSerializer(typeof(Data));
        using (var stream = new FileStream(path, FileMode.Create)) {
            serializer.Serialize(stream, this);
        }
    }
}
