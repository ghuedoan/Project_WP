﻿#pragma checksum "C:\GitHub\Project_WP\KeepItFit - Project WinUI\KeepItFit - Project WinUI\View\FoodDiary.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "6B907A1995DFAF366F3EABDE74FF7364DD6400F7CF801EFB538787E795BC41F0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KeepItFit___Project_WinUI
{
    partial class FoodDiary : 
        global::Microsoft.UI.Xaml.Controls.Page, 
        global::Microsoft.UI.Xaml.Markup.IComponentConnector
    {

        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2409")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // View\FoodDiary.xaml line 125
                {
                    this.HomeFoodFrame = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.Frame>(target);
                }
                break;
            case 3: // View\FoodDiary.xaml line 116
                {
                    this._Snacks = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this._Snacks).Tapped += this.TextBlock_Tapped_Meal;
                }
                break;
            case 4: // View\FoodDiary.xaml line 118
                {
                    this.Snacks = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this.Snacks).Tapped += this.TextBlock_Tapped_QuickAdd;
                }
                break;
            case 5: // View\FoodDiary.xaml line 100
                {
                    this._Dinner = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this._Dinner).Tapped += this.TextBlock_Tapped_Meal;
                }
                break;
            case 6: // View\FoodDiary.xaml line 102
                {
                    this.Dinner = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this.Dinner).Tapped += this.TextBlock_Tapped_QuickAdd;
                }
                break;
            case 7: // View\FoodDiary.xaml line 84
                {
                    this._Lunch = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this._Lunch).Tapped += this.TextBlock_Tapped_Meal;
                }
                break;
            case 8: // View\FoodDiary.xaml line 86
                {
                    this.Lunch = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this.Lunch).Tapped += this.TextBlock_Tapped_QuickAdd;
                }
                break;
            case 9: // View\FoodDiary.xaml line 66
                {
                    this._BreakFast = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this._BreakFast).Tapped += this.TextBlock_Tapped_Meal;
                }
                break;
            case 10: // View\FoodDiary.xaml line 68
                {
                    this.BreakFast = global::WinRT.CastExtensions.As<global::Microsoft.UI.Xaml.Controls.TextBlock>(target);
                    ((global::Microsoft.UI.Xaml.Controls.TextBlock)this.BreakFast).Tapped += this.TextBlock_Tapped_QuickAdd;
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
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.UI.Xaml.Markup.Compiler"," 3.0.0.2409")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Microsoft.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Microsoft.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

