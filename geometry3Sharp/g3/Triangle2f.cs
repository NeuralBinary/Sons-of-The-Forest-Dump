using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000207 RID: 519
	[Token(Token = "0x2000207")]
	public struct Triangle2f
	{
		// Token: 0x0600110D RID: 4365 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600110D")]
		[Address(RVA = "0x1E4DF30", Offset = "0x1E4C530", VA = "0x181E4DF30")]
		public Triangle2f(Vector2f v0, Vector2f v1, Vector2f v2)
		{
		}

		// Token: 0x170002BE RID: 702
		[Token(Token = "0x170002BE")]
		public Vector2f this[int key]
		{
			[Token(Token = "0x600110E")]
			[Address(RVA = "0x1E4DF40", Offset = "0x1E4C540", VA = "0x181E4DF40")]
			get
			{
				return default(Vector2f);
			}
			[Token(Token = "0x600110F")]
			[Address(RVA = "0x1E4DF80", Offset = "0x1E4C580", VA = "0x181E4DF80")]
			set
			{
			}
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x0000CF14 File Offset: 0x0000B114
		[Token(Token = "0x6001110")]
		[Address(RVA = "0x1E4DFA0", Offset = "0x1E4C5A0", VA = "0x181E4DFA0")]
		public Vector2f PointAt(float bary0, float bary1, float bary2)
		{
			return default(Vector2f);
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0000CF2C File Offset: 0x0000B12C
		[Token(Token = "0x6001111")]
		[Address(RVA = "0x1E4E070", Offset = "0x1E4C670", VA = "0x181E4E070")]
		public Vector2f PointAt(Vector3f bary)
		{
			return default(Vector2f);
		}

		// Token: 0x04000846 RID: 2118
		[Token(Token = "0x4000846")]
		[FieldOffset(Offset = "0x0")]
		public Vector2f V0;

		// Token: 0x04000847 RID: 2119
		[Token(Token = "0x4000847")]
		[FieldOffset(Offset = "0x8")]
		public Vector2f V1;

		// Token: 0x04000848 RID: 2120
		[Token(Token = "0x4000848")]
		[FieldOffset(Offset = "0x10")]
		public Vector2f V2;
	}
}
