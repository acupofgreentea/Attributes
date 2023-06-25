using UnityEngine;

namespace Attributes.Core
{
    [System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class HideIfAttribute : PropertyAttribute
    {
        public string BoolFieldName { get; private set; }
        public HideIfAttribute(string boolFieldName)
        {
            this.BoolFieldName = boolFieldName;
        }
    }
}