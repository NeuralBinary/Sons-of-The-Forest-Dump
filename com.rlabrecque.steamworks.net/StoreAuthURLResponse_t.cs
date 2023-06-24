using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x020000E4 RID: 228
	[Token(Token = "0x20000E4")]
	[CallbackIdentity(165)]
	public struct StoreAuthURLResponse_t
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000869 RID: 2153 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600086A RID: 2154 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000015")]
		public string m_szURL
		{
			[Token(Token = "0x6000869")]
			[Address(RVA = "0x97DC50", Offset = "0x97C250", VA = "0x18097DC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x600086A")]
			[Address(RVA = "0x97E1F0", Offset = "0x97C7F0", VA = "0x18097E1F0")]
			set
			{
			}
		}

		// Token: 0x040002B4 RID: 692
		[Token(Token = "0x40002B4")]
		public const int k_iCallback = 165;

		// Token: 0x040002B5 RID: 693
		[Token(Token = "0x40002B5")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_szURL_;
	}
}
