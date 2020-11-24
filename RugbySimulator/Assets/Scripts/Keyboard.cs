using UnityEngine;
using Microsoft.MixedReality.Toolkit.Experimental.UI;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{

    private MixedRealityKeyboard _MRKeyboard;


    void Start()
    {
        _MRKeyboard = gameObject.AddComponent<MixedRealityKeyboard>();
    }

    public void OnShowKeyboard(InputField inputField)
    {

        _MRKeyboard.ShowKeyboard();
        inputField.text = _MRKeyboard.Text;

    }
}