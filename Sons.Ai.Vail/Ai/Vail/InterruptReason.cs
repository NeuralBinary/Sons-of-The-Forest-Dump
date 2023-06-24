using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail
{
	// Token: 0x0200008D RID: 141
	[Token(Token = "0x200008D")]
	public enum InterruptReason
	{
		// Token: 0x04000483 RID: 1155
		[Token(Token = "0x4000483")]
		Unknown,
		// Token: 0x04000484 RID: 1156
		[Token(Token = "0x4000484")]
		LostStimuli,
		// Token: 0x04000485 RID: 1157
		[Token(Token = "0x4000485")]
		TargetInvalid,
		// Token: 0x04000486 RID: 1158
		[Token(Token = "0x4000486")]
		Priority,
		// Token: 0x04000487 RID: 1159
		[Token(Token = "0x4000487")]
		Driver,
		// Token: 0x04000488 RID: 1160
		[Token(Token = "0x4000488")]
		Condition,
		// Token: 0x04000489 RID: 1161
		[Token(Token = "0x4000489")]
		ActionFailed,
		// Token: 0x0400048A RID: 1162
		[Token(Token = "0x400048A")]
		FindPathTimeout,
		// Token: 0x0400048B RID: 1163
		[Token(Token = "0x400048B")]
		FindPathFailed,
		// Token: 0x0400048C RID: 1164
		[Token(Token = "0x400048C")]
		FindPathEmpty,
		// Token: 0x0400048D RID: 1165
		[Token(Token = "0x400048D")]
		FindPathEndTooFar,
		// Token: 0x0400048E RID: 1166
		[Token(Token = "0x400048E")]
		MovementStuck,
		// Token: 0x0400048F RID: 1167
		[Token(Token = "0x400048F")]
		NoProgress,
		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		DisabledActor,
		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		Died,
		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		Critical,
		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		PlayerSleep
	}
}
