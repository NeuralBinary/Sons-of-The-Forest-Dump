using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000209 RID: 521
	[Token(Token = "0x2000209")]
	public struct Triangle3f
	{
		// Token: 0x0600111D RID: 4381 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600111D")]
		[Address(RVA = "0x1E4E940", Offset = "0x1E4CF40", VA = "0x181E4E940")]
		public Triangle3f(Vector3f v0, Vector3f v1, Vector3f v2)
		{
		}

		// Token: 0x170002C3 RID: 707
		[Token(Token = "0x170002C3")]
		public Vector3f this[int key]
		{
			[Token(Token = "0x600111E")]
			[Address(RVA = "0x1E3A540", Offset = "0x1E38B40", VA = "0x181E3A540")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x600111F")]
			[Address(RVA = "0x1E4E980", Offset = "0x1E4CF80", VA = "0x181E4E980")]
			set
			{
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0000D034 File Offset: 0x0000B234
		[Token(Token = "0x6001120")]
		[Address(RVA = "0x1E4E9B0", Offset = "0x1E4CFB0", VA = "0x181E4E9B0")]
		public Vector3f PointAt(float bary0, float bary1, float bary2)
		{
			return default(Vector3f);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0000D04C File Offset: 0x0000B24C
		[Token(Token = "0x6001121")]
		[Address(RVA = "0x1E4EAE0", Offset = "0x1E4D0E0", VA = "0x181E4EAE0")]
		public Vector3f PointAt(Vector3f bary)
		{
			return default(Vector3f);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0000D064 File Offset: 0x0000B264
		[Token(Token = "0x6001122")]
		[Address(RVA = "0x1E4EC00", Offset = "0x1E4D200", VA = "0x181E4EC00")]
		public Vector3f BarycentricCoords(Vector3f point)
		{
			return default(Vector3f);
		}

		// Token: 0x0400084C RID: 2124
		[Token(Token = "0x400084C")]
		[FieldOffset(Offset = "0x0")]
		public Vector3f V0;

		// Token: 0x0400084D RID: 2125
		[Token(Token = "0x400084D")]
		[FieldOffset(Offset = "0xC")]
		public Vector3f V1;

		// Token: 0x0400084E RID: 2126
		[Token(Token = "0x400084E")]
		[FieldOffset(Offset = "0x18")]
		public Vector3f V2;
	}
}
