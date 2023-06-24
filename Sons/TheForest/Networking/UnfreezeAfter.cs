using System;
using Bolt;
using Il2CppDummyDll;

namespace TheForest.Networking
{
	// Token: 0x0200048D RID: 1165
	[Token(Token = "0x200048D")]
	public class UnfreezeAfter : EntityBehaviour
	{
		// Token: 0x06001E37 RID: 7735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E37")]
		[Address(RVA = "0x32EED00", Offset = "0x32ED300", VA = "0x1832EED00")]
		private void Update()
		{
		}

		// Token: 0x06001E38 RID: 7736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E38")]
		[Address(RVA = "0x32EEE70", Offset = "0x32ED470", VA = "0x1832EEE70", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06001E39 RID: 7737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E39")]
		[Address(RVA = "0x32EEEE0", Offset = "0x32ED4E0", VA = "0x1832EEEE0")]
		private void Unfreeze()
		{
		}

		// Token: 0x06001E3A RID: 7738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E3A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UnfreezeAfter()
		{
		}

		// Token: 0x04001C5A RID: 7258
		[Token(Token = "0x4001C5A")]
		[FieldOffset(Offset = "0x28")]
		public float _delay;

		// Token: 0x04001C5B RID: 7259
		[Token(Token = "0x4001C5B")]
		[FieldOffset(Offset = "0x2C")]
		private bool frozenOnce;
	}
}
