﻿#pragma checksum "..\..\..\Pages\PlayEditing.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "568224E9D104B5D4681474AE8237B17AAABF8A049208893B17B1EC0596CE642D"
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
    /// PlayEdit
    /// </summary>
    public partial class PlayEdit : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 28 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBackFromPlayEditPage;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPlayEditingName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPlayEditingAuthor;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPlayEditingGenre;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPlayEditingParentalGuidance;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPlayEditingPremiere;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSavePlayEditing;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayEditingError;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\Pages\PlayEditing.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayEditingOk;
        
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
            System.Uri resourceLocater = new System.Uri("/Theater;component/pages/playediting.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PlayEditing.xaml"
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
            this.ButtonBackFromPlayEditPage = ((System.Windows.Controls.Button)(target));
            
            #line 29 "..\..\..\Pages\PlayEditing.xaml"
            this.ButtonBackFromPlayEditPage.Click += new System.Windows.RoutedEventHandler(this.ButtonBackFromPlayEditPage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxPlayEditingName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxPlayEditingAuthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ComboBoxPlayEditingGenre = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ComboBoxPlayEditingParentalGuidance = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextBoxPlayEditingPremiere = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ButtonSavePlayEditing = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\Pages\PlayEditing.xaml"
            this.ButtonSavePlayEditing.Click += new System.Windows.RoutedEventHandler(this.ButtonSavePlayEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBlockPlayEditingError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TextBlockPlayEditingOk = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}
