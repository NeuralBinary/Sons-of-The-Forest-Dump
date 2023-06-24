using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Audio
{
	// Token: 0x020004C1 RID: 1217
	[Token(Token = "0x20004C1")]
	public class PlayerTriggerSfx : SfxInfo
	{
		// Token: 0x06001FEC RID: 8172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEC")]
		[Address(RVA = "0x330D890", Offset = "0x330BE90", VA = "0x18330D890")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x06001FED RID: 8173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FED")]
		[Address(RVA = "0x330DA30", Offset = "0x330C030", VA = "0x18330DA30")]
		private void Reset()
		{
		}

		// Token: 0x06001FEE RID: 8174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FEE")]
		[Address(RVA = "0x9F3940", Offset = "0x9F1F40", VA = "0x1809F3940")]
		public PlayerTriggerSfx()
		{
		}

		// Token: 0x04001D55 RID: 7509
		[Token(Token = "0x4001D55")]
		[FieldOffset(Offset = "0x28")]
		private int _resetDelay;

		// Token: 0x04001D56 RID: 7510
		[Token(Token = "0x4001D56")]
		[FieldOffset(Offset = "0x2C")]
		private bool _playedEvent;
	}
}
