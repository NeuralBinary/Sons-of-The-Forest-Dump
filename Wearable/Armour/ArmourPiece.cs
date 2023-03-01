using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	[CreateAssetMenu(fileName = "ArmourPiece", menuName = "Sons/Data/Wearable/Armour/ArmourPiece", order = 0)]
	public class ArmourPiece : WearablePiece
	{
		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x060025B1 RID: 9649 RVA: 0x0000B100 File Offset: 0x00009300
		[Token(Token = "0x17000511")]
		public float ArmourRating
		{
			[Token(Token = "0x60025B1")]
			[Address(RVA = "0x20480A0", Offset = "0x20470A0", VA = "0x1820480A0")]
			get
			{
				return default(float);
			}
		}

		// Token: 0x060025B2 RID: 9650 RVA: 0x0000B118 File Offset: 0x00009318
		[Token(Token = "0x60025B2")]
		[Address(RVA = "0x2D92AE0", Offset = "0x2D91AE0", VA = "0x182D92AE0")]
		public bool TryGetBlendshapeWeightsForItem(int itemId, WearableSlots slot, out List<ArmourPiece.WearableSlotBlendshapeWeights> slotBlendshapeWeights)
		{
			return default(bool);
		}

		// Token: 0x060025B3 RID: 9651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60025B3")]
		[Address(RVA = "0x2D92DC0", Offset = "0x2D91DC0", VA = "0x182D92DC0")]
		public ArmourPiece()
		{
		}

		// Token: 0x0400220B RID: 8715
		[Token(Token = "0x400220B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Min(0f)]
		private float _armourRating;

		// Token: 0x0400220C RID: 8716
		[Token(Token = "0x400220C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private List<ArmourPiece.ClothingBlendshapeWeights> _clothingBlendshapeWeights;

		// Token: 0x020005BC RID: 1468
		[Token(Token = "0x20005BC")]
		[Serializable]
		private class ClothingBlendshapeWeights
		{
			// Token: 0x060025B4 RID: 9652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B4")]
			[Address(RVA = "0x2D93240", Offset = "0x2D92240", VA = "0x182D93240")]
			public ClothingBlendshapeWeights()
			{
			}

			// Token: 0x0400220D RID: 8717
			[Token(Token = "0x400220D")]
			[FieldOffset(Offset = "0x10")]
			[ItemIdPicker(2, true)]
			public int ItemId;

			// Token: 0x0400220E RID: 8718
			[Token(Token = "0x400220E")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			public List<ArmourPiece.WearableSlotBlendshapeWeights> SlotBlendshapeWeights;
		}

		// Token: 0x020005BD RID: 1469
		[Token(Token = "0x20005BD")]
		[Serializable]
		public class WearableSlotBlendshapeWeights
		{
			// Token: 0x17000512 RID: 1298
			// (get) Token: 0x060025B5 RID: 9653 RVA: 0x0000B130 File Offset: 0x00009330
			[Token(Token = "0x17000512")]
			public WearableSlots Slot
			{
				[Token(Token = "0x60025B5")]
				[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
				get
				{
					return WearableSlots.Head;
				}
			}

			// Token: 0x17000513 RID: 1299
			// (get) Token: 0x060025B6 RID: 9654 RVA: 0x0000B148 File Offset: 0x00009348
			[Token(Token = "0x17000513")]
			public int Weight
			{
				[Token(Token = "0x60025B6")]
				[Address(RVA = "0x5D9490", Offset = "0x5D8490", VA = "0x1805D9490")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x17000514 RID: 1300
			// (get) Token: 0x060025B7 RID: 9655 RVA: 0x0000B160 File Offset: 0x00009360
			[Token(Token = "0x17000514")]
			public int BlendshapeIndex
			{
				[Token(Token = "0x60025B7")]
				[Address(RVA = "0x5D9500", Offset = "0x5D8500", VA = "0x1805D9500")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x17000515 RID: 1301
			// (get) Token: 0x060025B8 RID: 9656 RVA: 0x0000B178 File Offset: 0x00009378
			[Token(Token = "0x17000515")]
			public int SubmeshIndex
			{
				[Token(Token = "0x60025B8")]
				[Address(RVA = "0x8CDC40", Offset = "0x8CCC40", VA = "0x1808CDC40")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x060025B9 RID: 9657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60025B9")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public WearableSlotBlendshapeWeights()
			{
			}

			// Token: 0x0400220F RID: 8719
			[Token(Token = "0x400220F")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private WearableSlots _slot;

			// Token: 0x04002210 RID: 8720
			[Token(Token = "0x4002210")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			[Range(0f, 100f)]
			private int _weight;

			// Token: 0x04002211 RID: 8721
			[Token(Token = "0x4002211")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			[Min(0f)]
			private int _blendshapeIndex;

			// Token: 0x04002212 RID: 8722
			[Token(Token = "0x4002212")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			[Min(0f)]
			private int _submeshIndex;
		}
	}
}
