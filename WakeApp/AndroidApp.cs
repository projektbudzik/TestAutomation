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
    ///The AndroidApp recording.
    /// </summary>
    [TestModule("2e574600-c103-4acb-9547-dc82173feebf", ModuleType.Recording, 1)]
    public partial class AndroidApp : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WakeAppRepository repository.
        /// </summary>
        public static WakeAppRepository repo = WakeAppRepository.Instance;

        static AndroidApp instance = new AndroidApp();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public AndroidApp()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static AndroidApp Instance
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

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'm.example.wakeapp2' on device " + Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName() + ".", new RecordItemIndex(0));
            Host.Local.RunMobileApp(Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName(), "m.example.wakeapp2", true);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Left (180°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'MExampleWakeapp2.Content'.", repo.MExampleWakeapp2.ContentInfo, new RecordItemIndex(1));
            repo.MExampleWakeapp2.Content.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Left (180°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch gestures", "Swipe gesture with direction 'Left (180°)' starting from 'Center' with distance '1.0' with swipe duration'500ms' and step count '0' on item 'MExampleWakeapp2.Content'.", repo.MExampleWakeapp2.ContentInfo, new RecordItemIndex(2));
            repo.MExampleWakeapp2.Content.Swipe(Location.Center, ValueConverter.ArgumentFromString<Ranorex.Core.Recorder.Touch.GestureDirection>("SwipeDirection", "Left (180°)"), ValueConverter.ArgumentFromString<Ranorex.Core.Distance>("Distance", "1.0"), ValueConverter.ArgumentFromString<Ranorex.Duration>("SwipeDuration", "500ms"), 0);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'MExampleWakeapp2.EtLogin1' at Center", repo.MExampleWakeapp2.EtLogin1Info, new RecordItemIndex(3));
            repo.MExampleWakeapp2.EtLogin1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'test1@gmail.com' on item 'MExampleWakeapp2.EtLogin1'.", repo.MExampleWakeapp2.EtLogin1Info, new RecordItemIndex(4));
            repo.MExampleWakeapp2.EtLogin1.Element.SetAttributeValue("Text", "test1@gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'MExampleWakeapp2.EtPassword1' at Center", repo.MExampleWakeapp2.EtPassword1Info, new RecordItemIndex(5));
            repo.MExampleWakeapp2.EtPassword1.Touch();
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Set value", "Setting attribute Text to 'WakeApp132!' on item 'MExampleWakeapp2.EtPassword1'.", repo.MExampleWakeapp2.EtPassword1Info, new RecordItemIndex(6));
            repo.MExampleWakeapp2.EtPassword1.Element.SetAttributeValue("Text", "WakeApp132!");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Touch", "Touch item 'MExampleWakeapp2.BtnLoginUser' at Center", repo.MExampleWakeapp2.BtnLoginUserInfo, new RecordItemIndex(7));
            repo.MExampleWakeapp2.BtnLoginUser.Touch();
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}