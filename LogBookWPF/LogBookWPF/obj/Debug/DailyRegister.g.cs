﻿#pragma checksum "..\..\DailyRegister.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "7D5AAF0F2B98EB9E364208252FC884F9"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace LogBookWPF {
    
    
    /// <summary>
    /// DailyRegister
    /// </summary>
    public partial class DailyRegister : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 6 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnSave;
        
        #line default
        #line hidden
        
        
        #line 8 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker DpDates;
        
        #line default
        #line hidden
        
        
        #line 9 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox txtMentors;
        
        #line default
        #line hidden
        
        
        #line 10 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox txtTraining;
        
        #line default
        #line hidden
        
        
        #line 12 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid datadrid1;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridComboBoxColumn menteeCm;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\DailyRegister.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGridTextColumn Hours;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/LogBookWPF;component/dailyregister.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\DailyRegister.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 4 "..\..\DailyRegister.xaml"
            ((LogBookWPF.DailyRegister)(target)).Activated += new System.EventHandler(this.Window_Activated);
            
            #line default
            #line hidden
            return;
            case 2:
            this.btnSave = ((System.Windows.Controls.Button)(target));
            
            #line 6 "..\..\DailyRegister.xaml"
            this.btnSave.Click += new System.Windows.RoutedEventHandler(this.btnSave_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.DpDates = ((System.Windows.Controls.DatePicker)(target));
            
            #line 8 "..\..\DailyRegister.xaml"
            this.DpDates.SelectedDateChanged += new System.EventHandler<System.Windows.Controls.SelectionChangedEventArgs>(this.DpDates_SelectedDateChanged);
            
            #line default
            #line hidden
            return;
            case 4:
            this.txtMentors = ((System.Windows.Controls.ComboBox)(target));
            
            #line 9 "..\..\DailyRegister.xaml"
            this.txtMentors.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.txtMentors_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 5:
            this.txtTraining = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.datadrid1 = ((System.Windows.Controls.DataGrid)(target));
            return;
            case 7:
            this.menteeCm = ((System.Windows.Controls.DataGridComboBoxColumn)(target));
            return;
            case 8:
            this.Hours = ((System.Windows.Controls.DataGridTextColumn)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

