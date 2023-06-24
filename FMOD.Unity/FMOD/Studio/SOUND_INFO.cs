using System;
using Il2CppDummyDll;

namespace FMOD.Studio
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	public struct SOUND_INFO
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x1700000D")]
		public string name
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0xB3F0E0", Offset = "0xB3D6E0", VA = "0x180B3F0E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x0")]
		public IntPtr name_or_data;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0x8")]
		public MODE mode;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x10")]
		public CREATESOUNDEXINFO exinfo;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0xF0")]
		public int subsoundindex;
	}
}
