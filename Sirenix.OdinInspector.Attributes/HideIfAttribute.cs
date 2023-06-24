using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public sealed class HideIfAttribute : Attribute
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000B")]
		[Obsolete("Use the Condition member instead.", false)]
		public string MemberName
		{
			[Token(Token = "0x6000052")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000053")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x2A88750", Offset = "0x2A86D50", VA = "0x182A88750")]
		public HideIfAttribute(string condition, bool animate = true)
		{
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x21CF130", Offset = "0x21CD730", VA = "0x1821CF130")]
		public HideIfAttribute(string condition, object optionalValue, bool animate = true)
		{
		}

		// Token: 0x0400004D RID: 77
		[Token(Token = "0x400004D")]
		[FieldOffset(Offset = "0x10")]
		public string Condition;

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		public object Value;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		public bool Animate;
	}
}
