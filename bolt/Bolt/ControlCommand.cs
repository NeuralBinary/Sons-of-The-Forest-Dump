using System;
using System.Threading;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	internal abstract class ControlCommand
	{
		// Token: 0x06000369 RID: 873 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000369")]
		[Address(RVA = "0x8D4D80", Offset = "0x8D3380", VA = "0x1808D4D80")]
		public ControlCommand()
		{
		}

		// Token: 0x0600036A RID: 874
		[Token(Token = "0x600036A")]
		public abstract void Run();

		// Token: 0x0600036B RID: 875
		[Token(Token = "0x600036B")]
		public abstract void Done();

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x10")]
		public int PendingFrames;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x14")]
		public int FinishedFrames;

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x18")]
		public ControlState State;

		// Token: 0x0400015C RID: 348
		[Token(Token = "0x400015C")]
		[FieldOffset(Offset = "0x20")]
		public ManualResetEvent FinishedEvent;
	}
}
