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
    ///The SendEmptyForm recording.
    /// </summary>
    [TestModule("5f452627-79df-425f-ad45-814839d5eabf", ModuleType.Recording, 1)]
    public partial class SendEmptyForm : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WakeAppRepository repository.
        /// </summary>
        public static WakeAppRepository repo = WakeAppRepository.Instance;

        static SendEmptyForm instance = new SendEmptyForm();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public SendEmptyForm()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static SendEmptyForm Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Submit1' at 70;22.", repo.WelcomeWakeApp.Submit1Info, new RecordItemIndex(1));
            repo.WelcomeWakeApp.Submit1.Click("70;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Nazwa użytkownika jest wymagana') on item 'WelcomeWakeApp.NameError'.", repo.WelcomeWakeApp.NameErrorInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.WelcomeWakeApp.NameErrorInfo, "InnerText", "Nazwa użytkownika jest wymagana");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Email jest wymagany') on item 'WelcomeWakeApp.EmailError'.", repo.WelcomeWakeApp.EmailErrorInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.WelcomeWakeApp.EmailErrorInfo, "InnerText", "Email jest wymagany");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Hasło jest wymagane') on item 'WelcomeWakeApp.PasswordError'.", repo.WelcomeWakeApp.PasswordErrorInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.WelcomeWakeApp.PasswordErrorInfo, "InnerText", "Hasło jest wymagane");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Potwierdzenie hasła jest wymagane') on item 'WelcomeWakeApp.ConfirmPasswordError'.", repo.WelcomeWakeApp.ConfirmPasswordErrorInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.WelcomeWakeApp.ConfirmPasswordErrorInfo, "InnerText", "Potwierdzenie hasła jest wymagane");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Nazwa grupy jest wymagana') on item 'WelcomeWakeApp.GroupNameError'.", repo.WelcomeWakeApp.GroupNameErrorInfo, new RecordItemIndex(6));
            Validate.AttributeEqual(repo.WelcomeWakeApp.GroupNameErrorInfo, "InnerText", "Nazwa grupy jest wymagana");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Hasło grupy jest wymagane') on item 'WelcomeWakeApp.GroupPasswordError'.", repo.WelcomeWakeApp.GroupPasswordErrorInfo, new RecordItemIndex(7));
            Validate.AttributeEqual(repo.WelcomeWakeApp.GroupPasswordErrorInfo, "InnerText", "Hasło grupy jest wymagane");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'WelcomeWakeApp'.", repo.WelcomeWakeApp.SelfInfo, new RecordItemIndex(8));
            Host.Current.CloseApplication(repo.WelcomeWakeApp.Self, 100);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}