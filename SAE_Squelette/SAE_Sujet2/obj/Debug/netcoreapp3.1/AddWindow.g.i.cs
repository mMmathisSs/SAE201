﻿#pragma checksum "..\..\..\AddWindow.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0B234D60A73FA208793C97FCCA5522B0DD6CD65A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using SAE_Sujet2;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace SAE_Sujet2 {
    
    
    /// <summary>
    /// AddWindow
    /// </summary>
    public partial class AddWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 94 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbDivision;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox cbMission;
        
        #line default
        #line hidden
        
        
        #line 120 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DatePicker dpicker;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tbAdd;
        
        #line default
        #line hidden
        
        
        #line 137 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button button_Add;
        
        #line default
        #line hidden
        
        
        #line 156 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label MissionErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 167 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DivisionErrorLabel;
        
        #line default
        #line hidden
        
        
        #line 178 "..\..\..\AddWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Label DatePickerErrorLabel;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/SAE_Sujet2;V1.0.0.0;component/addwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\AddWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "5.0.17.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.cbDivision = ((System.Windows.Controls.ComboBox)(target));
            
            #line 102 "..\..\..\AddWindow.xaml"
            this.cbDivision.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbDivision_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 2:
            this.cbMission = ((System.Windows.Controls.ComboBox)(target));
            
            #line 112 "..\..\..\AddWindow.xaml"
            this.cbMission.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.cbDivision_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.dpicker = ((System.Windows.Controls.DatePicker)(target));
            return;
            case 4:
            this.tbAdd = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.button_Add = ((System.Windows.Controls.Button)(target));
            
            #line 143 "..\..\..\AddWindow.xaml"
            this.button_Add.Click += new System.Windows.RoutedEventHandler(this.button_Add_Click);
            
            #line default
            #line hidden
            return;
            case 6:
            
            #line 153 "..\..\..\AddWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.Button_Click);
            
            #line default
            #line hidden
            return;
            case 7:
            this.MissionErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 8:
            this.DivisionErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            case 9:
            this.DatePickerErrorLabel = ((System.Windows.Controls.Label)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

