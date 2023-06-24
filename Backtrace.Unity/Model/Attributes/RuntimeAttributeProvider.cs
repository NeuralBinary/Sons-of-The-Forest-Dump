using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Attributes
{
	// Token: 0x02000069 RID: 105
	[Token(Token = "0x2000069")]
	internal sealed class RuntimeAttributeProvider : IScopeAttributeProvider
	{
		// Token: 0x06000300 RID: 768 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000300")]
		[Address(RVA = "0x7648C0", Offset = "0x762EC0", VA = "0x1807648C0", Slot = "4")]
		public void GetAttributes(IDictionary<string, string> attributes)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000301")]
		[Address(RVA = "0x7651E0", Offset = "0x7637E0", VA = "0x1807651E0")]
		private string GetScriptingBackend()
		{
			return null;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000302")]
		[Address(RVA = "0x765210", Offset = "0x763810", VA = "0x180765210")]
		private string GetApiCompatibility()
		{
			return null;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000303")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public RuntimeAttributeProvider()
		{
		}
	}
}
