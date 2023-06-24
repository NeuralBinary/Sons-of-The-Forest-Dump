using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
	public abstract class ShapeRendererFillable : ShapeRenderer
	{
		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000205 RID: 517 RVA: 0x0000359C File Offset: 0x0000179C
		[Token(Token = "0x170000CC")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		private int FillTypeShaderInt
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x2A30B00", Offset = "0x2A2F100", VA = "0x182A30B00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000035B4 File Offset: 0x000017B4
		// (set) Token: 0x06000207 RID: 519 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CD")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public bool UseFill
		{
			[Token(Token = "0x6000206")]
			[Address(RVA = "0xA03DD0", Offset = "0xA023D0", VA = "0x180A03DD0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x2A30B20", Offset = "0x2A2F120", VA = "0x182A30B20")]
			set
			{
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000208 RID: 520 RVA: 0x000035CC File Offset: 0x000017CC
		// (set) Token: 0x06000209 RID: 521 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CE")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public FillType FillType
		{
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
			get
			{
				return FillType.LinearGradient;
			}
			[Token(Token = "0x6000209")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600020A RID: 522 RVA: 0x000035E4 File Offset: 0x000017E4
		// (set) Token: 0x0600020B RID: 523 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000CF")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public FillSpace FillSpace
		{
			[Token(Token = "0x600020A")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
			get
			{
				return FillSpace.Local;
			}
			[Token(Token = "0x600020B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600020C RID: 524 RVA: 0x000035FC File Offset: 0x000017FC
		// (set) Token: 0x0600020D RID: 525 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D0")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public Vector3 FillRadialOrigin
		{
			[Token(Token = "0x600020C")]
			[Address(RVA = "0x65F4B0", Offset = "0x65DAB0", VA = "0x18065F4B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600020D")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600020E RID: 526 RVA: 0x00003614 File Offset: 0x00001814
		// (set) Token: 0x0600020F RID: 527 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D1")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public float FillRadialRadius
		{
			[Token(Token = "0x600020E")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600020F")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000210 RID: 528 RVA: 0x0000362C File Offset: 0x0000182C
		// (set) Token: 0x06000211 RID: 529 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D2")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public Vector3 FillLinearStart
		{
			[Token(Token = "0x6000210")]
			[Address(RVA = "0x65F4B0", Offset = "0x65DAB0", VA = "0x18065F4B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000211")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000212 RID: 530 RVA: 0x00003644 File Offset: 0x00001844
		// (set) Token: 0x06000213 RID: 531 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D3")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public Vector3 FillLinearEnd
		{
			[Token(Token = "0x6000212")]
			[Address(RVA = "0x65F4B0", Offset = "0x65DAB0", VA = "0x18065F4B0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x6000213")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000214 RID: 532 RVA: 0x0000365C File Offset: 0x0000185C
		// (set) Token: 0x06000215 RID: 533 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D4")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public Color FillColorStart
		{
			[Token(Token = "0x6000214")]
			[Address(RVA = "0x9009B0", Offset = "0x8FEFB0", VA = "0x1809009B0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000215")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000216 RID: 534 RVA: 0x00003674 File Offset: 0x00001874
		// (set) Token: 0x06000217 RID: 535 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170000D5")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		public Color FillColorEnd
		{
			[Token(Token = "0x6000216")]
			[Address(RVA = "0x9009B0", Offset = "0x8FEFB0", VA = "0x1809009B0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000217")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			set
			{
			}
		}

		// Token: 0x06000218 RID: 536 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000218")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		private protected void SetFillProperties()
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000219")]
		[Address(RVA = "0x2A30BE0", Offset = "0x2A2F1E0", VA = "0x182A30BE0")]
		protected ShapeRendererFillable()
		{
		}

		// Token: 0x04000095 RID: 149
		[Token(Token = "0x4000095")]
		private const string OBSOLETE = "Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable";

		// Token: 0x04000096 RID: 150
		[Token(Token = "0x4000096")]
		[FieldOffset(Offset = "0x90")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		private protected GradientFill fill;

		// Token: 0x04000097 RID: 151
		[Token(Token = "0x4000097")]
		[FieldOffset(Offset = "0xE0")]
		[Obsolete("Shapes now use the IFillable interface instead of inheriting from ShapeRendererFillable", true)]
		private protected bool useFill;
	}
}
