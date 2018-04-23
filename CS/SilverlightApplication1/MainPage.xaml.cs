using System;
using System.Windows.Controls;
using System.Collections.Generic;
using DevExpress.XtraScheduler;

namespace SilverlightApplication1 {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();

            #region #CustomWorkingDays
            schedulerControl1.WorkDays.BeginUpdate();
            schedulerControl1.WorkDays.Clear();
            schedulerControl1.WorkDays.Add(WeekDays.Monday | WeekDays.Tuesday |
                WeekDays.Wednesday | WeekDays.Thursday);
            schedulerControl1.WorkDays.EndUpdate();
            #endregion #CustomWorkingDays
        }
    }
    #region #ObjectList
    public class ObjectList : List<object> { }
    #endregion #ObjectList

    #region #CustomTimeScale
    public class CustomTimeScale : TimeScaleFixedInterval {
        // Fields
        private const bool defaultEnabled = true;
        // Methods
        public CustomTimeScale() : base(TimeSpan.FromHours(4.0)) { }
        protected override string DefaultDisplayName { get { return "Custom Scale"; } }
        protected override string DefaultMenuCaption { get { return "Custom Scale"; } }
    }
    #endregion #CustomTimeScale
}