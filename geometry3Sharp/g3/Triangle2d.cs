using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	public struct Triangle2d
	{
		// Token: 0x06001106 RID: 4358 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001106")]
		[Address(RVA = "0x15D9CC0", Offset = "0x15D82C0", VA = "0x1815D9CC0")]
		public Triangle2d(Vector2d v0, Vector2d v1, Vector2d v2)
		{
		}

		// Token: 0x170002BD RID: 701
		[Token(Token = "0x170002BD")]
		public Vector2d this[int key]
		{
			[Token(Token = "0x6001107")]
			[Address(RVA = "0x1E4DBB0", Offset = "0x1E4C1B0", VA = "0x181E4DBB0")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x6001108")]
			[Address(RVA = "0x1E4DBE0", Offset = "0x1E4C1E0", VA = "0x181E4DBE0")]
			set
			{
			}
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x0000CE9C File Offset: 0x0000B09C
		[Token(Token = "0x6001109")]
		[Address(RVA = "0x1E4DC00", Offset = "0x1E4C200", VA = "0x181E4DC00")]
		public Vector2d PointAt(double bary0, double bary1, double bary2)
		{
			return default(Vector2d);
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0000CEB4 File Offset: 0x0000B0B4
		[Token(Token = "0x600110A")]
		[Address(RVA = "0x1E4DCD0", Offset = "0x1E4C2D0", VA = "0x181E4DCD0")]
		public Vector2d PointAt(Vector3d bary)
		{
			return default(Vector2d);
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x0000CECC File Offset: 0x0000B0CC
		[Token(Token = "0x600110B")]
		[Address(RVA = "0x1E4DDA0", Offset = "0x1E4C3A0", VA = "0x181E4DDA0")]
		public static implicit operator Triangle2d(Triangle2f v)
		{
			return default(Triangle2d);
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x0000CEE4 File Offset: 0x0000B0E4
		[Token(Token = "0x600110C")]
		[Address(RVA = "0x1E4DE70", Offset = "0x1E4C470", VA = "0x181E4DE70")]
		public static explicit operator Triangle2f(Triangle2d v)
		{
			return default(Triangle2f);
		}

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x0")]
		public Vector2d V0;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x10")]
		public Vector2d V1;

		// Token: 0x04000845 RID: 2117
		[Token(Token = "0x4000845")]
		[FieldOffset(Offset = "0x20")]
		public Vector2d V2;
	}
}
