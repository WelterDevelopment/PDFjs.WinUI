﻿#pragma checksum "C:\Users\welte\source\repos\PDFjs.WinUI\PDFjs.WinUI\PDFjsViewer.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "066C24453013EA1287A623FFD21B9A64E0466148C6DC2D724A60DA6CF29D4D4A"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PDFjs.WinUI
{
    partial class PDFjsViewer : 
        global::Microsoft.UI.Xaml.Controls.UserControl, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // PDFjsViewer.xaml line 10
                {
                    this.PDFjsViewerWebView = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.WebView2>(target);
                    ((global::Microsoft.UI.Xaml.Controls.WebView2)this.PDFjsViewerWebView).Loading += this.PDFjsViewerWebView_Loading;
                    ((global::Microsoft.UI.Xaml.Controls.WebView2)this.PDFjsViewerWebView).CoreWebView2Initialized += this.PDFjsViewerWebView_CoreWebView2Initialized;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 1.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}
