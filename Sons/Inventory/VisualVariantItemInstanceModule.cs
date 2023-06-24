using System;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x0200063D RID: 1597
	[Token(Token = "0x200063D")]
	[Serializable]
	public class VisualVariantItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x0600295C RID: 10588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295C")]
		[Address(RVA = "0x33E9DD0", Offset = "0x33E83D0", VA = "0x1833E9DD0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x0600295D RID: 10589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x0600295E RID: 10590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295E")]
		[Address(RVA = "0x33EB8B0", Offset = "0x33E9EB0", VA = "0x1833EB8B0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x0600295F RID: 10591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600295F")]
		[Address(RVA = "0x33EB9C0", Offset = "0x33E9FC0", VA = "0x1833EB9C0")]
		private void ApplyVariant(VisualVariantController variantController)
		{
		}

		// Token: 0x06002960 RID: 10592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002960")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		public void SetVariant(uint variantNum)
		{
		}

		// Token: 0x06002961 RID: 10593 RVA: 0x0000C348 File Offset: 0x0000A548
		[Token(Token = "0x6002961")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		public uint GetVariantNum()
		{
			return 0U;
		}

		// Token: 0x06002962 RID: 10594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002962")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002963 RID: 10595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002963")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002964 RID: 10596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002964")]
		[Address(RVA = "0x33EB9F0", Offset = "0x33E9FF0", VA = "0x1833EB9F0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002965 RID: 10597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002965")]
		[Address(RVA = "0x33EBA50", Offset = "0x33EA050", VA = "0x1833EBA50", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x06002966 RID: 10598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002966")]
		[Address(RVA = "0x33CE360", Offset = "0x33CC960", VA = "0x1833CE360")]
		public VisualVariantItemInstanceModule()
		{
		}

		// Token: 0x040024EE RID: 9454
		[Token(Token = "0x40024EE")]
		[FieldOffset(Offset = "0x20")]
		private uint _variantNum;

		// Token: 0x0200063E RID: 1598
		[Token(Token = "0x200063E")]
		[Serializable]
		public class VisualVariantSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x06002967 RID: 10599 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002967")]
			[Address(RVA = "0x33CE370", Offset = "0x33CC970", VA = "0x1833CE370")]
			public VisualVariantSaveData()
			{
			}

			// Token: 0x040024EF RID: 9455
			[Token(Token = "0x40024EF")]
			[FieldOffset(Offset = "0x20")]
			public int VariantNumber;
		}
	}
}
