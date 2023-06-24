using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x0200009D RID: 157
	[Token(Token = "0x200009D")]
	internal enum ExtrapolationVelocityModes
	{
		// Token: 0x0400025E RID: 606
		[Token(Token = "0x400025E")]
		CalculateFromPosition,
		// Token: 0x0400025F RID: 607
		[Token(Token = "0x400025F")]
		CopyFromRigidbody,
		// Token: 0x04000260 RID: 608
		[Token(Token = "0x4000260")]
		CopyFromRigidbody2D,
		// Token: 0x04000261 RID: 609
		[Token(Token = "0x4000261")]
		CopyFromCharacterController
	}
}
