using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Sirenix.OdinInspector
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[Conditional("UNITY_EDITOR")]
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	public sealed class ColorPaletteAttribute : Attribute
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x2A88390", Offset = "0x2A86990", VA = "0x182A88390")]
		public ColorPaletteAttribute()
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001E")]
		[Address(RVA = "0xA90600", Offset = "0xA8EC00", VA = "0x180A90600")]
		public ColorPaletteAttribute(string paletteName)
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x10")]
		public string PaletteName;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x18")]
		public bool ShowAlpha;
	}
}
