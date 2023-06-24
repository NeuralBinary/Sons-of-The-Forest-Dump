using System;
using Il2CppDummyDll;

namespace MudBun
{
	// Token: 0x0200000E RID: 14
	[Token(Token = "0x200000E")]
	public static class MudBun
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600003F RID: 63 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700000B")]
		public static string Version
		{
			[Token(Token = "0x600003F")]
			[Address(RVA = "0x23A9950", Offset = "0x23A7F50", VA = "0x1823A9950")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x0")]
		public static readonly int MajorVersion;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x4")]
		public static readonly int MinorVersion;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x8")]
		public static readonly int Revision;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string Suffix;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x18")]
		public static readonly bool IsFreeVersion;
	}
}
