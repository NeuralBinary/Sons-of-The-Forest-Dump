using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Audio
{
	// Token: 0x020004CC RID: 1228
	[Token(Token = "0x20004CC")]
	public class PlayerTriggerSfx : SfxInfo
	{
		// Token: 0x06001F88 RID: 8072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F88")]
		[Address(RVA = "0x2D2D790", Offset = "0x2D2C790", VA = "0x182D2D790")]
		private void OnCollisionEnter(Collision other)
		{
		}

		// Token: 0x06001F89 RID: 8073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F89")]
		[Address(RVA = "0x2D2D920", Offset = "0x2D2C920", VA = "0x182D2D920")]
		private void Reset()
		{
		}

		// Token: 0x06001F8A RID: 8074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F8A")]
		[Address(RVA = "0x8B0B00", Offset = "0x8AFB00", VA = "0x1808B0B00")]
		public PlayerTriggerSfx()
		{
		}

		// Token: 0x04001D19 RID: 7449
		[Token(Token = "0x4001D19")]
		[FieldOffset(Offset = "0x28")]
		private int _resetDelay;

		// Token: 0x04001D1A RID: 7450
		[Token(Token = "0x4001D1A")]
		[FieldOffset(Offset = "0x2C")]
		private bool _playedEvent;
	}
}
