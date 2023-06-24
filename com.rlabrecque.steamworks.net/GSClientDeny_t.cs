using System;
using Il2CppDummyDll;

namespace Steamworks
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[CallbackIdentity(202)]
	public struct GSClientDeny_t
	{
		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x0000213E File Offset: 0x0000033E
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000006")]
		public string m_rgchOptionalText
		{
			[Token(Token = "0x600084B")]
			[Address(RVA = "0x97DBB0", Offset = "0x97C1B0", VA = "0x18097DBB0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600084C")]
			[Address(RVA = "0x97DDD0", Offset = "0x97C3D0", VA = "0x18097DDD0")]
			set
			{
			}
		}

		// Token: 0x0400006B RID: 107
		[Token(Token = "0x400006B")]
		public const int k_iCallback = 202;

		// Token: 0x0400006C RID: 108
		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x0")]
		public CSteamID m_SteamID;

		// Token: 0x0400006D RID: 109
		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x8")]
		public EDenyReason m_eDenyReason;

		// Token: 0x0400006E RID: 110
		[Token(Token = "0x400006E")]
		[FieldOffset(Offset = "0x10")]
		private byte[] m_rgchOptionalText_;
	}
}
