using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000620 RID: 1568
	[Token(Token = "0x2000620")]
	[Serializable]
	public class StructureElementItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600280F RID: 10255 RVA: 0x0000BB68 File Offset: 0x00009D68
		[Token(Token = "0x1700054B")]
		public uint ElementId
		{
			[Token(Token = "0x600280F")]
			[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
			get
			{
				return default(uint);
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x06002810 RID: 10256 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700054C")]
		public int[] IngredientAmounts
		{
			[Token(Token = "0x6002810")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002811 RID: 10257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002811")]
		[Address(RVA = "0x2DC4380", Offset = "0x2DC3380", VA = "0x182DC4380", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x06002812 RID: 10258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002812")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x06002813 RID: 10259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002813")]
		[Address(RVA = "0x2DC4170", Offset = "0x2DC3170", VA = "0x182DC4170", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x06002814 RID: 10260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002814")]
		[Address(RVA = "0x2DC3EB0", Offset = "0x2DC2EB0", VA = "0x182DC3EB0")]
		private void ApplyVariant(IStructureElementVisualController elementVisualController)
		{
		}

		// Token: 0x06002815 RID: 10261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002815")]
		[Address(RVA = "0x576710", Offset = "0x575710", VA = "0x180576710")]
		public void SetElementId(uint variantNum)
		{
		}

		// Token: 0x06002816 RID: 10262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002816")]
		[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
		public void SetIngredientAmount(int[] ingredientAmounts)
		{
		}

		// Token: 0x06002817 RID: 10263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002817")]
		[Address(RVA = "0x2DC4290", Offset = "0x2DC3290", VA = "0x182DC4290", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002818 RID: 10264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002818")]
		[Address(RVA = "0x2DC40D0", Offset = "0x2DC30D0", VA = "0x182DC40D0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002819 RID: 10265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002819")]
		[Address(RVA = "0x2DC3F70", Offset = "0x2DC2F70", VA = "0x182DC3F70", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600281A RID: 10266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281A")]
		[Address(RVA = "0x2DC4010", Offset = "0x2DC3010", VA = "0x182DC4010", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x0600281B RID: 10267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600281B")]
		[Address(RVA = "0x2D93510", Offset = "0x2D92510", VA = "0x182D93510")]
		public StructureElementItemInstanceModule()
		{
		}

		// Token: 0x040023E9 RID: 9193
		[Token(Token = "0x40023E9")]
		[FieldOffset(Offset = "0x20")]
		private uint _elementId;

		// Token: 0x040023EA RID: 9194
		[Token(Token = "0x40023EA")]
		[FieldOffset(Offset = "0x28")]
		private int[] _ingredientAmounts;

		// Token: 0x02000621 RID: 1569
		[Token(Token = "0x2000621")]
		[Serializable]
		public class StructureElementSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x0600281C RID: 10268 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600281C")]
			[Address(RVA = "0x2DC43A0", Offset = "0x2DC33A0", VA = "0x182DC43A0")]
			public StructureElementSaveData()
			{
			}

			// Token: 0x040023EB RID: 9195
			[Token(Token = "0x40023EB")]
			[FieldOffset(Offset = "0x20")]
			public int ElementId;

			// Token: 0x040023EC RID: 9196
			[Token(Token = "0x40023EC")]
			[FieldOffset(Offset = "0x28")]
			public List<int> IngredientAmounts;
		}
	}
}
