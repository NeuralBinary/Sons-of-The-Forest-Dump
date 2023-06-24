using System;
using Il2CppDummyDll;
using Sons.Animation;
using Sons.Gameplay;
using Sons.Inventory;
using TMPro;
using UnityEngine;

namespace Sons.Weapon
{
	// Token: 0x020008BF RID: 2239
	[Token(Token = "0x20008BF")]
	[AddComponentMenu("Sons/Items/HoloCardItemController")]
	public class HoloCardItemController : HeldControllerBase
	{
		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x06003FF3 RID: 16371 RVA: 0x00013878 File Offset: 0x00011A78
		[Token(Token = "0x17000839")]
		public int CardId
		{
			[Token(Token = "0x6003FF3")]
			[Address(RVA = "0x8DCFC0", Offset = "0x8DB5C0", VA = "0x1808DCFC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06003FF4 RID: 16372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF4")]
		[Address(RVA = "0x35F14A0", Offset = "0x35EFAA0", VA = "0x1835F14A0", Slot = "5")]
		public override void Initialize(Animator playerAnimator, PlayerAnimatorControl playerAnimatorControl, AnimationEventReceiver playerAnimEventReceiver, Transform rootTransform, Transform baseTransform, ItemInstance itemInstance)
		{
		}

		// Token: 0x06003FF5 RID: 16373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF5")]
		[Address(RVA = "0x35F1560", Offset = "0x35EFB60", VA = "0x1835F1560")]
		public void RandomizeCard()
		{
		}

		// Token: 0x06003FF6 RID: 16374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF6")]
		[Address(RVA = "0x35F1610", Offset = "0x35EFC10", VA = "0x1835F1610")]
		public void AssignCard(int cardId)
		{
		}

		// Token: 0x06003FF7 RID: 16375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF7")]
		[Address(RVA = "0x35F1700", Offset = "0x35EFD00", VA = "0x1835F1700")]
		private void AssignCard(HoloCardsData.HoloCardData cardData)
		{
		}

		// Token: 0x06003FF8 RID: 16376 RVA: 0x00013890 File Offset: 0x00011A90
		[Token(Token = "0x6003FF8")]
		[Address(RVA = "0x35F17B0", Offset = "0x35EFDB0", VA = "0x1835F17B0", Slot = "7")]
		public override bool IsItemIdle()
		{
			return default(bool);
		}

		// Token: 0x06003FF9 RID: 16377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FF9")]
		[Address(RVA = "0x35F18D0", Offset = "0x35EFED0", VA = "0x1835F18D0")]
		public HoloCardItemController()
		{
		}

		// Token: 0x0400354F RID: 13647
		[Token(Token = "0x400354F")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private HoloCardsData _holoCards;

		// Token: 0x04003550 RID: 13648
		[Token(Token = "0x4003550")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private int _cardId;

		// Token: 0x04003551 RID: 13649
		[Token(Token = "0x4003551")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TextMeshPro _title;

		// Token: 0x04003552 RID: 13650
		[Token(Token = "0x4003552")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x04003553 RID: 13651
		[Token(Token = "0x4003553")]
		[FieldOffset(Offset = "0x88")]
		private bool _shouldRandomize;
	}
}
