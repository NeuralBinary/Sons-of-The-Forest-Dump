using System;
using Il2CppDummyDll;
using Sons.Wearable.Armour.Clothing;
using UnityEngine;

namespace Sons.Wearable.Clothing
{
	// Token: 0x020005C4 RID: 1476
	[Token(Token = "0x20005C4")]
	[AddComponentMenu("Sons/Wearable/Clothing/ClothingPieceSlotRenderableLocator")]
	public class ClothingPieceSlotRenderableLocator : MonoBehaviour
	{
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002687 RID: 9863 RVA: 0x0000B6A0 File Offset: 0x000098A0
		[Token(Token = "0x17000520")]
		public ClothingPiece.ClothingSlot Slot
		{
			[Token(Token = "0x6002687")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return (ClothingPiece.ClothingSlot)0;
			}
		}

		// Token: 0x06002688 RID: 9864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002688")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ClothingPieceSlotRenderableLocator()
		{
		}

		// Token: 0x040022CB RID: 8907
		[Token(Token = "0x40022CB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ClothingPiece.ClothingSlot _slot;
	}
}
