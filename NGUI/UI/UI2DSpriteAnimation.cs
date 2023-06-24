using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NGUI.UI
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class UI2DSpriteAnimation : MonoBehaviour
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x17000009")]
		public bool isPlaying
		{
			[Token(Token = "0x600001C")]
			[Address(RVA = "0x2612650", Offset = "0x2610C50", VA = "0x182612650")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002100 File Offset: 0x00000300
		// (set) Token: 0x0600001E RID: 30 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700000A")]
		public int framesPerSecond
		{
			[Token(Token = "0x600001D")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600001E")]
			[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
			set
			{
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600001F")]
		[Address(RVA = "0x26126A0", Offset = "0x2610CA0", VA = "0x1826126A0")]
		public void Play()
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000020")]
		[Address(RVA = "0x2612770", Offset = "0x2610D70", VA = "0x182612770")]
		public void Pause()
		{
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x26127D0", Offset = "0x2610DD0", VA = "0x1826127D0")]
		public void ResetToBeginning()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x26126A0", Offset = "0x2610CA0", VA = "0x1826126A0")]
		private void Start()
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x2612810", Offset = "0x2610E10", VA = "0x182612810")]
		private void Update()
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x2612940", Offset = "0x2610F40", VA = "0x182612940")]
		private void UpdateSprite()
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x2612F80", Offset = "0x2611580", VA = "0x182612F80")]
		public UI2DSpriteAnimation()
		{
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected int framerate;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x24")]
		public bool ignoreTimeScale;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x25")]
		public bool loop;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x28")]
		public Sprite[] frames;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x30")]
		private SpriteRenderer mUnitySprite;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x38")]
		private UI2DSprite mNguiSprite;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x40")]
		private int mIndex;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x44")]
		private float mUpdate;
	}
}
