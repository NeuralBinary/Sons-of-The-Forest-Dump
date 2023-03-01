using System;
using Bolt;
using Il2CppDummyDll;

namespace TheForest.Networking
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	public class UnfreezeAfter : EntityBehaviour
	{
		// Token: 0x06001DE7 RID: 7655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE7")]
		[Address(RVA = "0x2D26010", Offset = "0x2D25010", VA = "0x182D26010")]
		private void Update()
		{
		}

		// Token: 0x06001DE8 RID: 7656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE8")]
		[Address(RVA = "0x2D25ED0", Offset = "0x2D24ED0", VA = "0x182D25ED0", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06001DE9 RID: 7657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE9")]
		[Address(RVA = "0x2D25F40", Offset = "0x2D24F40", VA = "0x182D25F40")]
		private void Unfreeze()
		{
		}

		// Token: 0x06001DEA RID: 7658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DEA")]
		[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
		public UnfreezeAfter()
		{
		}

		// Token: 0x04001C2A RID: 7210
		[Token(Token = "0x4001C2A")]
		[FieldOffset(Offset = "0x28")]
		public float _delay;

		// Token: 0x04001C2B RID: 7211
		[Token(Token = "0x4001C2B")]
		[FieldOffset(Offset = "0x2C")]
		private bool frozenOnce;
	}
}
