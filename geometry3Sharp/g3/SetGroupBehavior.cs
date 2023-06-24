using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002F3 RID: 755
	[Token(Token = "0x20002F3")]
	public struct SetGroupBehavior
	{
		// Token: 0x060019AE RID: 6574 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60019AE")]
		[Address(RVA = "0x60DE80", Offset = "0x60C480", VA = "0x18060DE80")]
		public SetGroupBehavior(SetGroupBehavior.Modes mode, int id = 0)
		{
		}

		// Token: 0x060019AF RID: 6575 RVA: 0x00012AF4 File Offset: 0x00010CF4
		[Token(Token = "0x60019AF")]
		[Address(RVA = "0x1F0ECA0", Offset = "0x1F0D2A0", VA = "0x181F0ECA0")]
		public int GetGroupID(DMesh3 mesh)
		{
			return 0;
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x060019B0 RID: 6576 RVA: 0x00012B0C File Offset: 0x00010D0C
		[Token(Token = "0x170003E1")]
		public static SetGroupBehavior Ignore
		{
			[Token(Token = "0x60019B0")]
			[Address(RVA = "0x1F0ECE0", Offset = "0x1F0D2E0", VA = "0x181F0ECE0")]
			get
			{
				return default(SetGroupBehavior);
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x060019B1 RID: 6577 RVA: 0x00012B24 File Offset: 0x00010D24
		[Token(Token = "0x170003E2")]
		public static SetGroupBehavior AutoGenerate
		{
			[Token(Token = "0x60019B1")]
			[Address(RVA = "0x1F0ECF0", Offset = "0x1F0D2F0", VA = "0x181F0ECF0")]
			get
			{
				return default(SetGroupBehavior);
			}
		}

		// Token: 0x060019B2 RID: 6578 RVA: 0x00012B3C File Offset: 0x00010D3C
		[Token(Token = "0x60019B2")]
		[Address(RVA = "0x1F0ED00", Offset = "0x1F0D300", VA = "0x181F0ED00")]
		public static SetGroupBehavior SetTo(int groupID)
		{
			return default(SetGroupBehavior);
		}

		// Token: 0x04000D66 RID: 3430
		[Token(Token = "0x4000D66")]
		[FieldOffset(Offset = "0x0")]
		private SetGroupBehavior.Modes Mode;

		// Token: 0x04000D67 RID: 3431
		[Token(Token = "0x4000D67")]
		[FieldOffset(Offset = "0x4")]
		private int SetGroupID;

		// Token: 0x020002F4 RID: 756
		[Token(Token = "0x20002F4")]
		public enum Modes
		{
			// Token: 0x04000D69 RID: 3433
			[Token(Token = "0x4000D69")]
			Ignore,
			// Token: 0x04000D6A RID: 3434
			[Token(Token = "0x4000D6A")]
			AutoGenerate,
			// Token: 0x04000D6B RID: 3435
			[Token(Token = "0x4000D6B")]
			UseConstant
		}
	}
}
