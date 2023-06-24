using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x0200007C RID: 124
	[Token(Token = "0x200007C")]
	public abstract class UIBasicSprite : UIWidget
	{
		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00003F00 File Offset: 0x00002100
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FD")]
		public virtual UIBasicSprite.Type type
		{
			[Token(Token = "0x60004D3")]
			[Address(RVA = "0x68A5C0", Offset = "0x688BC0", VA = "0x18068A5C0", Slot = "39")]
			get
			{
				return UIBasicSprite.Type.Simple;
			}
			[Token(Token = "0x60004D4")]
			[Address(RVA = "0x268EB80", Offset = "0x268D180", VA = "0x18268EB80", Slot = "40")]
			set
			{
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00003F18 File Offset: 0x00002118
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FE")]
		public UIBasicSprite.Flip flip
		{
			[Token(Token = "0x60004D5")]
			[Address(RVA = "0x268EBA0", Offset = "0x268D1A0", VA = "0x18268EBA0")]
			get
			{
				return UIBasicSprite.Flip.Nothing;
			}
			[Token(Token = "0x60004D6")]
			[Address(RVA = "0x268EBB0", Offset = "0x268D1B0", VA = "0x18268EBB0")]
			set
			{
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00003F30 File Offset: 0x00002130
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000FF")]
		public UIBasicSprite.FillDirection fillDirection
		{
			[Token(Token = "0x60004D7")]
			[Address(RVA = "0x268EBD0", Offset = "0x268D1D0", VA = "0x18268EBD0")]
			get
			{
				return UIBasicSprite.FillDirection.Horizontal;
			}
			[Token(Token = "0x60004D8")]
			[Address(RVA = "0x268EBE0", Offset = "0x268D1E0", VA = "0x18268EBE0")]
			set
			{
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00003F48 File Offset: 0x00002148
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000100")]
		public float fillAmount
		{
			[Token(Token = "0x60004D9")]
			[Address(RVA = "0xA04050", Offset = "0xA02650", VA = "0x180A04050")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60004DA")]
			[Address(RVA = "0x268EC00", Offset = "0x268D200", VA = "0x18268EC00")]
			set
			{
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00003F60 File Offset: 0x00002160
		[Token(Token = "0x17000101")]
		public override int minWidth
		{
			[Token(Token = "0x60004DB")]
			[Address(RVA = "0x268EC40", Offset = "0x268D240", VA = "0x18268EC40", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00003F78 File Offset: 0x00002178
		[Token(Token = "0x17000102")]
		public override int minHeight
		{
			[Token(Token = "0x60004DC")]
			[Address(RVA = "0x268ED00", Offset = "0x268D300", VA = "0x18268ED00", Slot = "35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x00003F90 File Offset: 0x00002190
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000103")]
		public bool invert
		{
			[Token(Token = "0x60004DD")]
			[Address(RVA = "0x268EDC0", Offset = "0x268D3C0", VA = "0x18268EDC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60004DE")]
			[Address(RVA = "0x268EDD0", Offset = "0x268D3D0", VA = "0x18268EDD0")]
			set
			{
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x00003FA8 File Offset: 0x000021A8
		[Token(Token = "0x17000104")]
		public bool hasBorder
		{
			[Token(Token = "0x60004DF")]
			[Address(RVA = "0x268EDF0", Offset = "0x268D3F0", VA = "0x18268EDF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060004E0 RID: 1248 RVA: 0x00003FC0 File Offset: 0x000021C0
		[Token(Token = "0x17000105")]
		public virtual bool premultipliedAlpha
		{
			[Token(Token = "0x60004E0")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x00003FD8 File Offset: 0x000021D8
		[Token(Token = "0x17000106")]
		public virtual float pixelSize
		{
			[Token(Token = "0x60004E1")]
			[Address(RVA = "0x268EE60", Offset = "0x268D460", VA = "0x18268EE60", Slot = "42")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060004E2 RID: 1250 RVA: 0x00003FF0 File Offset: 0x000021F0
		[Token(Token = "0x17000107")]
		private Vector4 drawingUVs
		{
			[Token(Token = "0x60004E2")]
			[Address(RVA = "0x268EE70", Offset = "0x268D470", VA = "0x18268EE70")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x00004008 File Offset: 0x00002208
		[Token(Token = "0x17000108")]
		private Color32 drawingColor
		{
			[Token(Token = "0x60004E3")]
			[Address(RVA = "0x268EF60", Offset = "0x268D560", VA = "0x18268EF60")]
			get
			{
				return default(Color32);
			}
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x268F180", Offset = "0x268D780", VA = "0x18268F180")]
		protected void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, Rect outer, Rect inner)
		{
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x268F290", Offset = "0x268D890", VA = "0x18268F290")]
		private void SimpleFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x268F640", Offset = "0x268DC40", VA = "0x18268F640")]
		private void SlicedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x2690280", Offset = "0x268E880", VA = "0x182690280")]
		private void TiledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2690930", Offset = "0x268EF30", VA = "0x182690930")]
		private void FilledFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2691D90", Offset = "0x2690390", VA = "0x182691D90")]
		private void AdvancedFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00004020 File Offset: 0x00002220
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x26935F0", Offset = "0x2691BF0", VA = "0x1826935F0")]
		private static bool RadialCut(Vector2[] xy, Vector2[] uv, float fill, bool invert, int corner)
		{
			return default(bool);
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2693740", Offset = "0x2691D40", VA = "0x182693740")]
		private static void RadialCut(Vector2[] xy, float cos, float sin, bool invert, int corner)
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2693B90", Offset = "0x2692190", VA = "0x182693B90")]
		private static void Fill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols, float v0x, float v1x, float v0y, float v1y, float u0x, float u1x, float u0y, float u1y, Color col)
		{
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2693F40", Offset = "0x2692540", VA = "0x182693F40")]
		protected UIBasicSprite()
		{
		}

		// Token: 0x04000334 RID: 820
		[Token(Token = "0x4000334")]
		[FieldOffset(Offset = "0x190")]
		[HideInInspector]
		[SerializeField]
		protected UIBasicSprite.Type mType;

		// Token: 0x04000335 RID: 821
		[Token(Token = "0x4000335")]
		[FieldOffset(Offset = "0x194")]
		[SerializeField]
		[HideInInspector]
		protected UIBasicSprite.FillDirection mFillDirection;

		// Token: 0x04000336 RID: 822
		[Token(Token = "0x4000336")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[HideInInspector]
		[Range(0f, 1f)]
		protected float mFillAmount;

		// Token: 0x04000337 RID: 823
		[Token(Token = "0x4000337")]
		[FieldOffset(Offset = "0x19C")]
		[SerializeField]
		[HideInInspector]
		protected bool mInvert;

		// Token: 0x04000338 RID: 824
		[Token(Token = "0x4000338")]
		[FieldOffset(Offset = "0x1A0")]
		[SerializeField]
		[HideInInspector]
		protected UIBasicSprite.Flip mFlip;

		// Token: 0x04000339 RID: 825
		[Token(Token = "0x4000339")]
		[FieldOffset(Offset = "0x1A4")]
		[NonSerialized]
		private Rect mInnerUV;

		// Token: 0x0400033A RID: 826
		[Token(Token = "0x400033A")]
		[FieldOffset(Offset = "0x1B4")]
		[NonSerialized]
		private Rect mOuterUV;

		// Token: 0x0400033B RID: 827
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x1C4")]
		public UIBasicSprite.AdvancedType centerType;

		// Token: 0x0400033C RID: 828
		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x1C8")]
		public UIBasicSprite.AdvancedType leftType;

		// Token: 0x0400033D RID: 829
		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x1CC")]
		public UIBasicSprite.AdvancedType rightType;

		// Token: 0x0400033E RID: 830
		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x1D0")]
		public UIBasicSprite.AdvancedType bottomType;

		// Token: 0x0400033F RID: 831
		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x1D4")]
		public UIBasicSprite.AdvancedType topType;

		// Token: 0x04000340 RID: 832
		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x0")]
		protected static Vector2[] mTempPos;

		// Token: 0x04000341 RID: 833
		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x8")]
		protected static Vector2[] mTempUVs;

		// Token: 0x0200007D RID: 125
		[Token(Token = "0x200007D")]
		public enum Type
		{
			// Token: 0x04000343 RID: 835
			[Token(Token = "0x4000343")]
			Simple,
			// Token: 0x04000344 RID: 836
			[Token(Token = "0x4000344")]
			Sliced,
			// Token: 0x04000345 RID: 837
			[Token(Token = "0x4000345")]
			Tiled,
			// Token: 0x04000346 RID: 838
			[Token(Token = "0x4000346")]
			Filled,
			// Token: 0x04000347 RID: 839
			[Token(Token = "0x4000347")]
			Advanced
		}

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		public enum FillDirection
		{
			// Token: 0x04000349 RID: 841
			[Token(Token = "0x4000349")]
			Horizontal,
			// Token: 0x0400034A RID: 842
			[Token(Token = "0x400034A")]
			Vertical,
			// Token: 0x0400034B RID: 843
			[Token(Token = "0x400034B")]
			Radial90,
			// Token: 0x0400034C RID: 844
			[Token(Token = "0x400034C")]
			Radial180,
			// Token: 0x0400034D RID: 845
			[Token(Token = "0x400034D")]
			Radial360
		}

		// Token: 0x0200007F RID: 127
		[Token(Token = "0x200007F")]
		public enum AdvancedType
		{
			// Token: 0x0400034F RID: 847
			[Token(Token = "0x400034F")]
			Invisible,
			// Token: 0x04000350 RID: 848
			[Token(Token = "0x4000350")]
			Sliced,
			// Token: 0x04000351 RID: 849
			[Token(Token = "0x4000351")]
			Tiled
		}

		// Token: 0x02000080 RID: 128
		[Token(Token = "0x2000080")]
		public enum Flip
		{
			// Token: 0x04000353 RID: 851
			[Token(Token = "0x4000353")]
			Nothing,
			// Token: 0x04000354 RID: 852
			[Token(Token = "0x4000354")]
			Horizontally,
			// Token: 0x04000355 RID: 853
			[Token(Token = "0x4000355")]
			Vertically,
			// Token: 0x04000356 RID: 854
			[Token(Token = "0x4000356")]
			Both
		}
	}
}
