using System;
using System.Collections.Generic;
using System.Threading;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	public class LightningThreadState
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x000022AC File Offset: 0x000004AC
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0xA3B670", Offset = "0xA39C70", VA = "0x180A3B670")]
		private bool UpdateMainThreadActionsOnce(bool inDestroy)
		{
			return default(bool);
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0xA3B9B0", Offset = "0xA39FB0", VA = "0x180A3B9B0")]
		private void BackgroundThreadMethod()
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0xA3BD20", Offset = "0xA3A320", VA = "0x180A3BD20")]
		public LightningThreadState()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0xA3C0F0", Offset = "0xA3A6F0", VA = "0x180A3C0F0")]
		public void TerminateAndWaitForEnd(bool inDestroy)
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0xA3C2E0", Offset = "0xA3A8E0", VA = "0x180A3C2E0")]
		public void UpdateMainThreadActions()
		{
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000022C4 File Offset: 0x000004C4
		[Token(Token = "0x60000C9")]
		[Address(RVA = "0xA3C310", Offset = "0xA3A910", VA = "0x180A3C310")]
		public bool AddActionForMainThread(Action<bool> action, bool waitForAction = false)
		{
			return default(bool);
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000022DC File Offset: 0x000004DC
		[Token(Token = "0x60000CA")]
		[Address(RVA = "0xA3C660", Offset = "0xA3AC60", VA = "0x180A3C660")]
		public bool AddActionForBackgroundThread(Action action)
		{
			return default(bool);
		}

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x10")]
		private Thread lightningThread;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x18")]
		private AutoResetEvent lightningThreadEvent;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x20")]
		private readonly Queue<Action> actionsForBackgroundThread;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x28")]
		private readonly Queue<KeyValuePair<Action<bool>, ManualResetEvent>> actionsForMainThread;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x30")]
		public bool Running;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x31")]
		private bool isTerminating;
	}
}
