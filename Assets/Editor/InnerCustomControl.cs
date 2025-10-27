using UnityEngine;
using UnityEngine.UIElements;

[UxmlElement]
public partial class InnerCustomControl : VisualElement
{
    public InnerCustomControl()
    {
        Debug.Log("InnerCustomControl Constructor");
    }
}
