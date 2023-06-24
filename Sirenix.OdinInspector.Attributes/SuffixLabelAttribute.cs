using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = false)]
	public sealed class SuffixLabelAttribute : Attribute
	{
		// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x20B7790", Offset = "0x20B5D90", VA = "0x1820B7790")]
		public SuffixLabelAttribute(string label, bool overlay = false)
		{
		}

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0x10")]
		public string Label;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0x18")]
		public bool Overlay;
	}
}
