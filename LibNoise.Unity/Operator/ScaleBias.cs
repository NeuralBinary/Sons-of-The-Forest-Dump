using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000019 RID: 25
	[Token(Token = "0x2000019")]
	public class ScaleBias : ModuleBase
	{
		// Token: 0x06000090 RID: 144 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x2081660", Offset = "0x207FC60", VA = "0x182081660")]
		public ScaleBias()
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x2081700", Offset = "0x207FD00", VA = "0x182081700")]
		public ScaleBias(ModuleBase input)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x20817F0", Offset = "0x207FDF0", VA = "0x1820817F0")]
		public ScaleBias(double scale, double bias, ModuleBase input)
		{
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00002504 File Offset: 0x00000704
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000020")]
		public double Bias
		{
			[Token(Token = "0x6000093")]
			[Address(RVA = "0xA44E10", Offset = "0xA43410", VA = "0x180A44E10")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000094")]
			[Address(RVA = "0xA44E20", Offset = "0xA43420", VA = "0x180A44E20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000251C File Offset: 0x0000071C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000021")]
		public double Scale
		{
			[Token(Token = "0x6000095")]
			[Address(RVA = "0x5FD5A0", Offset = "0x5FBBA0", VA = "0x1805FD5A0")]
			[CompilerGenerated]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x6000096")]
			[Address(RVA = "0x5FD5B0", Offset = "0x5FBBB0", VA = "0x1805FD5B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00002534 File Offset: 0x00000734
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x2081900", Offset = "0x207FF00", VA = "0x182081900", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
