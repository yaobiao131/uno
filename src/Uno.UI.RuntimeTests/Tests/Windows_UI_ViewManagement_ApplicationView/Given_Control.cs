﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Uno.UI.Extensions;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Markup;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Private.Infrastructure;
using Windows.Foundation;
using Microsoft.UI.Xaml;

namespace Uno.UI.RuntimeTests.Tests.Windows_UI_ViewManagement_ApplicationView
{
	[TestClass]
	public class Given_ApplicationView
	{
		public static Rect StartupVisibleBounds { get; set; }

#if !__ANDROID__
		[Ignore]
#endif
		[TestMethod]
		public void When_StartupVisibleBounds_Has_Value()
		{
			Assert.IsFalse(RectHelper.GetIsEmpty(StartupVisibleBounds), $"VisibleBounds should not be empty");
		}
	}
}
