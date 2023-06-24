using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	public class CancelFunction : ICancelSource
	{
		// Token: 0x060003C2 RID: 962 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
		public CancelFunction(Func<bool> cancelF)
		{
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00003C44 File Offset: 0x00001E44
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x1F48CD0", Offset = "0x1F472D0", VA = "0x181F48CD0", Slot = "4")]
		public bool Cancelled()
		{
			return default(bool);
		}

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x10")]
		public Func<bool> CancelF;
	}
}
