using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Audio
{
	// Token: 0x020004CF RID: 1231
	[Token(Token = "0x20004CF")]
	public abstract class SfxInfo : MonoBehaviour
	{
		// Token: 0x06001F94 RID: 8084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F94")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		protected SfxInfo()
		{
		}

		// Token: 0x04001D1F RID: 7455
		[Token(Token = "0x4001D1F")]
		[FieldOffset(Offset = "0x20")]
		public SfxInfo.SfxTypes _sfx;

		// Token: 0x020004D0 RID: 1232
		[Token(Token = "0x20004D0")]
		public enum SfxTypes
		{
			// Token: 0x04001D21 RID: 7457
			[Token(Token = "0x4001D21")]
			None = -1,
			// Token: 0x04001D22 RID: 7458
			[Token(Token = "0x4001D22")]
			HitWood,
			// Token: 0x04001D23 RID: 7459
			[Token(Token = "0x4001D23")]
			HitBone,
			// Token: 0x04001D24 RID: 7460
			[Token(Token = "0x4001D24")]
			HitRock,
			// Token: 0x04001D25 RID: 7461
			[Token(Token = "0x4001D25")]
			OpenWoodDoor,
			// Token: 0x04001D26 RID: 7462
			[Token(Token = "0x4001D26")]
			AddItem,
			// Token: 0x04001D27 RID: 7463
			[Token(Token = "0x4001D27")]
			AddLog
		}
	}
}
