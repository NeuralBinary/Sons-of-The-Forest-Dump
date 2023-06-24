using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000050 RID: 80
	[Token(Token = "0x2000050")]
	internal class ControlCommandShutdown : ControlCommand
	{
		// Token: 0x0600036F RID: 879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600036F")]
		[Address(RVA = "0x8D4EA0", Offset = "0x8D34A0", VA = "0x1808D4EA0", Slot = "4")]
		public override void Run()
		{
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000370")]
		[Address(RVA = "0x8D4EF0", Offset = "0x8D34F0", VA = "0x1808D4EF0", Slot = "5")]
		public override void Done()
		{
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000371")]
		[Address(RVA = "0x8D5010", Offset = "0x8D3610", VA = "0x1808D5010")]
		public ControlCommandShutdown()
		{
		}

		// Token: 0x04000161 RID: 353
		[Token(Token = "0x4000161")]
		[FieldOffset(Offset = "0x28")]
		public List<Action> Callbacks;
	}
}
