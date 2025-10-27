using UnityEngine;
using UnityEngine.UIElements;

[UxmlElement]
public partial class CustomControl : VisualElement
{
    public CustomControl()
    {
        Debug.Log("CustomControl Constructor");
    }
}
