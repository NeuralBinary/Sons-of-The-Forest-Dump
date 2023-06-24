using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000022 RID: 34
	[Token(Token = "0x2000022")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	public sealed class EnableIfAttribute : Attribute
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003D RID: 61 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000007")]
		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
		{
			[Token(Token = "0x600003D")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x600003E")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600003F")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public EnableIfAttribute(string condition)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000040")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public EnableIfAttribute(string condition, object optionalValue)
		{
		}

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x10")]
		public string Condition;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x18")]
		public object Value;
	}
}
