using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000216 RID: 534
	[Token(Token = "0x2000216")]
	public struct Vector3fTuple3
	{
		// Token: 0x060012EA RID: 4842 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60012EA")]
		[Address(RVA = "0x1E4E940", Offset = "0x1E4CF40", VA = "0x181E4E940")]
		public Vector3fTuple3(Vector3f v0, Vector3f v1, Vector3f v2)
		{
		}

		// Token: 0x17000309 RID: 777
		[Token(Token = "0x17000309")]
		public Vector3f this[int key]
		{
			[Token(Token = "0x60012EB")]
			[Address(RVA = "0x1E3A540", Offset = "0x1E38B40", VA = "0x181E3A540")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x60012EC")]
			[Address(RVA = "0x1E4E980", Offset = "0x1E4CF80", VA = "0x181E4E980")]
			set
			{
			}
		}

		// Token: 0x040008A3 RID: 2211
		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f V0;

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f V1;

		// Token: 0x040008A5 RID: 2213
		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x18")]
		public Vector3f V2;
	}
}
