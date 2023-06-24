using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public struct Colorf : IComparable<Colorf>, IEquatable<Colorf>
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012E")]
		[Address(RVA = "0x1E1F010", Offset = "0x1E1D610", VA = "0x181E1F010")]
		public Colorf(float greylevel, float a = 1f)
		{
		}

		// Token: 0x0600012F RID: 303 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012F")]
		[Address(RVA = "0x1E1F030", Offset = "0x1E1D630", VA = "0x181E1F030")]
		public Colorf(float r, float g, float b, float a = 1f)
		{
		}

		// Token: 0x06000130 RID: 304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000130")]
		[Address(RVA = "0x1E1F050", Offset = "0x1E1D650", VA = "0x181E1F050")]
		public Colorf(int r, int g, int b, int a = 255)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000131")]
		[Address(RVA = "0x1E1F140", Offset = "0x1E1D740", VA = "0x181E1F140")]
		public Colorf(float[] v2)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000132")]
		[Address(RVA = "0x1E1F190", Offset = "0x1E1D790", VA = "0x181E1F190")]
		public Colorf(Colorf copy)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000133")]
		[Address(RVA = "0x1E1F1B0", Offset = "0x1E1D7B0", VA = "0x181E1F1B0")]
		public Colorf(Colorf copy, float newAlpha)
		{
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000029FC File Offset: 0x00000BFC
		[Token(Token = "0x6000134")]
		[Address(RVA = "0x1E1F1D0", Offset = "0x1E1D7D0", VA = "0x181E1F1D0")]
		public Colorf Clone(float fAlphaMultiply = 1f)
		{
			return default(Colorf);
		}

		// Token: 0x1700001B RID: 27
		[Token(Token = "0x1700001B")]
		public float this[int key]
		{
			[Token(Token = "0x6000135")]
			[Address(RVA = "0x1E1F1F0", Offset = "0x1E1D7F0", VA = "0x181E1F1F0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x1E1F220", Offset = "0x1E1D820", VA = "0x181E1F220")]
			set
			{
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x6000137")]
		[Address(RVA = "0x1E1F250", Offset = "0x1E1D850", VA = "0x181E1F250")]
		public float SqrDistance(Colorf v2)
		{
			return 0f;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x6000138")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public Vector3f ToRGB()
		{
			return default(Vector3f);
		}

		// Token: 0x06000139 RID: 313 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x6000139")]
		[Address(RVA = "0x1E1F290", Offset = "0x1E1D890", VA = "0x181E1F290")]
		public Colorb ToBytes()
		{
			return default(Colorb);
		}

		// Token: 0x0600013A RID: 314 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x1E1F190", Offset = "0x1E1D790", VA = "0x181E1F190")]
		public void Set(Colorf o)
		{
		}

		// Token: 0x0600013B RID: 315 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013B")]
		[Address(RVA = "0x1E1F030", Offset = "0x1E1D630", VA = "0x181E1F030")]
		public void Set(float fR, float fG, float fB, float fA)
		{
		}

		// Token: 0x0600013C RID: 316 RVA: 0x00002A74 File Offset: 0x00000C74
		[Token(Token = "0x600013C")]
		[Address(RVA = "0x1E1F2D0", Offset = "0x1E1D8D0", VA = "0x181E1F2D0")]
		public Colorf SetAlpha(float a)
		{
			return default(Colorf);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x1E1F2F0", Offset = "0x1E1D8F0", VA = "0x181E1F2F0")]
		public void Add(Colorf o)
		{
		}

		// Token: 0x0600013E RID: 318 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x1E1F330", Offset = "0x1E1D930", VA = "0x181E1F330")]
		public void Subtract(Colorf o)
		{
		}

		// Token: 0x0600013F RID: 319 RVA: 0x00002A8C File Offset: 0x00000C8C
		[Token(Token = "0x600013F")]
		[Address(RVA = "0x1E1F370", Offset = "0x1E1D970", VA = "0x181E1F370")]
		public Colorf WithAlpha(float newAlpha)
		{
			return default(Colorf);
		}

		// Token: 0x06000140 RID: 320 RVA: 0x00002AA4 File Offset: 0x00000CA4
		[Token(Token = "0x6000140")]
		[Address(RVA = "0x1E1F390", Offset = "0x1E1D990", VA = "0x181E1F390")]
		public static Colorf operator -(Colorf v)
		{
			return default(Colorf);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x6000141")]
		[Address(RVA = "0x1E1F3B0", Offset = "0x1E1D9B0", VA = "0x181E1F3B0")]
		public static Colorf operator *(float f, Colorf v)
		{
			return default(Colorf);
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x6000142")]
		[Address(RVA = "0x1E1F3D0", Offset = "0x1E1D9D0", VA = "0x181E1F3D0")]
		public static Colorf operator *(Colorf v, float f)
		{
			return default(Colorf);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00002AEC File Offset: 0x00000CEC
		[Token(Token = "0x6000143")]
		[Address(RVA = "0x1E1F3F0", Offset = "0x1E1D9F0", VA = "0x181E1F3F0")]
		public static Colorf operator +(Colorf v0, Colorf v1)
		{
			return default(Colorf);
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x6000144")]
		[Address(RVA = "0x1E1F440", Offset = "0x1E1DA40", VA = "0x181E1F440")]
		public static Colorf operator +(Colorf v0, float f)
		{
			return default(Colorf);
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00002B1C File Offset: 0x00000D1C
		[Token(Token = "0x6000145")]
		[Address(RVA = "0x1E1F460", Offset = "0x1E1DA60", VA = "0x181E1F460")]
		public static Colorf operator -(Colorf v0, Colorf v1)
		{
			return default(Colorf);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00002B34 File Offset: 0x00000D34
		[Token(Token = "0x6000146")]
		[Address(RVA = "0x1E1F4B0", Offset = "0x1E1DAB0", VA = "0x181E1F4B0")]
		public static Colorf operator -(Colorf v0, float f)
		{
			return default(Colorf);
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00002B4C File Offset: 0x00000D4C
		[Token(Token = "0x6000147")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1DAF0", VA = "0x181E1F4F0")]
		public static bool operator ==(Colorf a, Colorf b)
		{
			return default(bool);
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00002B64 File Offset: 0x00000D64
		[Token(Token = "0x6000148")]
		[Address(RVA = "0x8DB570", Offset = "0x8D9B70", VA = "0x1808DB570")]
		public static bool operator !=(Colorf a, Colorf b)
		{
			return default(bool);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00002B7C File Offset: 0x00000D7C
		[Token(Token = "0x6000149")]
		[Address(RVA = "0x1E1F530", Offset = "0x1E1DB30", VA = "0x181E1F530", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00002B94 File Offset: 0x00000D94
		[Token(Token = "0x600014A")]
		[Address(RVA = "0x1E1F610", Offset = "0x1E1DC10", VA = "0x181E1F610", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00002BAC File Offset: 0x00000DAC
		[Token(Token = "0x600014B")]
		[Address(RVA = "0x1E1F650", Offset = "0x1E1DC50", VA = "0x181E1F650", Slot = "4")]
		public int CompareTo(Colorf other)
		{
			return 0;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00002BC4 File Offset: 0x00000DC4
		[Token(Token = "0x600014C")]
		[Address(RVA = "0x1E1F4F0", Offset = "0x1E1DAF0", VA = "0x181E1F4F0", Slot = "5")]
		public bool Equals(Colorf other)
		{
			return default(bool);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x600014D")]
		[Address(RVA = "0x1E1F6C0", Offset = "0x1E1DCC0", VA = "0x181E1F6C0")]
		public static Colorf Lerp(Colorf a, Colorf b, float t)
		{
			return default(Colorf);
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014E")]
		[Address(RVA = "0x1E1F730", Offset = "0x1E1DD30", VA = "0x181E1F730", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600014F")]
		[Address(RVA = "0x1E1F930", Offset = "0x1E1DF30", VA = "0x181E1F930")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x6000150")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static implicit operator Vector3f(Colorf c)
		{
			return default(Vector3f);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x6000151")]
		[Address(RVA = "0x1E1FAF0", Offset = "0x1E1E0F0", VA = "0x181E1FAF0")]
		public static implicit operator Colorf(Vector3f c)
		{
			return default(Colorf);
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000152")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Colorf(Color c)
		{
			return default(Colorf);
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00002C3C File Offset: 0x00000E3C
		[Token(Token = "0x6000153")]
		[Address(RVA = "0xA5FD10", Offset = "0xA5E310", VA = "0x180A5FD10")]
		public static implicit operator Color(Colorf c)
		{
			return default(Color);
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00002C54 File Offset: 0x00000E54
		[Token(Token = "0x6000154")]
		[Address(RVA = "0x1E1FB10", Offset = "0x1E1E110", VA = "0x181E1FB10")]
		public static implicit operator Color32(Colorf c)
		{
			return default(Color32);
		}

		// Token: 0x0400015D RID: 349
		[Token(Token = "0x400015D")]
		[FieldOffset(Offset = "0x0")]
		public float r;

		// Token: 0x0400015E RID: 350
		[Token(Token = "0x400015E")]
		[FieldOffset(Offset = "0x4")]
		public float g;

		// Token: 0x0400015F RID: 351
		[Token(Token = "0x400015F")]
		[FieldOffset(Offset = "0x8")]
		public float b;

		// Token: 0x04000160 RID: 352
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0xC")]
		public float a;

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Colorf TransparentWhite;

		// Token: 0x04000162 RID: 354
		[Token(Token = "0x4000162")]
		[FieldOffset(Offset = "0x10")]
		public static readonly Colorf TransparentBlack;

		// Token: 0x04000163 RID: 355
		[Token(Token = "0x4000163")]
		[FieldOffset(Offset = "0x20")]
		public static readonly Colorf White;

		// Token: 0x04000164 RID: 356
		[Token(Token = "0x4000164")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Colorf Black;

		// Token: 0x04000165 RID: 357
		[Token(Token = "0x4000165")]
		[FieldOffset(Offset = "0x40")]
		public static readonly Colorf Blue;

		// Token: 0x04000166 RID: 358
		[Token(Token = "0x4000166")]
		[FieldOffset(Offset = "0x50")]
		public static readonly Colorf Green;

		// Token: 0x04000167 RID: 359
		[Token(Token = "0x4000167")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Colorf Red;

		// Token: 0x04000168 RID: 360
		[Token(Token = "0x4000168")]
		[FieldOffset(Offset = "0x70")]
		public static readonly Colorf Yellow;

		// Token: 0x04000169 RID: 361
		[Token(Token = "0x4000169")]
		[FieldOffset(Offset = "0x80")]
		public static readonly Colorf Cyan;

		// Token: 0x0400016A RID: 362
		[Token(Token = "0x400016A")]
		[FieldOffset(Offset = "0x90")]
		public static readonly Colorf Magenta;

		// Token: 0x0400016B RID: 363
		[Token(Token = "0x400016B")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly Colorf VideoWhite;

		// Token: 0x0400016C RID: 364
		[Token(Token = "0x400016C")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly Colorf VideoBlack;

		// Token: 0x0400016D RID: 365
		[Token(Token = "0x400016D")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly Colorf VideoBlue;

		// Token: 0x0400016E RID: 366
		[Token(Token = "0x400016E")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly Colorf VideoGreen;

		// Token: 0x0400016F RID: 367
		[Token(Token = "0x400016F")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly Colorf VideoRed;

		// Token: 0x04000170 RID: 368
		[Token(Token = "0x4000170")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly Colorf VideoYellow;

		// Token: 0x04000171 RID: 369
		[Token(Token = "0x4000171")]
		[FieldOffset(Offset = "0x100")]
		public static readonly Colorf VideoCyan;

		// Token: 0x04000172 RID: 370
		[Token(Token = "0x4000172")]
		[FieldOffset(Offset = "0x110")]
		public static readonly Colorf VideoMagenta;

		// Token: 0x04000173 RID: 371
		[Token(Token = "0x4000173")]
		[FieldOffset(Offset = "0x120")]
		public static readonly Colorf Purple;

		// Token: 0x04000174 RID: 372
		[Token(Token = "0x4000174")]
		[FieldOffset(Offset = "0x130")]
		public static readonly Colorf DarkRed;

		// Token: 0x04000175 RID: 373
		[Token(Token = "0x4000175")]
		[FieldOffset(Offset = "0x140")]
		public static readonly Colorf FireBrick;

		// Token: 0x04000176 RID: 374
		[Token(Token = "0x4000176")]
		[FieldOffset(Offset = "0x150")]
		public static readonly Colorf HotPink;

		// Token: 0x04000177 RID: 375
		[Token(Token = "0x4000177")]
		[FieldOffset(Offset = "0x160")]
		public static readonly Colorf LightPink;

		// Token: 0x04000178 RID: 376
		[Token(Token = "0x4000178")]
		[FieldOffset(Offset = "0x170")]
		public static readonly Colorf DarkBlue;

		// Token: 0x04000179 RID: 377
		[Token(Token = "0x4000179")]
		[FieldOffset(Offset = "0x180")]
		public static readonly Colorf BlueMetal;

		// Token: 0x0400017A RID: 378
		[Token(Token = "0x400017A")]
		[FieldOffset(Offset = "0x190")]
		public static readonly Colorf Navy;

		// Token: 0x0400017B RID: 379
		[Token(Token = "0x400017B")]
		[FieldOffset(Offset = "0x1A0")]
		public static readonly Colorf CornflowerBlue;

		// Token: 0x0400017C RID: 380
		[Token(Token = "0x400017C")]
		[FieldOffset(Offset = "0x1B0")]
		public static readonly Colorf LightSteelBlue;

		// Token: 0x0400017D RID: 381
		[Token(Token = "0x400017D")]
		[FieldOffset(Offset = "0x1C0")]
		public static readonly Colorf DarkSlateBlue;

		// Token: 0x0400017E RID: 382
		[Token(Token = "0x400017E")]
		[FieldOffset(Offset = "0x1D0")]
		public static readonly Colorf Teal;

		// Token: 0x0400017F RID: 383
		[Token(Token = "0x400017F")]
		[FieldOffset(Offset = "0x1E0")]
		public static readonly Colorf ForestGreen;

		// Token: 0x04000180 RID: 384
		[Token(Token = "0x4000180")]
		[FieldOffset(Offset = "0x1F0")]
		public static readonly Colorf LightGreen;

		// Token: 0x04000181 RID: 385
		[Token(Token = "0x4000181")]
		[FieldOffset(Offset = "0x200")]
		public static readonly Colorf Orange;

		// Token: 0x04000182 RID: 386
		[Token(Token = "0x4000182")]
		[FieldOffset(Offset = "0x210")]
		public static readonly Colorf Gold;

		// Token: 0x04000183 RID: 387
		[Token(Token = "0x4000183")]
		[FieldOffset(Offset = "0x220")]
		public static readonly Colorf DarkYellow;

		// Token: 0x04000184 RID: 388
		[Token(Token = "0x4000184")]
		[FieldOffset(Offset = "0x230")]
		public static readonly Colorf SiennaBrown;

		// Token: 0x04000185 RID: 389
		[Token(Token = "0x4000185")]
		[FieldOffset(Offset = "0x240")]
		public static readonly Colorf SaddleBrown;

		// Token: 0x04000186 RID: 390
		[Token(Token = "0x4000186")]
		[FieldOffset(Offset = "0x250")]
		public static readonly Colorf Goldenrod;

		// Token: 0x04000187 RID: 391
		[Token(Token = "0x4000187")]
		[FieldOffset(Offset = "0x260")]
		public static readonly Colorf Wheat;

		// Token: 0x04000188 RID: 392
		[Token(Token = "0x4000188")]
		[FieldOffset(Offset = "0x270")]
		public static readonly Colorf LightGrey;

		// Token: 0x04000189 RID: 393
		[Token(Token = "0x4000189")]
		[FieldOffset(Offset = "0x280")]
		public static readonly Colorf Silver;

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x290")]
		public static readonly Colorf LightSlateGrey;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x2A0")]
		public static readonly Colorf Grey;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x2B0")]
		public static readonly Colorf DarkGrey;

		// Token: 0x0400018D RID: 397
		[Token(Token = "0x400018D")]
		[FieldOffset(Offset = "0x2C0")]
		public static readonly Colorf SlateGrey;

		// Token: 0x0400018E RID: 398
		[Token(Token = "0x400018E")]
		[FieldOffset(Offset = "0x2D0")]
		public static readonly Colorf DimGrey;

		// Token: 0x0400018F RID: 399
		[Token(Token = "0x400018F")]
		[FieldOffset(Offset = "0x2E0")]
		public static readonly Colorf DarkSlateGrey;

		// Token: 0x04000190 RID: 400
		[Token(Token = "0x4000190")]
		[FieldOffset(Offset = "0x2F0")]
		public static readonly Colorf StandardBeige;

		// Token: 0x04000191 RID: 401
		[Token(Token = "0x4000191")]
		[FieldOffset(Offset = "0x300")]
		public static readonly Colorf SelectionGold;

		// Token: 0x04000192 RID: 402
		[Token(Token = "0x4000192")]
		[FieldOffset(Offset = "0x310")]
		public static readonly Colorf PivotYellow;
	}
}
