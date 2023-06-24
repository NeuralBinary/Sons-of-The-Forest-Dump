using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace DigitalRuby.ThunderAndLightning
{
	// Token: 0x02000033 RID: 51
	[Token(Token = "0x2000033")]
	public class SingleLineClampAttribute : SingleLineAttribute
	{
		// Token: 0x0600012E RID: 302 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600012E")]
		[Address(RVA = "0xA44DB0", Offset = "0xA433B0", VA = "0x180A44DB0")]
		public SingleLineClampAttribute(string tooltip, double minValue, double maxValue)
		{
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600012F RID: 303 RVA: 0x000023E4 File Offset: 0x000005E4
		// (set) Token: 0x06000130 RID: 304 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002D")]
		public double MinValue
		{
			[Token(Token = "0x600012F")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000130")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000131 RID: 305 RVA: 0x000023FC File Offset: 0x000005FC
		// (set) Token: 0x06000132 RID: 306 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700002E")]
		public double MaxValue
		{
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			[CompilerGenerated]
			private set
			{
			}
		}
	}
}
