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
    ///The Login recording.
    /// </summary>
    [TestModule("9988be6e-789f-4c29-a943-0a7af4384877", ModuleType.Recording, 1)]
    public partial class Login : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WakeAppRepository repository.
        /// </summary>
        public static WakeAppRepository repo = WakeAppRepository.Instance;

        static Login instance = new Login();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Login()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Login Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.projektbudzik.pl/Account/Login?' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://www.projektbudzik.pl/Account/Login?", "Chrome", "", false, false, false, true, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.ButtonTag' at 37;23.", repo.WelcomeWakeApp.ButtonTagInfo, new RecordItemIndex(2));
            repo.WelcomeWakeApp.ButtonTag.Click("37;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Email' at 160;14.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(3));
            repo.WelcomeWakeApp.Email.Click("160;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test1{RShiftKey down}@{RShiftKey up}gmail.com' with focus on 'WelcomeWakeApp.Email'.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(4));
            repo.WelcomeWakeApp.Email.PressKeys("test1{RShiftKey down}@{RShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Password' at 93;12.", repo.WelcomeWakeApp.PasswordInfo, new RecordItemIndex(5));
            repo.WelcomeWakeApp.Password.Click("93;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WakeApp132{RShiftKey down}!{RShiftKey up}' with focus on 'WelcomeWakeApp.Password'.", repo.WelcomeWakeApp.PasswordInfo, new RecordItemIndex(6));
            repo.WelcomeWakeApp.Password.PressKeys("WakeApp132{RShiftKey down}!{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.DivTagRow.Submit' at 78;13.", repo.WelcomeWakeApp.DivTagRow.SubmitInfo, new RecordItemIndex(7));
            repo.WelcomeWakeApp.DivTagRow.Submit.Click("78;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WelcomeWakeApp.DivTagCol'.", repo.WelcomeWakeApp.DivTagColInfo, new RecordItemIndex(8));
            Validate.Exists(repo.WelcomeWakeApp.DivTagColInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WelcomeWakeApp.DivTagCol1'.", repo.WelcomeWakeApp.DivTagCol1Info, new RecordItemIndex(9));
            Validate.Exists(repo.WelcomeWakeApp.DivTagCol1Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
