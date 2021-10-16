using Spine.Unity;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpineTest
{
    public class SpineAnim : MonoBehaviour
    {
        [SerializeField] private SkeletonAnimation _myAnim;

        [SpineAnimation(dataField = "_myAnim")]
        [SerializeField] string _idle;
        [SpineAnimation(dataField = "_myAnim")]
        [SerializeField] string _jump;

        public void Play(string animName)
        {
            _myAnim.state.SetAnimation(0, animName, true);
        }

        public void IdleWalk()
        {
            _myAnim.state.SetAnimation(0, "Idle", false);
            _myAnim.state.AddAnimation(0, "walk", true, 0);
        }

        public void Jump()
        {
            _myAnim.state.SetAnimation(0, _idle, false);
            _myAnim.state.AddAnimation(0, _jump, false, 0);
            _myAnim.state.AddAnimation(0, _idle, true, 0 );
        }
    }
}

