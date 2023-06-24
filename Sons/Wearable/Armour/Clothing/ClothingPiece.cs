using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Sons.Wearable.Armour.Clothing
{
	// Token: 0x020005DF RID: 1503
	[Token(Token = "0x20005DF")]
	[CreateAssetMenu(fileName = "ClothingPiece", menuName = "Sons/Data/Wearable/Clothing/ClothingPiece", order = 0)]
	public class ClothingPiece : ScriptableObject
	{
		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x0600270F RID: 9999 RVA: 0x0000BA90 File Offset: 0x00009C90
		[Token(Token = "0x17000535")]
		public int ItemId
		{
			[Token(Token = "0x600270F")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x0000BAA8 File Offset: 0x00009CA8
		[Token(Token = "0x17000536")]
		public ClothingPiece.ClothingSlot Slot
		{
			[Token(Token = "0x6002710")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			get
			{
				return (ClothingPiece.ClothingSlot)0;
			}
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06002711 RID: 10001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000537")]
		public AssetReference Renderable
		{
			[Token(Token = "0x6002711")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002712 RID: 10002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public ClothingPiece()
		{
		}

		// Token: 0x0400232C RID: 9004
		[Token(Token = "0x400232C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[ItemIdPicker(Types.Clothing, false)]
		private int _itemId;

		// Token: 0x0400232D RID: 9005
		[Token(Token = "0x400232D")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ClothingPiece.ClothingSlot _slot;

		// Token: 0x0400232E RID: 9006
		[Token(Token = "0x400232E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AssetReference _baseRenderable;

		// Token: 0x020005E0 RID: 1504
		[Token(Token = "0x20005E0")]
		[Flags]
		public enum ClothingSlot
		{
			// Token: 0x04002330 RID: 9008
			[Token(Token = "0x4002330")]
			Head = 1,
			// Token: 0x04002331 RID: 9009
			[Token(Token = "0x4002331")]
			Torso = 2,
			// Token: 0x04002332 RID: 9010
			[Token(Token = "0x4002332")]
			Legs = 4,
			// Token: 0x04002333 RID: 9011
			[Token(Token = "0x4002333")]
			Hands = 8,
			// Token: 0x04002334 RID: 9012
			[Token(Token = "0x4002334")]
			Feet = 16,
			// Token: 0x04002335 RID: 9013
			[Token(Token = "0x4002335")]
			Overcoat = 32,
			// Token: 0x04002336 RID: 9014
			[Token(Token = "0x4002336")]
			Back = 64
		}
	}
}
