using System;
using System.ComponentModel;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class TypeFilterAttribute : Attribute
	{
		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000129 RID: 297 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		[Obsolete("Use the FilterGetter member instead.", false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public string MemberName
		{
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600012B")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public TypeFilterAttribute(string filterGetter)
		{
		}

		// Token: 0x04000107 RID: 263
		[Token(Token = "0x4000107")]
		[FieldOffset(Offset = "0x10")]
		public string FilterGetter;

		// Token: 0x04000108 RID: 264
		[Token(Token = "0x4000108")]
		[FieldOffset(Offset = "0x18")]
		public string DropdownTitle;

		// Token: 0x04000109 RID: 265
		[Token(Token = "0x4000109")]
		[FieldOffset(Offset = "0x20")]
		public bool DrawValueNormally;
	}
}
