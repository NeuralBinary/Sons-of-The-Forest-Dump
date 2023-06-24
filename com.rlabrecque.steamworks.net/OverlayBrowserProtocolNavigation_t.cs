using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000045 RID: 69
	[Token(Token = "0x2000045")]
	[CallbackIdentity(349)]
	public struct OverlayBrowserProtocolNavigation_t
	{
		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000005")]
		public string rgchURI
		{
			[Token(Token = "0x6000849")]
			[Address(RVA = "0x97DC50", Offset = "0x97C250", VA = "0x18097DC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084A")]
			[Address(RVA = "0x97DDB0", Offset = "0x97C3B0", VA = "0x18097DDB0")]
			set
			{
			}
		}

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		public const int k_iCallback = 349;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x0")]
		private byte[] rgchURI_;
	}
}
