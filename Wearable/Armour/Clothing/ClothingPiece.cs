using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Sons.Wearable.Armour.Clothing
{
	// Token: 0x020005CE RID: 1486
	[Token(Token = "0x20005CE")]
	[CreateAssetMenu(fileName = "ClothingPiece", menuName = "Sons/Data/Wearable/Clothing/ClothingPiece", order = 0)]
	public class ClothingPiece : ScriptableObject
	{
		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06002606 RID: 9734 RVA: 0x0000B3A0 File Offset: 0x000095A0
		[Token(Token = "0x17000520")]
		public int ItemId
		{
			[Token(Token = "0x6002606")]
			[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06002607 RID: 9735 RVA: 0x0000B3B8 File Offset: 0x000095B8
		[Token(Token = "0x17000521")]
		public ClothingPiece.ClothingSlot Slot
		{
			[Token(Token = "0x6002607")]
			[Address(RVA = "0x8CDC40", Offset = "0x8CCC40", VA = "0x1808CDC40")]
			get
			{
				return (ClothingPiece.ClothingSlot)0;
			}
		}

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06002608 RID: 9736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000522")]
		public AssetReference Renderable
		{
			[Token(Token = "0x6002608")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002609")]
		[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
		public ClothingPiece()
		{
		}

		// Token: 0x0400224E RID: 8782
		[Token(Token = "0x400224E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ItemIdPicker(2, false)]
		private int _itemId;

		// Token: 0x0400224F RID: 8783
		[Token(Token = "0x400224F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClothingPiece.ClothingSlot _slot;

		// Token: 0x04002250 RID: 8784
		[Token(Token = "0x4002250")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssetReference _baseRenderable;

		// Token: 0x020005CF RID: 1487
		[Token(Token = "0x20005CF")]
		[Flags]
		public enum ClothingSlot
		{
			// Token: 0x04002252 RID: 8786
			[Token(Token = "0x4002252")]
			Head = 1,
			// Token: 0x04002253 RID: 8787
			[Token(Token = "0x4002253")]
			Torso = 2,
			// Token: 0x04002254 RID: 8788
			[Token(Token = "0x4002254")]
			Legs = 4,
			// Token: 0x04002255 RID: 8789
			[Token(Token = "0x4002255")]
			Hands = 8,
			// Token: 0x04002256 RID: 8790
			[Token(Token = "0x4002256")]
			Feet = 16,
			// Token: 0x04002257 RID: 8791
			[Token(Token = "0x4002257")]
			Overcoat = 32,
			// Token: 0x04002258 RID: 8792
			[Token(Token = "0x4002258")]
			Back = 64
		}
	}
}
