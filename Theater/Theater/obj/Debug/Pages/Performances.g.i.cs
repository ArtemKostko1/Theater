﻿#pragma checksum "..\..\..\Pages\Performances.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EC8EEAD8455E6A86708BECB2AE79D6077BAA6547F15AB1902F51EA34BA35BEDA"
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
using Theater.Pages;


namespace Theater.Pages {
    
    
    /// <summary>
    /// Performances
    /// </summary>
    public partial class Performances : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 38 "..\..\..\Pages\Performances.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBoxItem ItemOpenPerformanceInfoPage;
        
        #line default
        #line hidden
        
        
        #line 55 "..\..\..\Pages\Performances.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPerformanceName;
        
        #line default
        #line hidden
        
        
        #line 68 "..\..\..\Pages\Performances.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPerformanceDate;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\Performances.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPerformanceTime;
        
        #line default
        #line hidden
        
        
        #line 88 "..\..\..\Pages\Performances.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPerformancePrice;
        
        #line default
        #line hidden
        
        
        #line 104 "..\..\..\Pages\Performances.xaml"
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
            System.Uri resourceLocater = new System.Uri("/Theater;component/pages/performances.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\Performances.xaml"
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
            
            #line 39 "..\..\..\Pages\Performances.xaml"
            this.ItemOpenPerformanceInfoPage.MouseDoubleClick += new System.Windows.Input.MouseButtonEventHandler(this.ItemOpenPerformanceInfoPage_MouseDoubleClick);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBlockPerformanceName = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 3:
            this.TextBlockPerformanceDate = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 4:
            this.TextBlockPerformanceTime = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.TextBlockPerformancePrice = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.ButtonOpenNewPerformancePage = ((System.Windows.Controls.Button)(target));
            
            #line 109 "..\..\..\Pages\Performances.xaml"
            this.ButtonOpenNewPerformancePage.Click += new System.Windows.RoutedEventHandler(this.ButtonOpenNewPerformancePage_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}
