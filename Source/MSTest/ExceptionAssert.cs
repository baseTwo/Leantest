﻿using System;
using LeanTest.Core.ExecutionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeanTest.MSTest
{
	/// <summary>The MS Test adaption to <c>ExceptionAssertTException</c>.</summary>
	public static class ExceptionAssert
	{
		/// <summary>Throws an <c>AssertFailedException</c> exception if <c>action</c> throws an exception.</summary>
		public static void DoesNotThrow(Action action, string message = "") =>
			ExceptionAssertTException.Adapter(action, message, ExceptionAssertTException.DoesNotThrow, m => new AssertFailedException(m));
	}
}