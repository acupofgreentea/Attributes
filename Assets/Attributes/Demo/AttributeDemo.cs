using Attributes;
using Attributes.Core;
using UnityEngine;

public class AttributeDemo : MonoBehaviour
{
    [ExposedSO, SerializeField] private DemoSO demoSo;

    [SerializeField] private bool hideBool;
    
    [SerializeField, HideIf("hideBool")] public int hideIfInt;
    
    [SerializeField, ShowIf("hideBool")] public int showIfInt;
   
    [Button] 
    public void TestMethod()
    {
        Debug.LogError("Test Method");
    }
}