using System;
using Il2CppDummyDll;
using Sons.Wearable.Armour.Clothing;
using UnityEngine;

namespace Sons.Wearable.Clothing
{
	// Token: 0x020005B4 RID: 1460
	[Token(Token = "0x20005B4")]
	[AddComponentMenu("Sons/Wearable/Clothing/ClothingPieceSlotRenderableLocator")]
	public class ClothingPieceSlotRenderableLocator : MonoBehaviour
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06002588 RID: 9608 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x1700050C")]
		public ClothingPiece.ClothingSlot Slot
		{
			[Token(Token = "0x6002588")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return (ClothingPiece.ClothingSlot)0;
			}
		}

		// Token: 0x06002589 RID: 9609 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002589")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ClothingPieceSlotRenderableLocator()
		{
		}

		// Token: 0x040021F6 RID: 8694
		[Token(Token = "0x40021F6")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClothingPiece.ClothingSlot _slot;
	}
}
