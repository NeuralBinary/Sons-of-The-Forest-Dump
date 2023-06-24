using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/NGUI Unity2D Sprite")]
	public class UI2DSprite : UIBasicSprite
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000001")]
		public Sprite sprite2D
		{
			[Token(Token = "0x600000C")]
			[Address(RVA = "0x23D5250", Offset = "0x23D3850", VA = "0x1823D5250")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000D")]
			[Address(RVA = "0x2610440", Offset = "0x260EA40", VA = "0x182610440")]
			set
			{
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000002")]
		public override Material material
		{
			[Token(Token = "0x600000E")]
			[Address(RVA = "0xA3D160", Offset = "0xA3B760", VA = "0x180A3D160", Slot = "24")]
			get
			{
				return null;
			}
			[Token(Token = "0x600000F")]
			[Address(RVA = "0x2610620", Offset = "0x260EC20", VA = "0x182610620", Slot = "25")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000011 RID: 17 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000003")]
		public override Shader shader
		{
			[Token(Token = "0x6000010")]
			[Address(RVA = "0x26107C0", Offset = "0x260EDC0", VA = "0x1826107C0", Slot = "28")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000011")]
			[Address(RVA = "0x26109E0", Offset = "0x260EFE0", VA = "0x1826109E0", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000012 RID: 18 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000004")]
		public override Texture mainTexture
		{
			[Token(Token = "0x6000012")]
			[Address(RVA = "0x2610C10", Offset = "0x260F210", VA = "0x182610C10", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000013 RID: 19 RVA: 0x00002088 File Offset: 0x00000288
		[Token(Token = "0x17000005")]
		public override bool premultipliedAlpha
		{
			[Token(Token = "0x6000013")]
			[Address(RVA = "0x2610DE0", Offset = "0x260F3E0", VA = "0x182610DE0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000014 RID: 20 RVA: 0x000020A0 File Offset: 0x000002A0
		[Token(Token = "0x17000006")]
		public override float pixelSize
		{
			[Token(Token = "0x6000014")]
			[Address(RVA = "0x2610F10", Offset = "0x260F510", VA = "0x182610F10", Slot = "42")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000015 RID: 21 RVA: 0x000020B8 File Offset: 0x000002B8
		[Token(Token = "0x17000007")]
		public override Vector4 drawingDimensions
		{
			[Token(Token = "0x6000015")]
			[Address(RVA = "0x2610F20", Offset = "0x260F520", VA = "0x182610F20", Slot = "23")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000016 RID: 22 RVA: 0x000020D0 File Offset: 0x000002D0
		// (set) Token: 0x06000017 RID: 23 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000008")]
		public override Vector4 border
		{
			[Token(Token = "0x6000016")]
			[Address(RVA = "0x26116A0", Offset = "0x260FCA0", VA = "0x1826116A0", Slot = "36")]
			get
			{
				return default(Vector4);
			}
			[Token(Token = "0x6000017")]
			[Address(RVA = "0x26116B0", Offset = "0x260FCB0", VA = "0x1826116B0", Slot = "37")]
			set
			{
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2611740", Offset = "0x260FD40", VA = "0x182611740", Slot = "21")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2611DF0", Offset = "0x26103F0", VA = "0x182611DF0", Slot = "33")]
		public override void MakePixelPerfect()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x2612040", Offset = "0x2610640", VA = "0x182612040", Slot = "38")]
		public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x2612570", Offset = "0x2610B70", VA = "0x182612570")]
		public UI2DSprite()
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		[SerializeField]
		private Sprite mSprite;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x1E0")]
		[HideInInspector]
		[SerializeField]
		private Material mMat;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		[SerializeField]
		private Shader mShader;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x1F0")]
		[HideInInspector]
		[SerializeField]
		private Vector4 mBorder;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x200")]
		[HideInInspector]
		[SerializeField]
		private bool mFixedAspect;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x204")]
		[HideInInspector]
		[SerializeField]
		private float mPixelSize;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x208")]
		public Sprite nextSprite;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x210")]
		[NonSerialized]
		private int mPMA;
	}
}
