﻿#pragma checksum "..\..\..\Pages\Plays.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "7FF6D897BE5CCE0F4B1A5B94CF6510C36014932B7BB84D60A99FC34680B8C648"
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
using Theater;


namespace Theater.Pages {
    
    
    /// <summary>
    /// Plays
    /// </summary>
    public partial class Plays : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Pages\Plays.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem ItemOpenPerformanceInfoPage;
        
        #line default
        #line hidden
        
        
        #line 54 "..\..\..\Pages\Plays.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayName;
        
        #line default
        #line hidden
        
        
        #line 67 "..\..\..\Pages\Plays.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayGenre;
        
        #line default
        #line hidden
        
        
        #line 80 "..\..\..\Pages\Plays.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayParentalGuidance;
        
        #line default
        #line hidden
        
        
        #line 99 "..\..\..\Pages\Plays.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonOpenNewPerformancePage;
        
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
            System.Uri resourceLocater = new System.Uri("/Theater;component/pages/plays.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Plays.xaml"
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
            this.ItemOpenPerformanceInfoPage = ((System.Windows.Controls.ListBoxItem)(target));
            
            #line 43 "..\..\..\Pages\Plays.xaml"
            this.ItemOpenPerformanceInfoPage.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ItemOpenPerformanceInfoPage_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBlockPlayName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TextBlockPlayGenre = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TextBlockPlayParentalGuidance = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.ButtonOpenNewPerformancePage = ((System.Windows.Controls.Button)(target));
            
            #line 104 "..\..\..\Pages\Plays.xaml"
            this.ButtonOpenNewPerformancePage.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenNewPerformancePage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

