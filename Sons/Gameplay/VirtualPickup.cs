using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using PathologicalGames;
using Sons.Inventory;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007AB RID: 1963
	[Token(Token = "0x20007AB")]
	public class VirtualPickup : VirtualPickupBase
	{
		// Token: 0x060034E6 RID: 13542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034E6")]
		[Address(RVA = "0x34D49E0", Offset = "0x34D2FE0", VA = "0x1834D49E0", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x060034E7 RID: 13543 RVA: 0x0000FD80 File Offset: 0x0000DF80
		[Token(Token = "0x60034E7")]
		[Address(RVA = "0x34D4A10", Offset = "0x34D3010", VA = "0x1834D4A10", Slot = "14")]
		protected override bool ShouldBeActive()
		{
			return default(bool);
		}

		// Token: 0x060034E8 RID: 13544 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E8")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x060034E9 RID: 13545 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034E9")]
		[Address(RVA = "0x34D4B30", Offset = "0x34D3130", VA = "0x1834D4B30", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x060034EA RID: 13546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EA")]
		[Address(RVA = "0x34D4B40", Offset = "0x34D3140", VA = "0x1834D4B40")]
		private void SwitchToReal(ItemInstance itemInstance)
		{
		}

		// Token: 0x060034EB RID: 13547 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EB")]
		[Address(RVA = "0x34D4EB0", Offset = "0x34D34B0", VA = "0x1834D4EB0")]
		private void SendToPool()
		{
		}

		// Token: 0x060034EC RID: 13548 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EC")]
		[Address(RVA = "0x34D5230", Offset = "0x34D3830", VA = "0x1834D5230")]
		private void Clear()
		{
		}

		// Token: 0x060034ED RID: 13549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034ED")]
		[Address(RVA = "0x34D5310", Offset = "0x34D3910", VA = "0x1834D5310")]
		public void Setup(VirtualPickupData virtualPickupData)
		{
		}

		// Token: 0x060034EE RID: 13550 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EE")]
		[Address(RVA = "0x34D5480", Offset = "0x34D3A80", VA = "0x1834D5480")]
		private void Setup(ItemInstance itemInstance, Vector3 position, Quaternion rotation, float radius, float activeRadius, bool spawnInDynamic, bool shouldDespawn, bool usePooling, bool anyPlayerInMultiplayer, bool runtimeCreated, string nameId, [Optional] PrefabPool prefabPool)
		{
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x24F4A70", Offset = "0x24F3070", VA = "0x1824F4A70")]
		private void SetShouldDespawn(bool shouldDespawn)
		{
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x671160", Offset = "0x66F760", VA = "0x180671160")]
		private void SetSpawnInDynamic(bool spawnInDynamic)
		{
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x331E510", Offset = "0x331CB10", VA = "0x18331E510")]
		public VirtualPickup()
		{
		}

		// Token: 0x04002DAC RID: 11692
		[Token(Token = "0x4002DAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private ItemInstance _itemInstance;

		// Token: 0x04002DAD RID: 11693
		[Token(Token = "0x4002DAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private bool _spawnInDynamic;

		// Token: 0x04002DAE RID: 11694
		[Token(Token = "0x4002DAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x71")]
		private bool _shouldDespawn;

		// Token: 0x04002DAF RID: 11695
		[Token(Token = "0x4002DAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private string _nameId;

		// Token: 0x04002DB0 RID: 11696
		[Token(Token = "0x4002DB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private bool _runtimeCreated;
	}
}
