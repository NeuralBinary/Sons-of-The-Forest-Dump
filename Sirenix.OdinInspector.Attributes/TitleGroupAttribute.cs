using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200006D RID: 109
	[Token(Token = "0x200006D")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public sealed class TitleGroupAttribute : PropertyGroupAttribute
	{
		// Token: 0x0600011E RID: 286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011E")]
		[Address(RVA = "0x2A8A530", Offset = "0x2A88B30", VA = "0x182A8A530")]
		public TitleGroupAttribute(string title, [Optional] string subtitle, TitleAlignments alignment = TitleAlignments.Left, bool horizontalLine = true, bool boldTitle = true, bool indent = false, float order = 0f)
		{
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600011F")]
		[Address(RVA = "0x2A8A5D0", Offset = "0x2A88BD0", VA = "0x182A8A5D0", Slot = "7")]
		protected override void CombineValuesWith(PropertyGroupAttribute other)
		{
		}

		// Token: 0x040000FD RID: 253
		[Token(Token = "0x40000FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public string Subtitle;

		// Token: 0x040000FE RID: 254
		[Token(Token = "0x40000FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public TitleAlignments Alignment;

		// Token: 0x040000FF RID: 255
		[Token(Token = "0x40000FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
		public bool HorizontalLine;

		// Token: 0x04000100 RID: 256
		[Token(Token = "0x4000100")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x45")]
		public bool BoldTitle;

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x46")]
		public bool Indent;
	}
}
