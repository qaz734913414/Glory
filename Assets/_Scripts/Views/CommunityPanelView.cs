﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoleMole
{

    public class CommunityPanelContext : BaseContext
    {
        public CommunityPanelContext()
            : base(UIType.CommunityPanel)
        {

        }
    }
    public class CommunityPanelView : AnimateView
    {

        public override void OnEnter(BaseContext context)
        {
            base.OnEnter(context);
        }

        public override void OnExit(BaseContext context)
        {
            base.OnExit(context);
        }

        public override void OnPause(BaseContext context)
        {
            _animator.SetTrigger("OnExit");
        }

        public override void OnResume(BaseContext context)
        {
            _animator.SetTrigger("OnEnter");
        }

        public void OptionCallBack()
        {
            //Singleton<ContextManager>.Instance.Push(new OptionMenuContext());
        }

        public void HighScoreCallBack()
        {
            //Singleton<ContextManager>.Instance.Push(new HighScoreContext());
        }
    }
}