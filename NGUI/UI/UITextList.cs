using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using NGUI.Interaction;
using NGUI.Internal;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000040 RID: 64
	[Token(Token = "0x2000040")]
	[AddComponentMenu("NGUI/UI/Text List")]
	public class UITextList : MonoBehaviour
	{
		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600024C RID: 588 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x170000A2")]
		protected BetterList<UITextList.Paragraph> paragraphs
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0x2650280", Offset = "0x264E880", VA = "0x182650280")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600024D RID: 589 RVA: 0x00003000 File Offset: 0x00001200
		[Token(Token = "0x170000A3")]
		public bool isValid
		{
			[Token(Token = "0x600024D")]
			[Address(RVA = "0x2650430", Offset = "0x264EA30", VA = "0x182650430")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600024E RID: 590 RVA: 0x00003018 File Offset: 0x00001218
		// (set) Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000A4")]
		public float scrollValue
		{
			[Token(Token = "0x600024E")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600024F")]
			[Address(RVA = "0x26505B0", Offset = "0x264EBB0", VA = "0x1826505B0")]
			set
			{
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00003030 File Offset: 0x00001230
		[Token(Token = "0x170000A5")]
		protected float lineHeight
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0x26506F0", Offset = "0x264ECF0", VA = "0x1826506F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000251 RID: 593 RVA: 0x00003048 File Offset: 0x00001248
		[Token(Token = "0x170000A6")]
		protected int scrollHeight
		{
			[Token(Token = "0x6000251")]
			[Address(RVA = "0x2650810", Offset = "0x264EE10", VA = "0x182650810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000252")]
		[Address(RVA = "0x2650880", Offset = "0x264EE80", VA = "0x182650880")]
		public void Clear()
		{
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0x26508D0", Offset = "0x264EED0", VA = "0x1826508D0")]
		private void Start()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0x2650BC0", Offset = "0x264F1C0", VA = "0x182650BC0")]
		private void Update()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0x2650C10", Offset = "0x264F210", VA = "0x182650C10")]
		public void OnScroll(float val)
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x2650C70", Offset = "0x264F270", VA = "0x182650C70")]
		public void OnDrag(Vector2 delta)
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0x2650CD0", Offset = "0x264F2D0", VA = "0x182650CD0")]
		private void OnScrollBar()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0x2650D60", Offset = "0x264F360", VA = "0x182650D60")]
		public void Add(string text)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0x2650D60", Offset = "0x264F360", VA = "0x182650D60")]
		protected void Add(string text, bool updateVisible)
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0x2650EA0", Offset = "0x264F4A0", VA = "0x182650EA0")]
		protected void Rebuild()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0x2651600", Offset = "0x264FC00", VA = "0x182651600")]
		protected void UpdateVisibleText()
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0x2651870", Offset = "0x264FE70", VA = "0x182651870")]
		public UITextList()
		{
		}

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x20")]
		public UILabel textLabel;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x28")]
		public UIProgressBar scrollBar;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x30")]
		public UITextList.Style style;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x34")]
		public int paragraphHistory;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x38")]
		protected char[] mSeparator;

		// Token: 0x040001DE RID: 478
		[Token(Token = "0x40001DE")]
		[FieldOffset(Offset = "0x40")]
		protected float mScroll;

		// Token: 0x040001DF RID: 479
		[Token(Token = "0x40001DF")]
		[FieldOffset(Offset = "0x44")]
		protected int mTotalLines;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x48")]
		protected int mLastWidth;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x4C")]
		protected int mLastHeight;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x50")]
		private BetterList<UITextList.Paragraph> mParagraphs;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x0")]
		private static Dictionary<string, BetterList<UITextList.Paragraph>> mHistory;

		// Token: 0x02000041 RID: 65
		[Token(Token = "0x2000041")]
		public enum Style
		{
			// Token: 0x040001E5 RID: 485
			[Token(Token = "0x40001E5")]
			Text,
			// Token: 0x040001E6 RID: 486
			[Token(Token = "0x40001E6")]
			Chat
		}

		// Token: 0x02000042 RID: 66
		[Token(Token = "0x2000042")]
		protected class Paragraph
		{
			// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public Paragraph()
			{
			}

			// Token: 0x040001E7 RID: 487
			[Token(Token = "0x40001E7")]
			[FieldOffset(Offset = "0x10")]
			public string text;

			// Token: 0x040001E8 RID: 488
			[Token(Token = "0x40001E8")]
			[FieldOffset(Offset = "0x18")]
			public string[] lines;
		}
	}
}
