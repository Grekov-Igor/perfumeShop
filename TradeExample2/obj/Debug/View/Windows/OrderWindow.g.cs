﻿#pragma checksum "..\..\..\..\View\Windows\OrderWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "DD897657B10052FE24C4A9DEC6AB04A9B3D73D94088CBD4D0E6D390E2FD494A2"
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
using TradeExample.View.Windows;


namespace TradeExample.View.Windows {
    
    
    /// <summary>
    /// OrderWindow
    /// </summary>
    public partial class OrderWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        
        #line 32 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock UserNameTB;
        
        #line default
        #line hidden
        
        
        #line 41 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ListBox ProductLB;
        
        #line default
        #line hidden
        
        
        #line 90 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock CreateDateTB;
        
        #line default
        #line hidden
        
        
        #line 92 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock DeliveryDateTB;
        
        #line default
        #line hidden
        
        
        #line 98 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox PickPointCB;
        
        #line default
        #line hidden
        
        
        #line 109 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock OrderCodeTB;
        
        #line default
        #line hidden
        
        
        #line 124 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalCostTB;
        
        #line default
        #line hidden
        
        
        #line 127 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalCostWithDiscountTB;
        
        #line default
        #line hidden
        
        
        #line 133 "..\..\..\..\View\Windows\OrderWindow.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock totalDiscountTB;
        
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
            System.Uri resourceLocater = new System.Uri("/TradeExample;component/view/windows/orderwindow.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\View\Windows\OrderWindow.xaml"
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
            this.UserNameTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.ProductLB = ((System.Windows.Controls.ListBox)(target));
            return;
            case 5:
            this.CreateDateTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 6:
            this.DeliveryDateTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 7:
            this.PickPointCB = ((System.Windows.Controls.ComboBox)(target));
            
            #line 99 "..\..\..\..\View\Windows\OrderWindow.xaml"
            this.PickPointCB.SelectionChanged += new System.Windows.Controls.SelectionChangedEventHandler(this.PickPointCB_SelectionChanged);
            
            #line default
            #line hidden
            return;
            case 8:
            this.OrderCodeTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 9:
            this.totalCostTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 10:
            this.totalCostWithDiscountTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 11:
            this.totalDiscountTB = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 12:
            
            #line 143 "..\..\..\..\View\Windows\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.CreateOrder);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 3:
            
            #line 72 "..\..\..\..\View\Windows\OrderWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.numOfProductsTB_TextChanged);
            
            #line default
            #line hidden
            
            #line 73 "..\..\..\..\View\Windows\OrderWindow.xaml"
            ((System.Windows.Controls.TextBox)(target)).PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(this.numOfProductsTB_PreviewTextInput);
            
            #line default
            #line hidden
            break;
            case 4:
            
            #line 76 "..\..\..\..\View\Windows\OrderWindow.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.DeleteFromOrder);
            
            #line default
            #line hidden
            break;
            }
        }
    }
}

