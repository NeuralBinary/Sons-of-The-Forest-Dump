using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000AD RID: 173
	[Token(Token = "0x20000AD")]
	public class ProgressCancel
	{
		// Token: 0x060003C4 RID: 964 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public ProgressCancel(ICancelSource source)
		{
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x1F48D00", Offset = "0x1F47300", VA = "0x181F48D00")]
		public ProgressCancel(Func<bool> cancelF)
		{
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00003C5C File Offset: 0x00001E5C
		[Token(Token = "0x60003C6")]
		[Address(RVA = "0x1F48E00", Offset = "0x1F47400", VA = "0x181F48E00")]
		public bool Cancelled()
		{
			return default(bool);
		}

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x10")]
		public ICancelSource Source;

		// Token: 0x040002B9 RID: 697
		[Token(Token = "0x40002B9")]
		[FieldOffset(Offset = "0x18")]
		private bool WasCancelled;
	}
}
