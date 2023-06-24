using System;
using Il2CppDummyDll;
using Sons.Save;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F7 RID: 1527
	[Token(Token = "0x20005F7")]
	[Serializable]
	public class BloodRevealItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x060027C1 RID: 10177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C1")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060027C2 RID: 10178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C2")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060027C3 RID: 10179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C3")]
		[Address(RVA = "0x20C00C0", Offset = "0x20BE6C0", VA = "0x1820C00C0")]
		public void SetBloodAmounts(Color channelWeights)
		{
		}

		// Token: 0x060027C4 RID: 10180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C4")]
		[Address(RVA = "0x33CDA10", Offset = "0x33CC010", VA = "0x1833CDA10", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060027C5 RID: 10181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C5")]
		[Address(RVA = "0x33CDB90", Offset = "0x33CC190", VA = "0x1833CDB90", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C6")]
		[Address(RVA = "0x33CDCA0", Offset = "0x33CC2A0", VA = "0x1833CDCA0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027C7")]
		[Address(RVA = "0x33CDCD0", Offset = "0x33CC2D0", VA = "0x1833CDCD0", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C8")]
		[Address(RVA = "0x33CDD70", Offset = "0x33CC370", VA = "0x1833CDD70", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060027C9 RID: 10185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027C9")]
		[Address(RVA = "0x33CDE00", Offset = "0x33CC400", VA = "0x1833CDE00")]
		public BloodRevealItemInstanceModule()
		{
		}

		// Token: 0x04002406 RID: 9222
		[Token(Token = "0x4002406")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Color _channelWeights;

		// Token: 0x020005F8 RID: 1528
		[Token(Token = "0x20005F8")]
		[Serializable]
		public class BloodRevealSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060027CA RID: 10186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027CA")]
			[Address(RVA = "0x33CDE10", Offset = "0x33CC410", VA = "0x1833CDE10")]
			public BloodRevealSaveData()
			{
			}

			// Token: 0x04002407 RID: 9223
			[Token(Token = "0x4002407")]
			[FieldOffset(Offset = "0x20")]
			public Vector4S ChannelWeights;
		}
	}
}
