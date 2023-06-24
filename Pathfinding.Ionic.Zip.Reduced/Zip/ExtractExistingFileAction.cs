using System;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000015 RID: 21
	[Token(Token = "0x2000015")]
	public enum ExtractExistingFileAction
	{
		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		Throw,
		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		OverwriteSilently,
		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		DoNotOverwrite,
		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		InvokeExtractProgressEvent
	}
}
