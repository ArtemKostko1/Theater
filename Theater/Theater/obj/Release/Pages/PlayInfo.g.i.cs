﻿#pragma checksum "..\..\..\Pages\PlayInfo.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "3E2F6AF6780398CB9191F4EE47EEBBA12E08C01B178A1EB8D45974F01535F17A"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using MaterialDesignThemes.Wpf;
using MaterialDesignThemes.Wpf.Converters;
using MaterialDesignThemes.Wpf.Transitions;
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
using Theater.Pages;


namespace Theater.Pages {
    
    
    /// <summary>
    /// PlayInfo
    /// </summary>
    public partial class PlayInfo : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 92 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBackFromPerformanceInfoPage;
        
        #line default
        #line hidden
        
        
        #line 128 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonPlayEdit;
        
        #line default
        #line hidden
        
        
        #line 147 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayInfoName;
        
        #line default
        #line hidden
        
        
        #line 183 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayInfoAuthor;
        
        #line default
        #line hidden
        
        
        #line 206 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayInfoGenre;
        
        #line default
        #line hidden
        
        
        #line 229 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayInfoParentalGuidance;
        
        #line default
        #line hidden
        
        
        #line 249 "..\..\..\Pages\PlayInfo.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayInfoPremiere;
        
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
            System.Uri resourceLocater = new System.Uri("/Theater;component/pages/playinfo.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PlayInfo.xaml"
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
            this.ButtonBackFromPerformanceInfoPage = ((System.Windows.Controls.Button)(target));
            
            #line 99 "..\..\..\Pages\PlayInfo.xaml"
            this.ButtonBackFromPerformanceInfoPage.Click += new System.Windows.RoutedEventHandler(this.ButtonBackFromPerformanceInfoPage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.ButtonPlayEdit = ((System.Windows.Controls.Button)(target));
            
            #line 129 "..\..\..\Pages\PlayInfo.xaml"
            this.ButtonPlayEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonPlayEdit_Click);
            
            #line default
            #line hidden
            return;
            case 3:
            this.TextBlockPlayInfoName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TextBlockPlayInfoAuthor = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TextBlockPlayInfoGenre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.TextBlockPlayInfoParentalGuidance = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.TextBlockPlayInfoPremiere = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

