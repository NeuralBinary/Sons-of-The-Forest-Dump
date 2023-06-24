using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[DontApplyToListElements]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	public class TitleAttribute : Attribute
	{
		// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011D")]
		[Address(RVA = "0x2A8A400", Offset = "0x2A88A00", VA = "0x182A8A400")]
		public TitleAttribute(string title, [Optional] string subtitle, TitleAlignments titleAlignment = TitleAlignments.Left, bool horizontalLine = true, bool bold = true)
		{
		}

		// Token: 0x040000F8 RID: 248
		[Token(Token = "0x40000F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string Title;

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public string Subtitle;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool Bold;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool HorizontalLine;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		public TitleAlignments TitleAlignment;
	}
}
