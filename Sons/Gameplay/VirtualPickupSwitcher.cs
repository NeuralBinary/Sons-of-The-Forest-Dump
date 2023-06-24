using System;
using Il2CppDummyDll;
using PathologicalGames;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007B0 RID: 1968
	[Token(Token = "0x20007B0")]
	public class VirtualPickupSwitcher : VirtualPickupBase
	{
		// Token: 0x06003517 RID: 13591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003517")]
		[Address(RVA = "0x34D8230", Offset = "0x34D6830", VA = "0x1834D8230", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x06003518 RID: 13592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003518")]
		[Address(RVA = "0x34D8260", Offset = "0x34D6860", VA = "0x1834D8260")]
		private void OnValidate()
		{
		}

		// Token: 0x06003519 RID: 13593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003519")]
		[Address(RVA = "0x34D85C0", Offset = "0x34D6BC0", VA = "0x1834D85C0", Slot = "11")]
		protected override void OnEnable()
		{
		}

		// Token: 0x0600351A RID: 13594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600351A")]
		[Address(RVA = "0x34D87B0", Offset = "0x34D6DB0", VA = "0x1834D87B0", Slot = "12")]
		protected override void OnDisable()
		{
		}

		// Token: 0x0600351B RID: 13595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600351B")]
		[Address(RVA = "0x34D8800", Offset = "0x34D6E00", VA = "0x1834D8800", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x0600351C RID: 13596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600351C")]
		[Address(RVA = "0x34D8810", Offset = "0x34D6E10", VA = "0x1834D8810")]
		private void SwitchToVirtual(PickUp pickup)
		{
		}

		// Token: 0x0600351D RID: 13597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600351D")]
		[Address(RVA = "0x34D8D80", Offset = "0x34D7380", VA = "0x1834D8D80")]
		private VirtualPickupData GeneratePickupData()
		{
			return null;
		}

		// Token: 0x0600351E RID: 13598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600351E")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x0600351F RID: 13599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600351F")]
		[Address(RVA = "0x34D8800", Offset = "0x34D6E00", VA = "0x1834D8800")]
		public void ForceSwitch()
		{
		}

		// Token: 0x06003520 RID: 13600 RVA: 0x0000FE70 File Offset: 0x0000E070
		[Token(Token = "0x6003520")]
		[Address(RVA = "0x34D9000", Offset = "0x34D7600", VA = "0x1834D9000")]
		public int GetMaxWorldInstances()
		{
			return 0;
		}

		// Token: 0x06003521 RID: 13601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003521")]
		[Address(RVA = "0x331E510", Offset = "0x331CB10", VA = "0x18331E510")]
		public VirtualPickupSwitcher()
		{
		}

		// Token: 0x04002DCA RID: 11722
		[Token(Token = "0x4002DCA")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private PickUp _pickup;

		// Token: 0x04002DCB RID: 11723
		[Token(Token = "0x4002DCB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Transform _rootTransform;

		// Token: 0x04002DCC RID: 11724
		[Token(Token = "0x4002DCC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private bool _spawnInDynamic;

		// Token: 0x04002DCD RID: 11725
		[Token(Token = "0x4002DCD")]
		[FieldOffset(Offset = "0x79")]
		[SerializeField]
		private bool _shouldDespawn;

		// Token: 0x04002DCE RID: 11726
		[Token(Token = "0x4002DCE")]
		[FieldOffset(Offset = "0x7A")]
		[SerializeField]
		private bool _usePooling;

		// Token: 0x04002DCF RID: 11727
		[Token(Token = "0x4002DCF")]
		[FieldOffset(Offset = "0x80")]
		private PrefabPool _prefabPool;

		// Token: 0x04002DD0 RID: 11728
		[Token(Token = "0x4002DD0")]
		[FieldOffset(Offset = "0x88")]
		private bool _registeredForQueue;

		// Token: 0x04002DD1 RID: 11729
		[Token(Token = "0x4002DD1")]
		[FieldOffset(Offset = "0x90")]
		private PoolLink _poolLink;
	}
}
