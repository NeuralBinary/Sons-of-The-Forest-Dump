using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace AssemblyCSharp
{
	// Token: 0x02000361 RID: 865
	[Token(Token = "0x2000361")]
	public class Plugin
	{
		// Token: 0x17000311 RID: 785
		// (get) Token: 0x0600151F RID: 5407 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001520 RID: 5408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000311")]
		public Exception Exception
		{
			[Token(Token = "0x600151F")]
			[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001520")]
			[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001522 RID: 5410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000312")]
		public string PluginName
		{
			[Token(Token = "0x6001521")]
			[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001522")]
			[Address(RVA = "0x5A85C0", Offset = "0x5A75C0", VA = "0x1805A85C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001523")]
		[Address(RVA = "0x2CB5750", Offset = "0x2CB4750", VA = "0x182CB5750")]
		public Plugin(string fileName)
		{
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001524 RID: 5412 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x17000313")]
		public bool Loaded
		{
			[Token(Token = "0x6001524")]
			[Address(RVA = "0x5F44D0", Offset = "0x5F34D0", VA = "0x1805F44D0")]
			get
			{
				return default(bool);
			}
		}
	}
}
