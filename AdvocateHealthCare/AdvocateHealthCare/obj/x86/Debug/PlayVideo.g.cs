﻿#pragma checksum "C:\Users\sridhar\Documents\Visual Studio 2015\Projects\GitHubAdvocateHealthCare\AdvocateHealthCare\AdvocateHealthCare\PlayVideo.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "753E8F6310D39C8AB996A56C9C33EE55"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdvocateHealthCare
{
    partial class PlayVideo : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.BackNav = (global::Windows.UI.Xaml.Controls.Image)(target);
                    #line 19 "..\..\..\PlayVideo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Image)this.BackNav).Tapped += this.BackNav_Tapped;
                    #line default
                }
                break;
            case 2:
                {
                    this.btnPause = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 30 "..\..\..\PlayVideo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPause).Click += this.btnPause_Click;
                    #line default
                }
                break;
            case 3:
                {
                    this.btnStop = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 31 "..\..\..\PlayVideo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnStop).Click += this.btnStop_Click;
                    #line default
                }
                break;
            case 4:
                {
                    this.btnPLay = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 32 "..\..\..\PlayVideo.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.btnPLay).Click += this.btnPLay_Click;
                    #line default
                }
                break;
            case 5:
                {
                    this.txtCoutDown = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 6:
                {
                    this.mediaYoutube = (global::Windows.UI.Xaml.Controls.MediaElement)(target);
                }
                break;
            case 7:
                {
                    this.imgPause = (global::Windows.UI.Xaml.Controls.Image)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

