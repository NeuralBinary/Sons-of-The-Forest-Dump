using System;
using Il2CppDummyDll;
using Sons.Utils;

namespace Sons.Gameplay
{
	// Token: 0x02000794 RID: 1940
	[Token(Token = "0x2000794")]
	public class ActiveWorldLocationDistanceDestroy : DistanceActivationBase
	{
		// Token: 0x06003439 RID: 13369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x34C7EE0", Offset = "0x34C64E0", VA = "0x1834C7EE0", Slot = "13")]
		public override string GetTaskName()
		{
			return null;
		}

		// Token: 0x0600343A RID: 13370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343A")]
		[Address(RVA = "0x34C7F10", Offset = "0x34C6510", VA = "0x1834C7F10", Slot = "16")]
		protected override void MainThreadDeactivated()
		{
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x34C7F10", Offset = "0x34C6510", VA = "0x1834C7F10")]
		private void TriggerDestroySafe()
		{
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "17")]
		protected override void MainThreadActivated()
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343D")]
		[Address(RVA = "0x331E510", Offset = "0x331CB10", VA = "0x18331E510")]
		public ActiveWorldLocationDistanceDestroy()
		{
		}
	}
}
