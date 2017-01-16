using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataLoader : MonoBehaviour {

    public string path;
    string settingsPath;
    private Data data;

    public static DataLoader instance;
    void Awake() {
        if (instance == null) {
            instance = this;
        } else {
            Destroy(gameObject);
            Debug.LogError("An instance of RulesLoader already exists");
        }
        //settingsPath = Application.dataPath + "/Settings/";
        //#if UNITY_STANDALONE_WIN
			     //   path = path.Replace('/', '\\');
        //#endif

        //#if !UNITY_EDITOR
		      //  FirstRun();

		      //  rules = Rules.Load(File.ReadAllText(settingsPath+"_rules.xml"));
        //#else
        //        rules = Rules.Load(Resources.Load<TextAsset>("Rules").text);
        //#endif
    }
    void Start() {
        Debug.Log(data.balance);
    }
}