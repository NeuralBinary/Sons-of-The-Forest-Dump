using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000034 RID: 52
	[Token(Token = "0x2000034")]
	[CallbackIdentity(332)]
	public struct GameServerChangeRequested_t
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000843 RID: 2115 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000844 RID: 2116 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000002")]
		public string m_rgchServer
		{
			[Token(Token = "0x6000843")]
			[Address(RVA = "0x97DC50", Offset = "0x97C250", VA = "0x18097DC50")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000844")]
			[Address(RVA = "0x97DCD0", Offset = "0x97C2D0", VA = "0x18097DCD0")]
			set
			{
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000845 RID: 2117 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x06000846 RID: 2118 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000003")]
		public string m_rgchPassword
		{
			[Token(Token = "0x6000845")]
			[Address(RVA = "0x97DCF0", Offset = "0x97C2F0", VA = "0x18097DCF0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000846")]
			[Address(RVA = "0x97DD70", Offset = "0x97C370", VA = "0x18097DD70")]
			set
			{
			}
		}

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		public const int k_iCallback = 332;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x0")]
		private byte[] m_rgchServer_;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x8")]
		private byte[] m_rgchPassword_;
	}
}
