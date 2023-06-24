using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000BF RID: 191
	[Token(Token = "0x20000BF")]
	[CallbackIdentity(1329)]
	public struct RemoteStoragePublishFileProgress_t
	{
		// Token: 0x04000236 RID: 566
		[Token(Token = "0x4000236")]
		public const int k_iCallback = 1329;

		// Token: 0x04000237 RID: 567
		[Token(Token = "0x4000237")]
		[FieldOffset(Offset = "0x0")]
		public double m_dPercentFile;

		// Token: 0x04000238 RID: 568
		[Token(Token = "0x4000238")]
		[FieldOffset(Offset = "0x8")]
		public bool m_bPreview;
	}
}
