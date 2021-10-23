using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private ImageFruits[] _imageFruits;
    [SerializeField] private Image[] _arrImages;

    private void OnEnable()
    {
        ButtonFruit.OnClickFruit += SetImage;
    }

    private void OnDisable()
    {
        ButtonFruit.OnClickFruit -= SetImage;
    }

    private void SetImage(FruitsType fruitsType)
    {
        HideAllImage();
        ImagesHide();

        for (int i = 0; i <_imageFruits.Length; i++)
        {
            if (fruitsType == _imageFruits[i].FruitsT)
            {
                _imageFruits[i].gameObject.SetActive(true);
            }
        }
    }

    private void HideAllImage()
    {
        for (int i = 0; i < _imageFruits.Length; i++)
        {
            _imageFruits[i].gameObject.SetActive(false);

        }
    }

    private void ImagesHide()
    {
        foreach (var item in _arrImages)
        {
            item.gameObject.SetActive(false);
        }
    }
}
