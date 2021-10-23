using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class LevelComplete : MonoBehaviour
    {
        [SerializeField] private Image _image;

        private Tween _tween;

        public void LevelCompletes()
        {
            _tween = _image.DOFade(1, 3f).OnComplete(LevelController.instance.Nextlevel);
        }

        private void OnDisable()
        {
            _tween.Kill();
        }
    }
}
