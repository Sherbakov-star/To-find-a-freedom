﻿#pragma checksum "..\..\listzadaniy.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "290D77EABC5FFA3EBCE060B8D24244AA84124A859ABC83F3E615185D318E27EE"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
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
using To_Find_a_Freedom;


namespace To_Find_a_Freedom {
    
    
    /// <summary>
    /// listzadaniy
    /// </summary>
    public partial class listzadaniy : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 20 "..\..\listzadaniy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock zadanie1;
        
        #line default
        #line hidden
        
        
        #line 21 "..\..\listzadaniy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock zadanie2;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\listzadaniy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock zadanie1_Copy;
        
        #line default
        #line hidden
        
        
        #line 23 "..\..\listzadaniy.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock balance;
        
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
            System.Uri resourceLocater = new System.Uri("/To_Find_a_Freedom;component/listzadaniy.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\listzadaniy.xaml"
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
            this.zadanie1 = ((System.Windows.Controls.TextBlock)(target));
            
            #line 20 "..\..\listzadaniy.xaml"
            this.zadanie1.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.zadanie1_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 2:
            this.zadanie2 = ((System.Windows.Controls.TextBlock)(target));
            
            #line 21 "..\..\listzadaniy.xaml"
            this.zadanie2.PreviewMouseDown += new System.Windows.Input.MouseButtonEventHandler(this.zadanie2_PreviewMouseDown);
            
            #line default
            #line hidden
            return;
            case 3:
            this.zadanie1_Copy = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.balance = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
