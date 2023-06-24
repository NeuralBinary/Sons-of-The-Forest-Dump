using System;
using Il2CppDummyDll;

namespace NGUI.UI
{
	// Token: 0x0200003D RID: 61
	[Token(Token = "0x200003D")]
	[Serializable]
	public class UISpriteData
	{
		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600023E RID: 574 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x170000A0")]
		public bool hasBorder
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x264E5D0", Offset = "0x264CBD0", VA = "0x18264E5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x0600023F RID: 575 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x170000A1")]
		public bool hasPadding
		{
			[Token(Token = "0x600023F")]
			[Address(RVA = "0x264E5E0", Offset = "0x264CBE0", VA = "0x18264E5E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000240")]
		[Address(RVA = "0x264E5F0", Offset = "0x264CBF0", VA = "0x18264E5F0")]
		public void SetRect(int x, int y, int width, int height)
		{
		}

		// Token: 0x06000241 RID: 577 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000241")]
		[Address(RVA = "0x264E610", Offset = "0x264CC10", VA = "0x18264E610")]
		public void SetPadding(int left, int bottom, int right, int top)
		{
		}

		// Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000242")]
		[Address(RVA = "0x264E630", Offset = "0x264CC30", VA = "0x18264E630")]
		public void SetBorder(int left, int bottom, int right, int top)
		{
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000243")]
		[Address(RVA = "0x264E650", Offset = "0x264CC50", VA = "0x18264E650")]
		public void CopyFrom(UISpriteData sd)
		{
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000244")]
		[Address(RVA = "0x264E720", Offset = "0x264CD20", VA = "0x18264E720")]
		public void CopyBorderFrom(UISpriteData sd)
		{
		}

		// Token: 0x06000245 RID: 581 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000245")]
		[Address(RVA = "0x264E750", Offset = "0x264CD50", VA = "0x18264E750")]
		public UISpriteData()
		{
		}

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x18")]
		public int x;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x1C")]
		public int y;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x20")]
		public int width;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x24")]
		public int height;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x28")]
		public int borderLeft;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0x2C")]
		public int borderRight;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0x30")]
		public int borderTop;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0x34")]
		public int borderBottom;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0x38")]
		public int paddingLeft;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0x3C")]
		public int paddingRight;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0x40")]
		public int paddingTop;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0x44")]
		public int paddingBottom;
	}
}
