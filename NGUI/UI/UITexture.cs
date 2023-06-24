using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000043 RID: 67
	[Token(Token = "0x2000043")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/NGUI Texture")]
	public class UITexture : UIBasicSprite
	{
		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600025F RID: 607 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A7")]
		public override Texture mainTexture
		{
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x2651A30", Offset = "0x2650030", VA = "0x182651A30", Slot = "26")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x2651BB0", Offset = "0x26501B0", VA = "0x182651BB0", Slot = "27")]
			set
			{
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A8")]
		public override Material material
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x2651EB0", Offset = "0x26504B0", VA = "0x182651EB0", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x2651EC0", Offset = "0x26504C0", VA = "0x182651EC0", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A9")]
		public override Shader shader
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x26520D0", Offset = "0x26506D0", VA = "0x1826520D0", Slot = "28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x26522F0", Offset = "0x26508F0", VA = "0x1826522F0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x06000265 RID: 613 RVA: 0x00003060 File Offset: 0x00001260
		[Token(Token = "0x170000AA")]
		public override bool premultipliedAlpha
		{
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x2652650", Offset = "0x2650C50", VA = "0x182652650", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00003078 File Offset: 0x00001278
		// (set) Token: 0x06000267 RID: 615 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AB")]
		public override Vector4 border
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0x2652870", Offset = "0x2650E70", VA = "0x182652870", Slot = "36")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000267")]
			[Address(RVA = "0x2652880", Offset = "0x2650E80", VA = "0x182652880", Slot = "37")]
			set
			{
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x06000268 RID: 616 RVA: 0x00003090 File Offset: 0x00001290
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AC")]
		public Rect uvRect
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0x2652910", Offset = "0x2650F10", VA = "0x182652910")]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0x2652920", Offset = "0x2650F20", VA = "0x182652920")]
			set
			{
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000030A8 File Offset: 0x000012A8
		[Token(Token = "0x170000AD")]
		public override Vector4 drawingDimensions
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0x2652990", Offset = "0x2650F90", VA = "0x182652990", Slot = "23")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x0600026B RID: 619 RVA: 0x000030C0 File Offset: 0x000012C0
		// (set) Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000AE")]
		public bool fixedAspect
		{
			[Token(Token = "0x600026B")]
			[Address(RVA = "0x2652D50", Offset = "0x2651350", VA = "0x182652D50")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600026C")]
			[Address(RVA = "0x2652D60", Offset = "0x2651360", VA = "0x182652D60")]
			set
			{
			}
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0x2652D90", Offset = "0x2651390", VA = "0x182652D90", Slot = "33")]
		public override void MakePixelPerfect()
		{
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026E")]
		[Address(RVA = "0x2652F90", Offset = "0x2651590", VA = "0x182652F90", Slot = "21")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600026F RID: 623 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026F")]
		[Address(RVA = "0x2653190", Offset = "0x2651790", VA = "0x182653190", Slot = "38")]
		public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000270")]
		[Address(RVA = "0x2653600", Offset = "0x2651C00", VA = "0x182653600")]
		public UITexture()
		{
		}

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		[SerializeField]
		private Rect mRect;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		[SerializeField]
		private Texture mTexture;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x1F0")]
		[HideInInspector]
		[SerializeField]
		private Material mMat;

		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		[FieldOffset(Offset = "0x1F8")]
		[SerializeField]
		[HideInInspector]
		private Shader mShader;

		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		[FieldOffset(Offset = "0x200")]
		[HideInInspector]
		[SerializeField]
		private Vector4 mBorder;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x210")]
		[SerializeField]
		[HideInInspector]
		private bool mFixedAspect;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x214")]
		[NonSerialized]
		private int mPMA;
	}
}
