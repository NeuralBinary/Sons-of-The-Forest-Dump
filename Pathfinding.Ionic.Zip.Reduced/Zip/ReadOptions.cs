using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Pathfinding.Ionic.Zip
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class ReadOptions
	{
		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public ReadOptions()
		{
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000260 RID: 608 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000087")]
		public EventHandler<ReadProgressEventArgs> ReadProgress
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000262 RID: 610 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000263 RID: 611 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000088")]
		public TextWriter StatusMessageWriter
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000264 RID: 612 RVA: 0x000020B2 File Offset: 0x000002B2
		// (set) Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000089")]
		public Encoding Encoding
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000265")]
			[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
