using System;
using Il2CppDummyDll;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x0200003B RID: 59
	[Token(Token = "0x200003B")]
	[ExecuteInEditMode]
	[AddComponentMenu("NGUI/UI/NGUI Sprite")]
	public class UISprite : UIBasicSprite
	{
		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600021A RID: 538 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000090")]
		public override Material material
		{
			[Token(Token = "0x600021A")]
			[Address(RVA = "0x264BCC0", Offset = "0x264A2C0", VA = "0x18264BCC0", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600021B RID: 539 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600021C RID: 540 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000091")]
		public UIAtlas atlas
		{
			[Token(Token = "0x600021B")]
			[Address(RVA = "0x23D5250", Offset = "0x23D3850", VA = "0x1823D5250")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021C")]
			[Address(RVA = "0x264BDB0", Offset = "0x264A3B0", VA = "0x18264BDB0")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600021D RID: 541 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x0600021E RID: 542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public string spriteName
		{
			[Token(Token = "0x600021D")]
			[Address(RVA = "0xA3D160", Offset = "0xA3B760", VA = "0x180A3D160")]
			get
			{
				return null;
			}
			[Token(Token = "0x600021E")]
			[Address(RVA = "0x264C180", Offset = "0x264A780", VA = "0x18264C180")]
			set
			{
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600021F RID: 543 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x17000093")]
		public bool isValid
		{
			[Token(Token = "0x600021F")]
			[Address(RVA = "0x264C3B0", Offset = "0x264A9B0", VA = "0x18264C3B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000220 RID: 544 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x06000221 RID: 545 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000094")]
		[Obsolete("Use 'centerType' instead")]
		public bool fillCenter
		{
			[Token(Token = "0x6000220")]
			[Address(RVA = "0x264C3D0", Offset = "0x264A9D0", VA = "0x18264C3D0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000221")]
			[Address(RVA = "0x264C3E0", Offset = "0x264A9E0", VA = "0x18264C3E0")]
			set
			{
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000222 RID: 546 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x17000095")]
		public override Vector4 border
		{
			[Token(Token = "0x6000222")]
			[Address(RVA = "0x264C410", Offset = "0x264AA10", VA = "0x18264C410", Slot = "36")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000223 RID: 547 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x17000096")]
		public override float pixelSize
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0x264C4A0", Offset = "0x264AAA0", VA = "0x18264C4A0", Slot = "42")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000224 RID: 548 RVA: 0x00002F10 File Offset: 0x00001110
		[Token(Token = "0x17000097")]
		public override int minWidth
		{
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x264C590", Offset = "0x264AB90", VA = "0x18264C590", Slot = "34")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000225 RID: 549 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x17000098")]
		public override int minHeight
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0x264C6B0", Offset = "0x264ACB0", VA = "0x18264C6B0", Slot = "35")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000226 RID: 550 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x17000099")]
		public override Vector4 drawingDimensions
		{
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x264C7D0", Offset = "0x264ADD0", VA = "0x18264C7D0", Slot = "23")]
			get
			{
				return default(Vector4);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000227 RID: 551 RVA: 0x00002F58 File Offset: 0x00001158
		[Token(Token = "0x1700009A")]
		public override bool premultipliedAlpha
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x264CCE0", Offset = "0x264B2E0", VA = "0x18264CCE0", Slot = "41")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000228")]
		[Address(RVA = "0x264CDD0", Offset = "0x264B3D0", VA = "0x18264CDD0")]
		public UISpriteData GetAtlasSprite()
		{
			return null;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x264D070", Offset = "0x264B670", VA = "0x18264D070")]
		protected void SetAtlasSprite(UISpriteData sp)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x264D250", Offset = "0x264B850", VA = "0x18264D250", Slot = "33")]
		public override void MakePixelPerfect()
		{
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022B")]
		[Address(RVA = "0x264D4B0", Offset = "0x264BAB0", VA = "0x18264D4B0", Slot = "15")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022C")]
		[Address(RVA = "0x264D4E0", Offset = "0x264BAE0", VA = "0x18264D4E0", Slot = "21")]
		protected override void OnUpdate()
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022D")]
		[Address(RVA = "0x264D560", Offset = "0x264BB60", VA = "0x18264D560", Slot = "38")]
		public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
		{
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600022E")]
		[Address(RVA = "0x264DA00", Offset = "0x264C000", VA = "0x18264DA00")]
		public UISprite()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		[FieldOffset(Offset = "0x1D8")]
		[HideInInspector]
		[SerializeField]
		private UIAtlas mAtlas;

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		[FieldOffset(Offset = "0x1E0")]
		[HideInInspector]
		[SerializeField]
		private string mSpriteName;

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x1E8")]
		[HideInInspector]
		[SerializeField]
		private bool mFillCenter;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x1F0")]
		[NonSerialized]
		protected UISpriteData mSprite;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x1F8")]
		[NonSerialized]
		private bool mSpriteSet;
	}
}
