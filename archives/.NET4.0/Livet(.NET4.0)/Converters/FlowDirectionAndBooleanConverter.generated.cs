﻿//このコードはT4 Templateによって自動生成されています。

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Windows;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Controls.Primitives;
using System.ComponentModel;
using System.Windows.Interop;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Documents.Serialization;
using System.Windows.Input;
using System.Windows.Media.Animation;
using System.Windows.Media;
using System.Windows.Media.TextFormatting;
using System.Windows.Annotations;
using System.Windows.Ink;
using System.Windows.Automation.Peers;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Imaging;
using System.IO.Packaging;
using System.Security.RightsManagement;
using System.Windows.Threading;
using System.Windows.Media.Effects;
using System.Windows.Shell;
using System.Security.Permissions;
using System.Windows.Annotations.Storage;
using System.Diagnostics;

namespace Livet.Converters
{
	/// <summary>
    /// FlowDirection列挙体とbool値の相互変換を行うIValueConverterです。
    /// </summary>
    public class FlowDirectionAndBooleanConverter : IValueConverter
    {
        //VM→View
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is bool)) throw new ArgumentException();

            if ((bool)value)
            {
                if (_isConvertWhenTrueSet)
                {
                    return ConvertWhenTrue;
                }
            }
            else
            {
                if (_isConvertWhenFalseSet)
                {
                    return ConvertWhenFalse;
                }
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertWhenTrueSet;
        private FlowDirection _convertWhenTrue;
		/// <summary>
        /// ソース値がTrueの際にどのFlowDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FlowDirection ConvertWhenTrue
        {
            get
            {
                return _convertWhenTrue;
            }
            set
            {
                _convertWhenTrue = value;
                _isConvertWhenTrueSet = true;
            }
        }

        private bool _isConvertWhenFalseSet;
        private FlowDirection _convertWhenFalse;
		/// <summary>
        /// ソース値がFalseの際にどのFlowDirection列挙体メンバーに変換するかを指定、または取得します。
        /// </summary>
        public FlowDirection ConvertWhenFalse
        {
            get
            {
                return _convertWhenFalse;
            }
            set
            {
                _convertWhenFalse = value;
                _isConvertWhenFalseSet = true;
            }
        }

        //View→VM
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (!(value is FlowDirection)) throw new ArgumentException();

            var enumValue = (FlowDirection)value;

			switch(enumValue.ToString())
			{
				case "LeftToRight":
					if (_isConvertBackWhenLeftToRightSet)
					{
						return ConvertBackWhenLeftToRight;
					}
					break;
				case "RightToLeft":
					if (_isConvertBackWhenRightToLeftSet)
					{
						return ConvertBackWhenRightToLeft;
					}
					break;
				default:
					throw new ArgumentException();
			}

            if (_isConvertBackDefaultBooleanValueSet)
            {
                return ConvertBackDefaultBooleanValue;
            }

            return DependencyProperty.UnsetValue;
        }

        private bool _isConvertBackDefaultBooleanValueSet;
        private bool _convertBackDefaultBooleanValue;
		/// <summary>
        /// FlowDirectionの値をbool値に変換する際のデフォルト値を指定、または取得します。
        /// </summary>
        public bool ConvertBackDefaultBooleanValue
        {
            get
            {
                return _convertBackDefaultBooleanValue;
            }
            set
            {
                _convertBackDefaultBooleanValue = value;
				_isConvertBackDefaultBooleanValueSet = true;
            }
        }

        private bool _isConvertBackWhenLeftToRightSet;
        private bool _convertBackWhenLeftToRight;
		/// <summary>
        /// FlowDirectionの値がLeftToRightの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenLeftToRight
        {
            get
            {
                return _convertBackWhenLeftToRight;
            }
            set
            {
                _convertBackWhenLeftToRight = value;
                _isConvertBackWhenLeftToRightSet = true;
            }
        }
        private bool _isConvertBackWhenRightToLeftSet;
        private bool _convertBackWhenRightToLeft;
		/// <summary>
        /// FlowDirectionの値がRightToLeftの際True/Falseいずれに変換するのかを指定、または取得します。<br/>
        /// この値が設定されておらず、ConvertBackDefaultBooleanValueが設定されている場合はConvertBackDefaultBooleanValueに従います。
        /// </summary>
        public bool ConvertBackWhenRightToLeft
        {
            get
            {
                return _convertBackWhenRightToLeft;
            }
            set
            {
                _convertBackWhenRightToLeft = value;
                _isConvertBackWhenRightToLeftSet = true;
            }
        }
    }
}