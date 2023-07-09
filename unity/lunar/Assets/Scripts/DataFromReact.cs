using UnityEngine;
using TMPro;

public class DataFromReact : MonoBehaviour
{
    public new string name;
    public string age;
    private DataFromReact instance;
    public TMP_Text text;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        // Change the text on the text component.
        text.text = "start.";
    }

    public class JsonObject
    {
        public string name;
        public string age;
    }
    // As you can see here is the name of the function that we get the data.
    // it should have the same name in RN function postMessage.
    public void GetDatas(string json)
    {
        JsonObject obj = JsonUtility.FromJson<JsonObject>(json);
        name = obj.name;
        age = obj.age;

        text.text = obj.name;
    }
}