using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class SimpleCustomEditor : EditorWindow
{
    [SerializeField]
    private VisualTreeAsset m_VisualTreeAsset = default;

    [MenuItem("Window/UI Toolkit/SimpleCustomEditor")]
    public static void ShowExample()
    {
        SimpleCustomEditor wnd = GetWindow<SimpleCustomEditor>();
        wnd.titleContent = new GUIContent("SimpleCustomEditor");
    }

    public void CreateGUI()
    {
        // Each editor window contains a root VisualElement object
        VisualElement root = rootVisualElement;

        // VisualElements objects can contain other VisualElement following a tree hierarchy.
        // VisualElement label = new Label("Hello World! From C#");
        // root.Add(label);

        // // Instantiate UXML
        // VisualElement labelFromUXML = m_VisualTreeAsset.Instantiate();
        // root.Add(labelFromUXML);

        // Import UXML created manually.
        // var visualTree = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/SimpleCustomEditor_UXML.uxml");
        // VisualElement labelFromUXML = visualTree.Instantiate();
        // root.Add(labelFromUXML);

        AddCustomControl(root);
    }

    private void AddCustomControl(VisualElement root)
    {
        var customControlAsset = AssetDatabase.LoadAssetAtPath<VisualTreeAsset>("Assets/Editor/CustomControl.uxml");
        VisualElement customControl = customControlAsset.CloneTree();
        root.Add(customControl);
    }
}
