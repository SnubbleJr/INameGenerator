using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour {

    private FileReader fileReader;
    private InputField inputField;

	// Use this for initialization
	void Start () {
        fileReader = FindObjectOfType<FileReader>();
        inputField = GetComponentInChildren<InputField>();
	}
	
    public void OnGenerateNamePressed()
    {
        string name = fileReader.GetName();
        inputField.text = name;
    }

    public void OnRemoveNamePressed()
    {
        string name = inputField.text;
        fileReader.RemoveName(name);
    }
}
