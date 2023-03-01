using System;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x02000626 RID: 1574
	[Token(Token = "0x2000626")]
	[Serializable]
	public class VisualVariantItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x06002830 RID: 10288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002830")]
		[Address(RVA = "0x2DC4380", Offset = "0x2DC3380", VA = "0x182DC4380", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x06002831 RID: 10289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002831")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x06002832 RID: 10290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002832")]
		[Address(RVA = "0x2DC52C0", Offset = "0x2DC42C0", VA = "0x182DC52C0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x06002833 RID: 10291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002833")]
		[Address(RVA = "0x2DC5080", Offset = "0x2DC4080", VA = "0x182DC5080")]
		private void ApplyVariant(VisualVariantController variantController)
		{
		}

		// Token: 0x06002834 RID: 10292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002834")]
		[Address(RVA = "0x576710", Offset = "0x575710", VA = "0x180576710")]
		public void SetVariant(uint variantNum)
		{
		}

		// Token: 0x06002835 RID: 10293 RVA: 0x0000BB98 File Offset: 0x00009D98
		[Token(Token = "0x6002835")]
		[Address(RVA = "0x576330", Offset = "0x575330", VA = "0x180576330")]
		public uint GetVariantNum()
		{
			return default(uint);
		}

		// Token: 0x06002836 RID: 10294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002836")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002837 RID: 10295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002837")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x06002838 RID: 10296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002838")]
		[Address(RVA = "0x2DC51B0", Offset = "0x2DC41B0", VA = "0x182DC51B0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002839")]
		[Address(RVA = "0x2DC5240", Offset = "0x2DC4240", VA = "0x182DC5240", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600283A")]
		[Address(RVA = "0x2D93510", Offset = "0x2D92510", VA = "0x182D93510")]
		public VisualVariantItemInstanceModule()
		{
		}

		// Token: 0x040023F7 RID: 9207
		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x20")]
		private uint _variantNum;

		// Token: 0x02000627 RID: 1575
		[Token(Token = "0x2000627")]
		[Serializable]
		public class VisualVariantSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x0600283B RID: 10299 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600283B")]
			[Address(RVA = "0x2DC2180", Offset = "0x2DC1180", VA = "0x182DC2180")]
			public VisualVariantSaveData()
			{
			}

			// Token: 0x040023F8 RID: 9208
			[Token(Token = "0x40023F8")]
			[FieldOffset(Offset = "0x20")]
			public int VariantNumber;
		}
	}
}
