using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200004C RID: 76
	[Token(Token = "0x200004C")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	[DontApplyToListElements]
	public sealed class OnValueChangedAttribute : Attribute
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Use the Action member instead.", false)]
		public string MethodName
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x2A891E0", Offset = "0x2A877E0", VA = "0x182A891E0")]
		public OnValueChangedAttribute(string action, bool includeChildren = false)
		{
		}

		// Token: 0x040000A0 RID: 160
		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x10")]
		public string Action;

		// Token: 0x040000A1 RID: 161
		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x18")]
		public bool IncludeChildren;

		// Token: 0x040000A2 RID: 162
		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x19")]
		public bool InvokeOnUndoRedo;

		// Token: 0x040000A3 RID: 163
		[Token(Token = "0x40000A3")]
		[FieldOffset(Offset = "0x1A")]
		public bool InvokeOnInitialize;
	}
}
