using Attributes.Core;
using UnityEditor;
using UnityEngine;

namespace Attributes.Drawers
{
    [CustomPropertyDrawer(typeof(HideIfAttribute))]
    public class HideIfDrawer : PropertyDrawer
    {
        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            HideIfAttribute hideIf = attribute as HideIfAttribute;
            SerializedProperty boolProperty = property.serializedObject.FindProperty(hideIf.BoolFieldName);

            if (boolProperty != null && boolProperty.propertyType == SerializedPropertyType.Boolean)
            {
                bool hide = boolProperty.boolValue;
                if (hide)
                    return;
            }

            EditorGUI.PropertyField(position, property, label, true);
        }

        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            HideIfAttribute hideIf = attribute as HideIfAttribute;
            SerializedProperty boolProperty = property.serializedObject.FindProperty(hideIf.BoolFieldName);

            if (boolProperty != null && boolProperty.propertyType == SerializedPropertyType.Boolean)
            {
                bool hide = boolProperty.boolValue;
                if (hide)
                    return 0f;
            }

            return EditorGUI.GetPropertyHeight(property, label);
        }
    }
}