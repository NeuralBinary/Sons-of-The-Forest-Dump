using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005CC RID: 1484
	[Token(Token = "0x20005CC")]
	[CreateAssetMenu(fileName = "ArmourPiece", menuName = "Sons/Data/Wearable/Armour/ArmourPiece", order = 0)]
	public class ArmourPiece : WearablePiece
	{
		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x060026B4 RID: 9908 RVA: 0x0000B7D8 File Offset: 0x000099D8
		[Token(Token = "0x17000525")]
		public float ArmourRating
		{
			[Token(Token = "0x60026B4")]
			[Address(RVA = "0x23BFBF0", Offset = "0x23BE1F0", VA = "0x1823BFBF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x0000B7F0 File Offset: 0x000099F0
		[Token(Token = "0x60026B5")]
		[Address(RVA = "0x33B33F0", Offset = "0x33B19F0", VA = "0x1833B33F0")]
		public bool TryGetBlendshapeWeightsForItem(int itemId, WearableSlots slot, out List<ArmourPiece.WearableSlotBlendshapeWeights> slotBlendshapeWeights)
		{
			return default(bool);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B6")]
		[Address(RVA = "0x33B3800", Offset = "0x33B1E00", VA = "0x1833B3800")]
		public ArmourPiece()
		{
		}

		// Token: 0x040022E7 RID: 8935
		[Token(Token = "0x40022E7")]
		[FieldOffset(Offset = "0x58")]
		[Min(0f)]
		[SerializeField]
		private float _armourRating;

		// Token: 0x040022E8 RID: 8936
		[Token(Token = "0x40022E8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<ArmourPiece.ClothingBlendshapeWeights> _clothingBlendshapeWeights;

		// Token: 0x020005CD RID: 1485
		[Token(Token = "0x20005CD")]
		[Serializable]
		private class ClothingBlendshapeWeights
		{
			// Token: 0x060026B7 RID: 9911 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026B7")]
			[Address(RVA = "0x33B38C0", Offset = "0x33B1EC0", VA = "0x1833B38C0")]
			public ClothingBlendshapeWeights()
			{
			}

			// Token: 0x040022E9 RID: 8937
			[Token(Token = "0x40022E9")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(Types.Clothing, true)]
			public int ItemId;

			// Token: 0x040022EA RID: 8938
			[Token(Token = "0x40022EA")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public List<ArmourPiece.WearableSlotBlendshapeWeights> SlotBlendshapeWeights;
		}

		// Token: 0x020005CE RID: 1486
		[Token(Token = "0x20005CE")]
		[Serializable]
		public class WearableSlotBlendshapeWeights
		{
			// Token: 0x17000526 RID: 1318
			// (get) Token: 0x060026B8 RID: 9912 RVA: 0x0000B808 File Offset: 0x00009A08
			[Token(Token = "0x17000526")]
			public WearableSlots Slot
			{
				[Token(Token = "0x60026B8")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				get
				{
					return WearableSlots.Head;
				}
			}

			// Token: 0x17000527 RID: 1319
			// (get) Token: 0x060026B9 RID: 9913 RVA: 0x0000B820 File Offset: 0x00009A20
			[Token(Token = "0x17000527")]
			public int Weight
			{
				[Token(Token = "0x60026B9")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000528 RID: 1320
			// (get) Token: 0x060026BA RID: 9914 RVA: 0x0000B838 File Offset: 0x00009A38
			[Token(Token = "0x17000528")]
			public int BlendshapeIndex
			{
				[Token(Token = "0x60026BA")]
				[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000529 RID: 1321
			// (get) Token: 0x060026BB RID: 9915 RVA: 0x0000B850 File Offset: 0x00009A50
			[Token(Token = "0x17000529")]
			public int SubmeshIndex
			{
				[Token(Token = "0x60026BB")]
				[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026BC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public WearableSlotBlendshapeWeights()
			{
			}

			// Token: 0x040022EB RID: 8939
			[Token(Token = "0x40022EB")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private WearableSlots _slot;

			// Token: 0x040022EC RID: 8940
			[Token(Token = "0x40022EC")]
			[FieldOffset(Offset = "0x14")]
			[Range(0f, 100f)]
			[SerializeField]
			private int _weight;

			// Token: 0x040022ED RID: 8941
			[Token(Token = "0x40022ED")]
			[FieldOffset(Offset = "0x18")]
			[Min(0f)]
			[SerializeField]
			private int _blendshapeIndex;

			// Token: 0x040022EE RID: 8942
			[Token(Token = "0x40022EE")]
			[FieldOffset(Offset = "0x1C")]
			[Min(0f)]
			[SerializeField]
			private int _submeshIndex;
		}
	}
}
