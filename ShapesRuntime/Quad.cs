using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	[ExecuteAlways]
	[AddComponentMenu("Shapes/Quad")]
	public class Quad : ShapeRenderer
	{
		// Token: 0x1700005B RID: 91
		[Token(Token = "0x1700005B")]
		public Vector3 this[int index]
		{
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x2A26A40", Offset = "0x2A25040", VA = "0x182A26A40")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000E7")]
			[Address(RVA = "0x2A26B60", Offset = "0x2A25160", VA = "0x182A26B60")]
			set
			{
			}
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002A2C File Offset: 0x00000C2C
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2A26A40", Offset = "0x2A25040", VA = "0x182A26A40")]
		public Vector3 GetQuadVertex(int index)
		{
			return default(Vector3);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002A44 File Offset: 0x00000C44
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2A26E80", Offset = "0x2A25480", VA = "0x182A26E80")]
		public Vector3 SetQuadVertex(int index, Vector3 value)
		{
			return default(Vector3);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002A5C File Offset: 0x00000C5C
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2A26ED0", Offset = "0x2A254D0", VA = "0x182A26ED0")]
		public Color GetQuadColor(int index)
		{
			return default(Color);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2A26FE0", Offset = "0x2A255E0", VA = "0x182A26FE0")]
		public void SetQuadColor(int index, Color color)
		{
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060000EC RID: 236 RVA: 0x00002A74 File Offset: 0x00000C74
		// (set) Token: 0x060000ED RID: 237 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005C")]
		public Quad.QuadColorMode ColorMode
		{
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0xAFF2F0", Offset = "0xAFD8F0", VA = "0x180AFF2F0")]
			get
			{
				return Quad.QuadColorMode.Single;
			}
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x2A271E0", Offset = "0x2A257E0", VA = "0x182A271E0")]
			set
			{
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060000EE RID: 238 RVA: 0x00002A8C File Offset: 0x00000C8C
		// (set) Token: 0x060000EF RID: 239 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005D")]
		public Vector3 A
		{
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x70DB10", Offset = "0x70C110", VA = "0x18070DB10")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000EF")]
			[Address(RVA = "0x2A271F0", Offset = "0x2A257F0", VA = "0x182A271F0")]
			set
			{
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x060000F1 RID: 241 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005E")]
		public Vector3 B
		{
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x6719D0", Offset = "0x66FFD0", VA = "0x1806719D0")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F1")]
			[Address(RVA = "0x2A272A0", Offset = "0x2A258A0", VA = "0x182A272A0")]
			set
			{
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002ABC File Offset: 0x00000CBC
		// (set) Token: 0x060000F3 RID: 243 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700005F")]
		public Vector3 C
		{
			[Token(Token = "0x60000F2")]
			[Address(RVA = "0x2A27350", Offset = "0x2A25950", VA = "0x182A27350")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F3")]
			[Address(RVA = "0x2A27370", Offset = "0x2A25970", VA = "0x182A27370")]
			set
			{
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002AD4 File Offset: 0x00000CD4
		// (set) Token: 0x060000F5 RID: 245 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000060")]
		public Vector3 D
		{
			[Token(Token = "0x60000F4")]
			[Address(RVA = "0x2A27420", Offset = "0x2A25A20", VA = "0x182A27420")]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x2A27440", Offset = "0x2A25A40", VA = "0x182A27440")]
			set
			{
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002AEC File Offset: 0x00000CEC
		// (set) Token: 0x060000F7 RID: 247 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000061")]
		public bool IsUsingAutoD
		{
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x2A27570", Offset = "0x2A25B70", VA = "0x182A27570")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x2A27580", Offset = "0x2A25B80", VA = "0x182A27580")]
			set
			{
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060000F8 RID: 248 RVA: 0x00002B04 File Offset: 0x00000D04
		[Token(Token = "0x17000062")]
		public Vector3 DAuto
		{
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x2A27590", Offset = "0x2A25B90", VA = "0x182A27590")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x2A27630", Offset = "0x2A25C30", VA = "0x182A27630")]
		private void AutoSetD()
		{
		}

		// Token: 0x060000FA RID: 250 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x2A27730", Offset = "0x2A25D30", VA = "0x182A27730")]
		private void CheckAutoSetD()
		{
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060000FB RID: 251 RVA: 0x00002B1C File Offset: 0x00000D1C
		// (set) Token: 0x060000FC RID: 252 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000063")]
		public override Color Color
		{
			[Token(Token = "0x60000FB")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0", Slot = "4")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000FC")]
			[Address(RVA = "0x2A27750", Offset = "0x2A25D50", VA = "0x182A27750", Slot = "5")]
			set
			{
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060000FD RID: 253 RVA: 0x00002B34 File Offset: 0x00000D34
		// (set) Token: 0x060000FE RID: 254 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000064")]
		public Color ColorLeft
		{
			[Token(Token = "0x60000FD")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x60000FE")]
			[Address(RVA = "0x2A27870", Offset = "0x2A25E70", VA = "0x182A27870")]
			set
			{
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060000FF RID: 255 RVA: 0x00002B4C File Offset: 0x00000D4C
		// (set) Token: 0x06000100 RID: 256 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000065")]
		public Color ColorTop
		{
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x2A27930", Offset = "0x2A25F30", VA = "0x182A27930")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x2A27940", Offset = "0x2A25F40", VA = "0x182A27940")]
			set
			{
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000101 RID: 257 RVA: 0x00002B64 File Offset: 0x00000D64
		// (set) Token: 0x06000102 RID: 258 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000066")]
		public Color ColorRight
		{
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x295B880", Offset = "0x2959E80", VA = "0x18295B880")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x2A27A00", Offset = "0x2A26000", VA = "0x182A27A00")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000103 RID: 259 RVA: 0x00002B7C File Offset: 0x00000D7C
		// (set) Token: 0x06000104 RID: 260 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000067")]
		public Color ColorBottom
		{
			[Token(Token = "0x6000103")]
			[Address(RVA = "0x2A27AC0", Offset = "0x2A260C0", VA = "0x182A27AC0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x2A27AD0", Offset = "0x2A260D0", VA = "0x182A27AD0")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00002B94 File Offset: 0x00000D94
		// (set) Token: 0x06000106 RID: 262 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000068")]
		public Color ColorA
		{
			[Token(Token = "0x6000105")]
			[Address(RVA = "0x2A204E0", Offset = "0x2A1EAE0", VA = "0x182A204E0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000106")]
			[Address(RVA = "0x2A27B90", Offset = "0x2A26190", VA = "0x182A27B90")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000107 RID: 263 RVA: 0x00002BAC File Offset: 0x00000DAC
		// (set) Token: 0x06000108 RID: 264 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000069")]
		public Color ColorB
		{
			[Token(Token = "0x6000107")]
			[Address(RVA = "0x2A27930", Offset = "0x2A25F30", VA = "0x182A27930")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x6000108")]
			[Address(RVA = "0x2A27C20", Offset = "0x2A26220", VA = "0x182A27C20")]
			set
			{
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000109 RID: 265 RVA: 0x00002BC4 File Offset: 0x00000DC4
		// (set) Token: 0x0600010A RID: 266 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006A")]
		public Color ColorC
		{
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x295B880", Offset = "0x2959E80", VA = "0x18295B880")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x2A27CB0", Offset = "0x2A262B0", VA = "0x182A27CB0")]
			set
			{
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x0600010B RID: 267 RVA: 0x00002BDC File Offset: 0x00000DDC
		// (set) Token: 0x0600010C RID: 268 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700006B")]
		public Color ColorD
		{
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x2A27AC0", Offset = "0x2A260C0", VA = "0x182A27AC0")]
			get
			{
				return default(Color);
			}
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x2A27D40", Offset = "0x2A26340", VA = "0x182A27D40")]
			set
			{
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x2A27DD0", Offset = "0x2A263D0", VA = "0x182A27DD0", Slot = "11")]
		private protected override void SetAllMaterialProperties()
		{
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600010E RID: 270 RVA: 0x00002BF4 File Offset: 0x00000DF4
		[Token(Token = "0x1700006C")]
		internal override bool HasDetailLevels
		{
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600010F RID: 271 RVA: 0x00002C0C File Offset: 0x00000E0C
		[Token(Token = "0x1700006D")]
		internal override bool HasScaleModes
		{
			[Token(Token = "0x600010F")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x2A28210", Offset = "0x2A26810", VA = "0x182A28210", Slot = "15")]
		private protected override Mesh GetInitialMeshAsset()
		{
			return null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x2A28250", Offset = "0x2A26850", VA = "0x182A28250", Slot = "13")]
		private protected override Material[] GetMaterials()
		{
			return null;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002C24 File Offset: 0x00000E24
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x2A28340", Offset = "0x2A26940", VA = "0x182A28340", Slot = "10")]
		private protected override Bounds GetBounds_Internal()
		{
			return default(Bounds);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x2A284F0", Offset = "0x2A26AF0", VA = "0x182A284F0")]
		public Quad()
		{
		}

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Quad.QuadColorMode colorMode;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private Vector3 a;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Vector3 b;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private Vector3 c;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Vector3 d;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		private bool autoSetD;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0xC8")]
		[ShapesColorField(true)]
		[SerializeField]
		private Color colorB;

		// Token: 0x04000047 RID: 71
		[Token(Token = "0x4000047")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		[ShapesColorField(true)]
		private Color colorC;

		// Token: 0x04000048 RID: 72
		[Token(Token = "0x4000048")]
		[FieldOffset(Offset = "0xE8")]
		[ShapesColorField(true)]
		[SerializeField]
		private Color colorD;

		// Token: 0x0200000E RID: 14
		[Token(Token = "0x200000E")]
		public enum QuadColorMode
		{
			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			Single,
			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			Horizontal,
			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			Vertical,
			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			PerCorner
		}
	}
}
