using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ChangeColorOnSelect : MonoBehaviour
{
    private Renderer _renderer;
    private Color _originalColor;

    void Awake()
    {
        _renderer = GetComponent<Renderer>();
        if (_renderer != null)
            _originalColor = _renderer.material.color;
    }

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (_renderer != null)
            _renderer.material.color = Color.red;
    }

    public void OnSelectExited(SelectExitEventArgs args)
    {
        if (_renderer != null)
            _renderer.material.color = _originalColor;
    }

    public void OnHoverEntered(HoverEnterEventArgs args)
    {
        if (_renderer != null)
            _renderer.material.color = Color.red;
    }

    public void OnHoverExited(HoverExitEventArgs args)
    {
        if (_renderer != null)
            _renderer.material.color = _originalColor;
    }

    public void OnFocusEntered()
    {
        if (_renderer != null)
            _renderer.material.color = Color.red;
    }

    public void OnFocusExited()
    {
        if (_renderer != null)
            _renderer.material.color = _originalColor;
    }
}