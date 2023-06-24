using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	public sealed class InlineButtonAttribute : Attribute
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000072 RID: 114 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000073 RID: 115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000F")]
		[Obsolete("Use the Action member instead.", false)]
		public string MemberMethod
		{
			[Token(Token = "0x6000072")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000073")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000074")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public InlineButtonAttribute(string action, [Optional] string label)
		{
		}

		// Token: 0x04000060 RID: 96
		[Token(Token = "0x4000060")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Action;

		// Token: 0x04000061 RID: 97
		[Token(Token = "0x4000061")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Label;

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string ShowIf;
	}
}
