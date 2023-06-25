using System;
using System.Reflection;

namespace Attributes.Editor
{
    using UnityEngine;
    using UnityEditor;

    [CustomEditor(typeof(MonoBehaviour), true)]
    public class ButtonAttributeEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            DrawButtonAttributes(target);
        }

        private void DrawButtonAttributes(Object target)
        {
            Type targetClass = target.GetType();
            MethodInfo[] methods = targetClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public);
            
            foreach (var method in methods)
            {
                object[] attributes = method.GetCustomAttributes(typeof(ButtonAttribute), true);
                if (attributes.Length <= 0)
                    continue;
                
                if (GUILayout.Button(method.Name))
                {
                    method.Invoke(target, null);
                }
            }
        }
    }
}