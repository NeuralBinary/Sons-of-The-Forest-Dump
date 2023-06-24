using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class CustomValueDrawerAttribute : Attribute
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000022 RID: 34 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000005")]
		[Obsolete("Use the Action member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MethodName
		{
			[Token(Token = "0x6000022")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public CustomValueDrawerAttribute(string action)
		{
		}

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x10")]
		public string Action;
	}
}
