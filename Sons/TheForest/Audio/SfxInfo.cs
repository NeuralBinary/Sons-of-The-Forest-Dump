using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Audio
{
	// Token: 0x020004C4 RID: 1220
	[Token(Token = "0x20004C4")]
	public abstract class SfxInfo : MonoBehaviour
	{
		// Token: 0x06001FF8 RID: 8184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FF8")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected SfxInfo()
		{
		}

		// Token: 0x04001D5B RID: 7515
		[Token(Token = "0x4001D5B")]
		[FieldOffset(Offset = "0x20")]
		public SfxInfo.SfxTypes _sfx;

		// Token: 0x020004C5 RID: 1221
		[Token(Token = "0x20004C5")]
		public enum SfxTypes
		{
			// Token: 0x04001D5D RID: 7517
			[Token(Token = "0x4001D5D")]
			None = -1,
			// Token: 0x04001D5E RID: 7518
			[Token(Token = "0x4001D5E")]
			HitWood,
			// Token: 0x04001D5F RID: 7519
			[Token(Token = "0x4001D5F")]
			HitBone,
			// Token: 0x04001D60 RID: 7520
			[Token(Token = "0x4001D60")]
			HitRock,
			// Token: 0x04001D61 RID: 7521
			[Token(Token = "0x4001D61")]
			OpenWoodDoor,
			// Token: 0x04001D62 RID: 7522
			[Token(Token = "0x4001D62")]
			AddItem,
			// Token: 0x04001D63 RID: 7523
			[Token(Token = "0x4001D63")]
			AddLog
		}
	}
}
