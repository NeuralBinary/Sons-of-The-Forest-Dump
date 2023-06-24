using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using UdpKit;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005F9 RID: 1529
	[Token(Token = "0x20005F9")]
	[Serializable]
	public class DismemberedLimbItemInstanceModule : ItemInstanceModule
	{
		// Token: 0x060027CB RID: 10187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CB")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "6")]
		protected override void Instantiate()
		{
		}

		// Token: 0x060027CC RID: 10188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "4")]
		public override void Update()
		{
		}

		// Token: 0x060027CD RID: 10189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CD")]
		[Address(RVA = "0x33CDE90", Offset = "0x33CC490", VA = "0x1833CDE90")]
		public void OnDismember(int actorTypeId)
		{
		}

		// Token: 0x060027CE RID: 10190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CE")]
		[Address(RVA = "0x33CDEE0", Offset = "0x33CC4E0", VA = "0x1833CDEE0", Slot = "5")]
		public override void Refresh(ItemInstance itemInstance, GameObject itemObject)
		{
		}

		// Token: 0x060027CF RID: 10191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027CF")]
		[Address(RVA = "0x33CE0E0", Offset = "0x33CC6E0", VA = "0x1833CE0E0", Slot = "7")]
		public override void SetFromUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027D0 RID: 10192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D0")]
		[Address(RVA = "0x33CE1D0", Offset = "0x33CC7D0", VA = "0x1833CE1D0", Slot = "8")]
		public override void PushToUdpPacket(ref UdpPacket packet)
		{
		}

		// Token: 0x060027D1 RID: 10193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60027D1")]
		[Address(RVA = "0x33CE270", Offset = "0x33CC870", VA = "0x1833CE270", Slot = "9")]
		public override ItemInstanceModule.SaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x060027D2 RID: 10194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D2")]
		[Address(RVA = "0x33CE2E0", Offset = "0x33CC8E0", VA = "0x1833CE2E0", Slot = "10")]
		public override void LoadFromSave(ItemInstanceModule.SaveData saveData)
		{
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027D3")]
		[Address(RVA = "0x33CE360", Offset = "0x33CC960", VA = "0x1833CE360")]
		public DismemberedLimbItemInstanceModule()
		{
		}

		// Token: 0x04002408 RID: 9224
		[Token(Token = "0x4002408")]
		[FieldOffset(Offset = "0x20")]
		private GameObject _itemObject;

		// Token: 0x04002409 RID: 9225
		[Token(Token = "0x4002409")]
		[FieldOffset(Offset = "0x28")]
		private VailActorTypeId _sourceActorType;

		// Token: 0x0400240A RID: 9226
		[Token(Token = "0x400240A")]
		[FieldOffset(Offset = "0x2C")]
		private Color32 _bloodReveal;

		// Token: 0x0400240B RID: 9227
		[Token(Token = "0x400240B")]
		[FieldOffset(Offset = "0x30")]
		private bool _isFresh;

		// Token: 0x020005FA RID: 1530
		[Token(Token = "0x20005FA")]
		[Serializable]
		public class DismemberedSaveData : ItemInstanceModule.SaveData
		{
			// Token: 0x060027D4 RID: 10196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60027D4")]
			[Address(RVA = "0x33CE370", Offset = "0x33CC970", VA = "0x1833CE370")]
			public DismemberedSaveData()
			{
			}

			// Token: 0x0400240C RID: 9228
			[Token(Token = "0x400240C")]
			[FieldOffset(Offset = "0x20")]
			public int SourceActorType;
		}
	}
}
