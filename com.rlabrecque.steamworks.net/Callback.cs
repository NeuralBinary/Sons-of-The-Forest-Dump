using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000179 RID: 377
	[Token(Token = "0x2000179")]
	public abstract class Callback
	{
		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600088B RID: 2187
		[Token(Token = "0x17000021")]
		public abstract bool IsGameServer { [Token(Token = "0x600088B")] get; }

		// Token: 0x0600088C RID: 2188
		[Token(Token = "0x600088C")]
		internal abstract Type GetCallbackType();

		// Token: 0x0600088D RID: 2189
		[Token(Token = "0x600088D")]
		internal abstract void OnRunCallback(IntPtr pvParam);

		// Token: 0x0600088E RID: 2190
		[Token(Token = "0x600088E")]
		internal abstract void SetUnregistered();

		// Token: 0x0600088F RID: 2191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600088F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected Callback()
		{
		}
	}
}
