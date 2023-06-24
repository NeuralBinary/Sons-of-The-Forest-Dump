using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000636 RID: 1590
	[Token(Token = "0x2000636")]
	[Serializable]
	public class StructureElementItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x17000563 RID: 1379
		// (get) Token: 0x06002937 RID: 10551 RVA: 0x0000C318 File Offset: 0x0000A518
		[Token(Token = "0x17000563")]
		public uint ElementId
		{
			[Token(Token = "0x6002937")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000564 RID: 1380
		// (get) Token: 0x06002938 RID: 10552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000564")]
		public int[] IngredientAmounts
		{
			[Token(Token = "0x6002938")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002939 RID: 10553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002939")]
		[Address(RVA = "0x33E9DD0", Offset = "0x33E83D0", VA = "0x1833E9DD0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x0600293A RID: 10554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293A")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293B")]
		[Address(RVA = "0x33E9DF0", Offset = "0x33E83F0", VA = "0x1833E9DF0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293C")]
		[Address(RVA = "0x33E9F00", Offset = "0x33E8500", VA = "0x1833E9F00")]
		private void ApplyVariant(IStructureElementVisualController elementVisualController)
		{
		}

		// Token: 0x0600293D RID: 10557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293D")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetElementId(uint variantNum)
		{
		}

		// Token: 0x0600293E RID: 10558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293E")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetIngredientAmount(int[] ingredientAmounts)
		{
		}

		// Token: 0x0600293F RID: 10559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600293F")]
		[Address(RVA = "0x33E9F60", Offset = "0x33E8560", VA = "0x1833E9F60", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002940 RID: 10560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002940")]
		[Address(RVA = "0x33EA0B0", Offset = "0x33E86B0", VA = "0x1833EA0B0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002941 RID: 10561 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002941")]
		[Address(RVA = "0x33EA1A0", Offset = "0x33E87A0", VA = "0x1833EA1A0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002942 RID: 10562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002942")]
		[Address(RVA = "0x33EA300", Offset = "0x33E8900", VA = "0x1833EA300", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x06002943 RID: 10563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002943")]
		[Address(RVA = "0x33CE360", Offset = "0x33CC960", VA = "0x1833CE360")]
		public StructureElementItemInstanceModule()
		{
		}

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x20")]
		private uint _elementId;

		// Token: 0x040024E0 RID: 9440
		[Token(Token = "0x40024E0")]
		[FieldOffset(Offset = "0x28")]
		private int[] _ingredientAmounts;

		// Token: 0x02000637 RID: 1591
		[Token(Token = "0x2000637")]
		[Serializable]
		public class StructureElementSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x06002944 RID: 10564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002944")]
			[Address(RVA = "0x33EA400", Offset = "0x33E8A00", VA = "0x1833EA400")]
			public StructureElementSaveData()
			{
			}

			// Token: 0x040024E1 RID: 9441
			[Token(Token = "0x40024E1")]
			[FieldOffset(Offset = "0x20")]
			public int ElementId;

			// Token: 0x040024E2 RID: 9442
			[Token(Token = "0x40024E2")]
			[FieldOffset(Offset = "0x28")]
			public List<int> IngredientAmounts;
		}
	}
}
