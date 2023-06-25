using UnityEngine;

namespace Attributes.Core
{
    [System.AttributeUsage(System.AttributeTargets.Field, Inherited = true, AllowMultiple = true)]
    public class ShowIfAttribute : PropertyAttribute
    {
        public string BoolFieldName { get; private set; }

        public ShowIfAttribute(string boolFieldName)
        {
            this.BoolFieldName = boolFieldName;
        }
    }
}