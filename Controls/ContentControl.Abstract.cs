﻿using System.Drawing;
using System.Windows;
using System.Windows.Markup;

namespace Appercode.UI.Controls
{
    [ContentProperty("Content")]
    public partial class ContentControl : Control
    {
        public object NativeContent { get; set; }

        protected virtual void NativeArrangeContent(RectangleF contentFrame)
        {
        }

        private static double GetDefaultFontSize()
        {
            return 0d;
        }

        private void OnNativeContentChanged(object oldContent, object newContent)
        {
        }

        private SizeF NativeMeasureContent(SizeF availableSize)
        {
            return new SizeF();
        }

        protected Thickness GetNativePadding()
        {
            return new Thickness();
        }
    }
}