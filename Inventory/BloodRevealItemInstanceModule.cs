using System;
using Il2CppDummyDll;
using Sons.Save;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005E6 RID: 1510
	[Token(Token = "0x20005E6")]
	[Serializable]
	public class BloodRevealItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x060026B8 RID: 9912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B8")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026B9")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BA")]
		[Address(RVA = "0x1D82720", Offset = "0x1D81720", VA = "0x181D82720")]
		public void SetBloodAmounts(Color channelWeights)
		{
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BB")]
		[Address(RVA = "0x2D93010", Offset = "0x2D92010", VA = "0x182D93010", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BC")]
		[Address(RVA = "0x2D93120", Offset = "0x2D92120", VA = "0x182D93120", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BD")]
		[Address(RVA = "0x2D92FE0", Offset = "0x2D91FE0", VA = "0x182D92FE0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060026BE RID: 9918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60026BE")]
		[Address(RVA = "0x2D92E40", Offset = "0x2D91E40", VA = "0x182D92E40", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060026BF RID: 9919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026BF")]
		[Address(RVA = "0x2D92F10", Offset = "0x2D91F10", VA = "0x182D92F10", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026C0")]
		[Address(RVA = "0x2D931C0", Offset = "0x2D921C0", VA = "0x182D931C0")]
		public BloodRevealItemInstanceModule()
		{
		}

		// Token: 0x04002328 RID: 9000
		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _channelWeights;

		// Token: 0x020005E7 RID: 1511
		[Token(Token = "0x20005E7")]
		[Serializable]
		public class BloodRevealSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060026C1 RID: 9921 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60026C1")]
			[Address(RVA = "0x2D931D0", Offset = "0x2D921D0", VA = "0x182D931D0")]
			public BloodRevealSaveData()
			{
			}

			// Token: 0x04002329 RID: 9001
			[Token(Token = "0x4002329")]
			[FieldOffset(Offset = "0x20")]
			public Vector4S ChannelWeights;
		}
	}
}
