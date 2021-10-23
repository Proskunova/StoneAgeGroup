using DG.Tweening;
using UnityEngine;

public class Opening : MonoBehaviour
{
    [SerializeField] private Transform _panel;

    private Tween _tween;

    public void OpenPanel()
    {
        _tween = _panel.DOMove(new Vector3(0, _panel.position.y - 8), 2f, true);
    }

    private void OnDisable()
    {
        _tween.Kill();
    }
}
