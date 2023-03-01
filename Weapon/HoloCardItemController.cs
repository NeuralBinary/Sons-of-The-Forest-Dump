using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay;
using TMPro;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x0200084F RID: 2127
	[Token(Token = "0x200084F")]
	[AddComponentMenu("Sons/Items/HoloCardItemController")]
	public class HoloCardItemController : HeldControllerBase
	{
		// Token: 0x17000715 RID: 1813
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00010AA0 File Offset: 0x0000ECA0
		[Token(Token = "0x17000715")]
		public int CardId
		{
			[Token(Token = "0x60038D9")]
			[Address(RVA = "0x9866A0", Offset = "0x9856A0", VA = "0x1809866A0")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x060038DA RID: 14554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x2ECFA30", Offset = "0x2ECEA30", VA = "0x182ECFA30", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, int itemId)
		{
		}

		// Token: 0x060038DB RID: 14555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DB")]
		[Address(RVA = "0x2ECFB40", Offset = "0x2ECEB40", VA = "0x182ECFB40")]
		public void RandomizeCard()
		{
		}

		// Token: 0x060038DC RID: 14556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DC")]
		[Address(RVA = "0x2ECF940", Offset = "0x2ECE940", VA = "0x182ECF940")]
		public void AssignCard(int cardId)
		{
		}

		// Token: 0x060038DD RID: 14557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DD")]
		[Address(RVA = "0x2ECF9C0", Offset = "0x2ECE9C0", VA = "0x182ECF9C0")]
		private void AssignCard(HoloCardsData.HoloCardData cardData)
		{
		}

		// Token: 0x060038DE RID: 14558 RVA: 0x00010AB8 File Offset: 0x0000ECB8
		[Token(Token = "0x60038DE")]
		[Address(RVA = "0x2ECFA70", Offset = "0x2ECEA70", VA = "0x182ECFA70", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x060038DF RID: 14559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60038DF")]
		[Address(RVA = "0x2ECFBD0", Offset = "0x2ECEBD0", VA = "0x182ECFBD0")]
		public HoloCardItemController()
		{
		}

		// Token: 0x04003089 RID: 12425
		[Token(Token = "0x4003089")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private HoloCardsData _holoCards;

		// Token: 0x0400308A RID: 12426
		[Token(Token = "0x400308A")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private int _cardId;

		// Token: 0x0400308B RID: 12427
		[Token(Token = "0x400308B")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TextMeshPro _title;

		// Token: 0x0400308C RID: 12428
		[Token(Token = "0x400308C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x0400308D RID: 12429
		[Token(Token = "0x400308D")]
		[FieldOffset(Offset = "0x90")]
		private bool _shouldRandomize;
	}
}
