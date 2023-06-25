using UnityEngine;

namespace Attributes.Editor
{
    using UnityEditor;

    [CanEditMultipleObjects]
    [CustomEditor(typeof(MonoBehaviour), true)]
    public class MonoBehaviourEditor : Editor
    {
        
    }
}