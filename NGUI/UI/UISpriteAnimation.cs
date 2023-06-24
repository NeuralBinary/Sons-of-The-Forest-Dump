using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x0200003C RID: 60
	[Token(Token = "0x200003C")]
	[AddComponentMenu("NGUI/UI/Sprite Animation")]
	[ExecuteInEditMode]
	[RequireComponent(typeof(UISprite))]
	public class UISpriteAnimation : MonoBehaviour
	{
		// Token: 0x1700009B RID: 155
		// (get) Token: 0x0600022F RID: 559 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x1700009B")]
		public int frames
		{
			[Token(Token = "0x600022F")]
			[Address(RVA = "0x264DC70", Offset = "0x264C270", VA = "0x18264DC70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000230 RID: 560 RVA: 0x00002F88 File Offset: 0x00001188
		// (set) Token: 0x06000231 RID: 561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009C")]
		public int framesPerSecond
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000231")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			set
			{
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002082 File Offset: 0x00000282
		// (set) Token: 0x06000233 RID: 563 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public string namePrefix
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000233")]
			[Address(RVA = "0x264DCB0", Offset = "0x264C2B0", VA = "0x18264DCB0")]
			set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000234 RID: 564 RVA: 0x00002FA0 File Offset: 0x000011A0
		// (set) Token: 0x06000235 RID: 565 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public bool loop
		{
			[Token(Token = "0x6000234")]
			[Address(RVA = "0x620AC0", Offset = "0x61F0C0", VA = "0x180620AC0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x620AD0", Offset = "0x61F0D0", VA = "0x180620AD0")]
			set
			{
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x1700009F")]
		public bool isPlaying
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000237")]
		[Address(RVA = "0x264DD60", Offset = "0x264C360", VA = "0x18264DD60", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000238")]
		[Address(RVA = "0x264DD70", Offset = "0x264C370", VA = "0x18264DD70", Slot = "5")]
		protected virtual void Update()
		{
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000239")]
		[Address(RVA = "0x264DF10", Offset = "0x264C510", VA = "0x18264DF10")]
		public void RebuildSpriteList()
		{
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023A")]
		[Address(RVA = "0xAC0A70", Offset = "0xABF070", VA = "0x180AC0A70")]
		public void Play()
		{
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023B")]
		[Address(RVA = "0xAC0A80", Offset = "0xABF080", VA = "0x180AC0A80")]
		public void Pause()
		{
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023C")]
		[Address(RVA = "0x264E320", Offset = "0x264C920", VA = "0x18264E320")]
		public void ResetToBeginning()
		{
		}

		// Token: 0x0600023D RID: 573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600023D")]
		[Address(RVA = "0x264E470", Offset = "0x264CA70", VA = "0x18264E470")]
		public UISpriteAnimation()
		{
		}

		// Token: 0x040001AB RID: 427
		[Token(Token = "0x40001AB")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		[SerializeField]
		protected int mFPS;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		protected string mPrefix;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		protected bool mLoop;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x31")]
		[SerializeField]
		[HideInInspector]
		protected bool mSnap;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x38")]
		protected UISprite mSprite;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x40")]
		protected float mDelta;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x44")]
		protected int mIndex;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x48")]
		protected bool mActive;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x50")]
		protected List<string> mSpriteNames;
	}
}
