using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Sons.Gui.Credits
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public class CreditsScreen : MonoBehaviour
	{
		// Token: 0x1400000C RID: 12
		// (add) Token: 0x06000318 RID: 792 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000319 RID: 793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400000C")]
		private event Action _onCompleted
		{
			[Token(Token = "0x6000318")]
			[Address(RVA = "0x3061D40", Offset = "0x3060340", VA = "0x183061D40")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000319")]
			[Address(RVA = "0x3061E30", Offset = "0x3060430", VA = "0x183061E30")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600031A RID: 794 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031A")]
		[Address(RVA = "0x3061F20", Offset = "0x3060520", VA = "0x183061F20")]
		private void Update()
		{
		}

		// Token: 0x0600031B RID: 795 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031B")]
		[Address(RVA = "0x30620E0", Offset = "0x30606E0", VA = "0x1830620E0")]
		private void UpdateScroll()
		{
		}

		// Token: 0x0600031C RID: 796 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031C")]
		[Address(RVA = "0x30623F0", Offset = "0x30609F0", VA = "0x1830623F0")]
		private void Initialize()
		{
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031D")]
		[Address(RVA = "0x3062490", Offset = "0x3060A90", VA = "0x183062490")]
		private void CheckForClose()
		{
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031E")]
		[Address(RVA = "0x3062650", Offset = "0x3060C50", VA = "0x183062650")]
		public void DoCompleted()
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600031F")]
		[Address(RVA = "0x3061D40", Offset = "0x3060340", VA = "0x183061D40")]
		public void RegisterCompletedCallback(Action action)
		{
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000320")]
		[Address(RVA = "0x3062690", Offset = "0x3060C90", VA = "0x183062690")]
		public CreditsScreen()
		{
		}

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _scrollSpeed;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _maxOffset;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _scrollTarget;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UnityEvent _onStopScrolling;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _scrollSpeedUpMultiplier;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _scrollMaxSpeedUp;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private UnityEvent _onCompletedUnityEvent;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x48")]
		private bool _closedReceived;

		// Token: 0x04000283 RID: 643
		[Token(Token = "0x4000283")]
		[FieldOffset(Offset = "0x4C")]
		private float _offset;

		// Token: 0x04000284 RID: 644
		[Token(Token = "0x4000284")]
		[FieldOffset(Offset = "0x50")]
		private bool _initialized;

		// Token: 0x04000285 RID: 645
		[Token(Token = "0x4000285")]
		[FieldOffset(Offset = "0x51")]
		private bool _stopScrolling;

		// Token: 0x04000286 RID: 646
		[Token(Token = "0x4000286")]
		[FieldOffset(Offset = "0x54")]
		private float _stopScrollingTime;

		// Token: 0x04000287 RID: 647
		[Token(Token = "0x4000287")]
		[FieldOffset(Offset = "0x58")]
		private float _scrollSpeedMultiplier;

		// Token: 0x04000288 RID: 648
		[Token(Token = "0x4000288")]
		[FieldOffset(Offset = "0x5C")]
		private Vector3 _basePos;
	}
}
