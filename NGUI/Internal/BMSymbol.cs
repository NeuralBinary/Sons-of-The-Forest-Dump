using System;
using Il2CppDummyDll;
using NGUI.UI;
using UnityEngine;

namespace NGUI.Internal
{
	// Token: 0x02000065 RID: 101
	[Token(Token = "0x2000065")]
	[Serializable]
	public class BMSymbol
	{
		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00003498 File Offset: 0x00001698
		[Token(Token = "0x170000DE")]
		public int length
		{
			[Token(Token = "0x600036E")]
			[Address(RVA = "0x2662820", Offset = "0x2660E20", VA = "0x182662820")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000034B0 File Offset: 0x000016B0
		[Token(Token = "0x170000DF")]
		public int offsetX
		{
			[Token(Token = "0x600036F")]
			[Address(RVA = "0x65D0F0", Offset = "0x65B6F0", VA = "0x18065D0F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000370 RID: 880 RVA: 0x000034C8 File Offset: 0x000016C8
		[Token(Token = "0x170000E0")]
		public int offsetY
		{
			[Token(Token = "0x6000370")]
			[Address(RVA = "0x716CD0", Offset = "0x7152D0", VA = "0x180716CD0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000034E0 File Offset: 0x000016E0
		[Token(Token = "0x170000E1")]
		public int width
		{
			[Token(Token = "0x6000371")]
			[Address(RVA = "0x6E6C40", Offset = "0x6E5240", VA = "0x1806E6C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000372 RID: 882 RVA: 0x000034F8 File Offset: 0x000016F8
		[Token(Token = "0x170000E2")]
		public int height
		{
			[Token(Token = "0x6000372")]
			[Address(RVA = "0x5FDAB0", Offset = "0x5FC0B0", VA = "0x1805FDAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000373 RID: 883 RVA: 0x00003510 File Offset: 0x00001710
		[Token(Token = "0x170000E3")]
		public int advance
		{
			[Token(Token = "0x6000373")]
			[Address(RVA = "0x670F40", Offset = "0x66F540", VA = "0x180670F40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00003528 File Offset: 0x00001728
		[Token(Token = "0x170000E4")]
		public Rect uvRect
		{
			[Token(Token = "0x6000374")]
			[Address(RVA = "0x2662850", Offset = "0x2660E50", VA = "0x182662850")]
			get
			{
				return default(Rect);
			}
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000375")]
		[Address(RVA = "0x66EAE0", Offset = "0x66D0E0", VA = "0x18066EAE0")]
		public void MarkAsChanged()
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00003540 File Offset: 0x00001740
		[Token(Token = "0x6000376")]
		[Address(RVA = "0x2662860", Offset = "0x2660E60", VA = "0x182662860")]
		public bool Validate(UIAtlas atlas)
		{
			return default(bool);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000377")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public BMSymbol()
		{
		}

		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		[FieldOffset(Offset = "0x10")]
		public string sequence;

		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		[FieldOffset(Offset = "0x18")]
		public string spriteName;

		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		[FieldOffset(Offset = "0x20")]
		private UISpriteData mSprite;

		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		[FieldOffset(Offset = "0x28")]
		private bool mIsValid;

		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		[FieldOffset(Offset = "0x2C")]
		private int mLength;

		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		[FieldOffset(Offset = "0x30")]
		private int mOffsetX;

		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		[FieldOffset(Offset = "0x34")]
		private int mOffsetY;

		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		[FieldOffset(Offset = "0x38")]
		private int mWidth;

		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		[FieldOffset(Offset = "0x3C")]
		private int mHeight;

		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		[FieldOffset(Offset = "0x40")]
		private int mAdvance;

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		[FieldOffset(Offset = "0x44")]
		private Rect mUV;
	}
}
