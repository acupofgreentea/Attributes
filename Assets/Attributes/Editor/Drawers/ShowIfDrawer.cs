using UnityEngine;
using Attributes.Core;
using UnityEditor;

namespace Attributes.Drawers
{
    [CustomPropertyDrawer(typeof(ShowIfAttribute))]
    public class ShowIfDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            ShowIfAttribute showIf = attribute as ShowIfAttribute;
            SerializedProperty boolProperty = property.serializedObject.FindProperty(showIf.BoolFieldName);

            if (boolProperty != null && boolProperty.propertyType == SerializedPropertyType.Boolean)
            {
                bool show = boolProperty.boolValue;
                if (!show)
                    return;
            }

            EditorGUI.PropertyField(position, property, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            ShowIfAttribute showIf = attribute as ShowIfAttribute;
            SerializedProperty boolProperty = property.serializedObject.FindProperty(showIf.BoolFieldName);

            if (boolProperty != null && boolProperty.propertyType == SerializedPropertyType.Boolean)
            {
                bool show = boolProperty.boolValue;
                if (!show)
                    return 0f;
            }

            return EditorGUI.GetPropertyHeight(property, label);
        }
    }
}