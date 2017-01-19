using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

[XmlRoot("RegisterCollection")]
public class RegisterCollection {

    [XmlArray("Registers")]
    [XmlArrayItem("Register")]
    public List<Register> registers = new List<Register>();

    public static RegisterCollection Load(string path) {
        TextAsset _xml = Resources.Load<TextAsset>(path);
        XmlSerializer serializer = new XmlSerializer(typeof(RegisterCollection));
        StringReader reader = new StringReader(_xml.text);
        RegisterCollection registers = serializer.Deserialize(reader) as RegisterCollection;

        reader.Close();
        
        return registers;
        
    }

    //public void Save(string path) {
    //    var serializer = new XmlSerializer(typeof(RegisterCollection));
    //    using (var stream = new FileStream(path, FileMode.Create)) {
    //        serializer.Serialize(stream, this);
    //    }
    //}
}