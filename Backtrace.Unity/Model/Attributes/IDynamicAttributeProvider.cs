using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Attributes
{
	// Token: 0x02000063 RID: 99
	[Token(Token = "0x2000063")]
	public interface IDynamicAttributeProvider
	{
		// Token: 0x060002F4 RID: 756
		[Token(Token = "0x60002F4")]
		void GetAttributes(IDictionary<string, string> attributes);
	}
}
