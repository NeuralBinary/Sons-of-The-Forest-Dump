using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	public struct Colorb
	{
		// Token: 0x06000124 RID: 292 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000124")]
		[Address(RVA = "0x1E1EDF0", Offset = "0x1E1D3F0", VA = "0x181E1EDF0")]
		public Colorb(byte greylevel, byte a = 1)
		{
		}

		// Token: 0x06000125 RID: 293 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000125")]
		[Address(RVA = "0x5E9030", Offset = "0x5E7630", VA = "0x1805E9030")]
		public Colorb(byte r, byte g, byte b, byte a = 1)
		{
		}

		// Token: 0x06000126 RID: 294 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000126")]
		[Address(RVA = "0x1E1EE00", Offset = "0x1E1D400", VA = "0x181E1EE00")]
		public Colorb(float r, float g, float b, float a = 1f)
		{
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000127")]
		[Address(RVA = "0x1E1EEF0", Offset = "0x1E1D4F0", VA = "0x181E1EEF0")]
		public Colorb(byte[] v2)
		{
		}

		// Token: 0x06000128 RID: 296 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000128")]
		[Address(RVA = "0x1E1EF40", Offset = "0x1E1D540", VA = "0x181E1EF40")]
		public Colorb(Colorb copy)
		{
		}

		// Token: 0x06000129 RID: 297 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000129")]
		[Address(RVA = "0x1E1EF60", Offset = "0x1E1D560", VA = "0x181E1EF60")]
		public Colorb(Colorb copy, byte newAlpha)
		{
		}

		// Token: 0x1700001A RID: 26
		[Token(Token = "0x1700001A")]
		public byte this[int key]
		{
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x1E1EF80", Offset = "0x1E1D580", VA = "0x181E1EF80")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600012B")]
			[Address(RVA = "0x1E1EFB0", Offset = "0x1E1D5B0", VA = "0x181E1EFB0")]
			set
			{
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x000029CC File Offset: 0x00000BCC
		[Token(Token = "0x600012C")]
		[Address(RVA = "0x1E1EFE0", Offset = "0x1E1D5E0", VA = "0x181E1EFE0")]
		public static implicit operator Colorb(Color32 c)
		{
			return default(Colorb);
		}

		// Token: 0x0600012D RID: 301 RVA: 0x000029E4 File Offset: 0x00000BE4
		[Token(Token = "0x600012D")]
		[Address(RVA = "0x1E1EFE0", Offset = "0x1E1D5E0", VA = "0x181E1EFE0")]
		public static implicit operator Color32(Colorb c)
		{
			return default(Color32);
		}

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x0")]
		public byte r;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x1")]
		public byte g;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x2")]
		public byte b;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x3")]
		public byte a;
	}
}
