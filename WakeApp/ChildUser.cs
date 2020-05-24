﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace WakeApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ChildUser recording.
    /// </summary>
    [TestModule("5db6105c-6542-4f93-b83a-ca9f888be580", ModuleType.Recording, 1)]
    public partial class ChildUser : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WakeAppRepository repository.
        /// </summary>
        public static WakeAppRepository repo = WakeAppRepository.Instance;

        static ChildUser instance = new ChildUser();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ChildUser()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ChildUser Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.projektbudzik.pl/Account/Register?' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://www.projektbudzik.pl/Account/Register?", "Chrome", "", false, false, false, true, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp' at 485;270.", repo.WelcomeWakeApp.SelfInfo, new RecordItemIndex(2));
            repo.WelcomeWakeApp.Self.Click("485;270");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'childuser2' with focus on 'WelcomeWakeApp'.", repo.WelcomeWakeApp.SelfInfo, new RecordItemIndex(3));
            repo.WelcomeWakeApp.Self.EnsureVisible();
            Keyboard.Press("childuser2");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Email' at 161;8.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(4));
            repo.WelcomeWakeApp.Email.Click("161;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'child23' with focus on 'WelcomeWakeApp.Email'.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(5));
            repo.WelcomeWakeApp.Email.PressKeys("child23");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1{RShiftKey down}@{RShiftKey up}gmail.com' with focus on 'WelcomeWakeApp.Email'.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(6));
            repo.WelcomeWakeApp.Email.PressKeys("1{RShiftKey down}@{RShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Password' at 124;8.", repo.WelcomeWakeApp.PasswordInfo, new RecordItemIndex(7));
            repo.WelcomeWakeApp.Password.Click("124;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WakeApp132{RShiftKey down}!{RShiftKey up}' with focus on 'WelcomeWakeApp.Password'.", repo.WelcomeWakeApp.PasswordInfo, new RecordItemIndex(8));
            repo.WelcomeWakeApp.Password.PressKeys("WakeApp132{RShiftKey down}!{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.ConfirmPassword' at 101;13.", repo.WelcomeWakeApp.ConfirmPasswordInfo, new RecordItemIndex(9));
            repo.WelcomeWakeApp.ConfirmPassword.Click("101;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WakeApp132{RShiftKey down}!{RShiftKey up}' with focus on 'WelcomeWakeApp.ConfirmPassword'.", repo.WelcomeWakeApp.ConfirmPasswordInfo, new RecordItemIndex(10));
            repo.WelcomeWakeApp.ConfirmPassword.PressKeys("WakeApp132{RShiftKey down}!{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.GroupName' at 75;16.", repo.WelcomeWakeApp.GroupNameInfo, new RecordItemIndex(11));
            repo.WelcomeWakeApp.GroupName.Click("75;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test1' with focus on 'WelcomeWakeApp'.", repo.WelcomeWakeApp.SelfInfo, new RecordItemIndex(12));
            repo.WelcomeWakeApp.Self.EnsureVisible();
            Keyboard.Press("test1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.GroupPassword' at 49;28.", repo.WelcomeWakeApp.GroupPasswordInfo, new RecordItemIndex(13));
            repo.WelcomeWakeApp.GroupPassword.Click("49;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'WelcomeWakeApp.GroupPassword'.", repo.WelcomeWakeApp.GroupPasswordInfo, new RecordItemIndex(14));
            repo.WelcomeWakeApp.GroupPassword.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Submit1' at 56;22.", repo.WelcomeWakeApp.Submit1Info, new RecordItemIndex(15));
            repo.WelcomeWakeApp.Submit1.Click("56;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WelcomeWakeApp.DivTagCol'.", repo.WelcomeWakeApp.DivTagColInfo, new RecordItemIndex(16));
            Validate.Exists(repo.WelcomeWakeApp.DivTagColInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'WelcomeWakeApp'.", repo.WelcomeWakeApp.SelfInfo, new RecordItemIndex(17));
            Host.Current.CloseApplication(repo.WelcomeWakeApp.Self, 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
