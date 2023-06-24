using Attributes;
using UnityEngine;

public class AttributeDemo : MonoBehaviour
{
    [ExposedSO, SerializeField] private DemoSO demoSo;

   
    [Button] 
    public void TestMethod()
    {
        Debug.LogError("Test Method");
    }
    
    [Button]
    private void TestMethod2()
    {
        Debug.LogError("Test Method 2");
    }
}