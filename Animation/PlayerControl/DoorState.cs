using System;
using Il2CppDummyDll;

namespace Sons.Animation.PlayerControl
{
	// Token: 0x020008CA RID: 2250
	[Token(Token = "0x20008CA")]
	public enum DoorState
	{
		// Token: 0x040040EE RID: 16622
		[Token(Token = "0x40040EE")]
		None = -1,
		// Token: 0x040040EF RID: 16623
		[Token(Token = "0x40040EF")]
		Closed,
		// Token: 0x040040F0 RID: 16624
		[Token(Token = "0x40040F0")]
		DenySequencePlaying,
		// Token: 0x040040F1 RID: 16625
		[Token(Token = "0x40040F1")]
		OpeningSequencePlaying,
		// Token: 0x040040F2 RID: 16626
		[Token(Token = "0x40040F2")]
		Open
	}
}
