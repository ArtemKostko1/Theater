﻿#pragma checksum "..\..\..\Pages\PlayEdit.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "EB7A84F16FF3BEA3FBFCD3E9F291EE7569791D36DD154E36DA80B70C485CACF9"
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
        
        
        #line 28 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonBackFromPlayEditPage;
        
        #line default
        #line hidden
        
        
        #line 76 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPlayEditName;
        
        #line default
        #line hidden
        
        
        #line 91 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPlayEditAuthor;
        
        #line default
        #line hidden
        
        
        #line 106 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPlayEditGenre;
        
        #line default
        #line hidden
        
        
        #line 129 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox ComboBoxPlayEditParentalGuidance;
        
        #line default
        #line hidden
        
        
        #line 152 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox TextBoxPlayEditPremiere;
        
        #line default
        #line hidden
        
        
        #line 168 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button ButtonSavePlayEdit;
        
        #line default
        #line hidden
        
        
        #line 177 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayEditError;
        
        #line default
        #line hidden
        
        
        #line 188 "..\..\..\Pages\PlayEdit.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock TextBlockPlayEditOk;
        
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
            System.Uri resourceLocater = new System.Uri("/Theater;component/pages/playedit.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\PlayEdit.xaml"
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
            
            #line 29 "..\..\..\Pages\PlayEdit.xaml"
            this.ButtonBackFromPlayEditPage.Click += new System.Windows.RoutedEventHandler(this.ButtonBackFromPlayEditPage_Click);
            
            #line default
            #line hidden
            return;
            case 2:
            this.TextBoxPlayEditName = ((System.Windows.Controls.TextBox)(target));
            return;
            case 3:
            this.TextBoxPlayEditAuthor = ((System.Windows.Controls.TextBox)(target));
            return;
            case 4:
            this.ComboBoxPlayEditGenre = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 5:
            this.ComboBoxPlayEditParentalGuidance = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 6:
            this.TextBoxPlayEditPremiere = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.ButtonSavePlayEdit = ((System.Windows.Controls.Button)(target));
            
            #line 169 "..\..\..\Pages\PlayEdit.xaml"
            this.ButtonSavePlayEdit.Click += new System.Windows.RoutedEventHandler(this.ButtonSavePlayEdit_Click);
            
            #line default
            #line hidden
            return;
            case 8:
            this.TextBlockPlayEditError = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.TextBlockPlayEditOk = ((System.Windows.Controls.TextBlock)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

