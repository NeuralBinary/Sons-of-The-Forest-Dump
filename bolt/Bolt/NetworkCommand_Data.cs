using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	internal abstract class NetworkCommand_Data : NetworkObj, INetworkCommandData
	{
		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C1")]
		public IProtocolToken Token
		{
			[Token(Token = "0x60003E7")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60003E8")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000C2")]
		internal Command RootCommand
		{
			[Token(Token = "0x60003E9")]
			[Address(RVA = "0x8DCD80", Offset = "0x8DB380", VA = "0x1808DCD80")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060003EA RID: 1002 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060003EB RID: 1003 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000C3")]
		private IProtocolToken Token
		{
			[Token(Token = "0x60003EA")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "5")]
			get
			{
				return null;
			}
			[Token(Token = "0x60003EB")]
			[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560", Slot = "6")]
			set
			{
			}
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60003EC")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		internal NetworkCommand_Data(NetworkObj_Meta meta)
		{
		}
	}
}
