using TMPro;
using UnityEngine;

public class SampleScene : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI lable;
    void Start()
    {
        lable.text = Application.version.ToString();
    }
}