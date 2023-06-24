using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Utils
{
	// Token: 0x020004E5 RID: 1253
	[Token(Token = "0x20004E5")]
	public class DistanceActivationEmitter : DistanceActivationBase
	{
		// Token: 0x060020EA RID: 8426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EA")]
		[Address(RVA = "0x331E740", Offset = "0x331CD40", VA = "0x18331E740")]
		private void OnValidate()
		{
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020EB")]
		[Address(RVA = "0x331E880", Offset = "0x331CE80", VA = "0x18331E880", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EC")]
		[Address(RVA = "0x331E8B0", Offset = "0x331CEB0", VA = "0x18331E8B0", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020ED")]
		[Address(RVA = "0x331E990", Offset = "0x331CF90", VA = "0x18331E990", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020EE")]
		[Address(RVA = "0x331E510", Offset = "0x331CB10", VA = "0x18331E510")]
		public DistanceActivationEmitter()
		{
		}

		// Token: 0x04001E8B RID: 7819
		[Token(Token = "0x4001E8B")]
		private const string TaskName = "DistanceActivationEmitter";

		// Token: 0x04001E8C RID: 7820
		[Token(Token = "0x4001E8C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private SonsFMODEventEmitter _emitterTarget;
	}
}
