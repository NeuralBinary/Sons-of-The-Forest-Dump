using System;
using Il2CppDummyDll;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	public interface IGrabsControllerInput
	{
		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000176 RID: 374
		[Token(Token = "0x1700006B")]
		bool BeginPlaceNew { [Token(Token = "0x6000176")] get; }

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000177 RID: 375
		[Token(Token = "0x1700006C")]
		bool BeginExtrudeOrStretch { [Token(Token = "0x6000177")] get; }

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000178 RID: 376
		[Token(Token = "0x1700006D")]
		bool BeginReposition { [Token(Token = "0x6000178")] get; }

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000179 RID: 377
		[Token(Token = "0x1700006E")]
		bool Cancel { [Token(Token = "0x6000179")] get; }

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600017A RID: 378
		[Token(Token = "0x1700006F")]
		bool Place { [Token(Token = "0x600017A")] get; }

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600017B RID: 379
		[Token(Token = "0x17000070")]
		bool Rotate { [Token(Token = "0x600017B")] get; }

		// Token: 0x0600017C RID: 380
		[Token(Token = "0x600017C")]
		void Refresh();

		// Token: 0x0600017D RID: 381
		[Token(Token = "0x600017D")]
		void OnControllerStateChange(GrabsController.States state);
	}
}
