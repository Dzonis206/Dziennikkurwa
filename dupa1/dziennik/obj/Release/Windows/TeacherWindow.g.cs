﻿#pragma checksum "..\..\..\Windows\TeacherWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "F8E574BA61B49887FE7F45A874DC635E91680FC809972D3EB7BAD5AA32BC922D"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ten kod został wygenerowany przez narzędzie.
//     Wersja wykonawcza:4.0.30319.42000
//
//     Zmiany w tym pliku mogą spowodować nieprawidłowe zachowanie i zostaną utracone, jeśli
//     kod zostanie ponownie wygenerowany.
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
using dziennik.Windows;


namespace dziennik.Windows {
    
    
    /// <summary>
    /// TeacherWindow
    /// </summary>
    public partial class TeacherWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 17 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox _listBox_uczniowie;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddStudentButton;
        
        #line default
        #line hidden
        
        
        #line 40 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _textblock_imie_nazwisko;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _textblock_pesel;
        
        #line default
        #line hidden
        
        
        #line 46 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _textblock_punkty;
        
        #line default
        #line hidden
        
        
        #line 49 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TreeView _treeView_oceny;
        
        #line default
        #line hidden
        
        
        #line 52 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _comboBox_subjects;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox _comboBox_grades;
        
        #line default
        #line hidden
        
        
        #line 59 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button AddPointsButton;
        
        #line default
        #line hidden
        
        
        #line 61 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button SubtractPointsButton;
        
        #line default
        #line hidden
        
        
        #line 64 "..\..\..\Windows\TeacherWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock _textblock_witaj;
        
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
            System.Uri resourceLocater = new System.Uri("/dziennik;component/windows/teacherwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Windows\TeacherWindow.xaml"
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
            this._listBox_uczniowie = ((System.Windows.Controls.ListBox)(target));
            return;
            case 2:
            this.AddStudentButton = ((System.Windows.Controls.Button)(target));
            
            #line 18 "..\..\..\Windows\TeacherWindow.xaml"
            this.AddStudentButton.Click += new System.Windows.RoutedEventHandler(this.AddStudentButton_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this._textblock_imie_nazwisko = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this._textblock_pesel = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this._textblock_punkty = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this._treeView_oceny = ((System.Windows.Controls.TreeView)(target));
            return;
            case 7:
            this._comboBox_subjects = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 8:
            this._comboBox_grades = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 9:
            
            #line 57 "..\..\..\Windows\TeacherWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.AddGrade_Click);
            
            #line default
            #line hidden
            return;
            case 10:
            this.AddPointsButton = ((System.Windows.Controls.Button)(target));
            
            #line 59 "..\..\..\Windows\TeacherWindow.xaml"
            this.AddPointsButton.Click += new System.Windows.RoutedEventHandler(this.AddPoints_Click);
            
            #line default
            #line hidden
            return;
            case 11:
            this.SubtractPointsButton = ((System.Windows.Controls.Button)(target));
            
            #line 61 "..\..\..\Windows\TeacherWindow.xaml"
            this.SubtractPointsButton.Click += new System.Windows.RoutedEventHandler(this.SubtractPoints_Click);
            
            #line default
            #line hidden
            return;
            case 12:
            this._textblock_witaj = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

