﻿//
//  PureMVC C# Standard
//
//  Copyright(c) 2017 Saad Shams <saad.shams@puremvc.org>
//  Your reuse is governed by the Creative Commons Attribution 3.0 License
//

using PureMVC.Patterns.Mediator;

namespace PureMVC.Core
{
    /// <summary>
    ///     A Mediator class used by ViewTest.
    /// </summary>
    /// <seealso cref="ViewTest" />
    public class ViewTestMediator4 : Mediator
    {
        // The Mediator name
        public new static string NAME = "ViewTestMediator4";

        // Constructor
        public ViewTestMediator4(object view) : base(NAME, view)
        {
        }

        public ViewTest ViewTest => (ViewTest) ViewComponent;

        public override void OnRegister()
        {
            ViewTest.onRegisterCalled = true;
        }

        public override void OnRemove()
        {
            ViewTest.onRemoveCalled = true;
        }
    }
}