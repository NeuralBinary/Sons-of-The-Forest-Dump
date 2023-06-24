using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[DontApplyToListElements]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class ShowIfAttribute : Attribute
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000FA RID: 250 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000033")]
		[Obsolete("Use the Condition member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
		{
			[Token(Token = "0x60000F9")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x2A88750", Offset = "0x2A86D50", VA = "0x182A88750")]
		public ShowIfAttribute(string condition, bool animate = true)
		{
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x21CF130", Offset = "0x21CD730", VA = "0x1821CF130")]
		public ShowIfAttribute(string condition, object optionalValue, bool animate = true)
		{
		}

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x10")]
		public string Condition;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x18")]
		public object Value;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0x20")]
		public bool Animate;
	}
}
