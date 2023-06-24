using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[DontApplyToListElements]
	public class LabelTextAttribute : Attribute
	{
		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public LabelTextAttribute(string text)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x20B7790", Offset = "0x20B5D90", VA = "0x1820B7790")]
		public LabelTextAttribute(string text, bool nicifyText)
		{
		}

		// Token: 0x0400006F RID: 111
		[Token(Token = "0x400006F")]
		[FieldOffset(Offset = "0x10")]
		public string Text;

		// Token: 0x04000070 RID: 112
		[Token(Token = "0x4000070")]
		[FieldOffset(Offset = "0x18")]
		public bool NicifyText;
	}
}
