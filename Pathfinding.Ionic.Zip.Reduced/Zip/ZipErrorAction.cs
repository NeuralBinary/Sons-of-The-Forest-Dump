using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000030 RID: 48
	[Token(Token = "0x2000030")]
	public enum ZipErrorAction
	{
		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		Throw,
		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		Skip,
		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		Retry,
		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		InvokeErrorEvent
	}
}
