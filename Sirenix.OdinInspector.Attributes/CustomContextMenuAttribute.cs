using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[DontApplyToListElements]
	public sealed class CustomContextMenuAttribute : Attribute
	{
		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000004")]
		[Obsolete("Use the Action member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MethodName
		{
			[Token(Token = "0x600001F")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000020")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x992FC0", Offset = "0x9915C0", VA = "0x180992FC0")]
		public CustomContextMenuAttribute(string menuItem, string action)
		{
		}

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x10")]
		public string MenuItem;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x18")]
		public string Action;
	}
}
