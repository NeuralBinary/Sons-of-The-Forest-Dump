using System;
using Il2CppDummyDll;

namespace LibNoise.Operator
{
	// Token: 0x02000010 RID: 16
	[Token(Token = "0x2000010")]
	public class Displace : ModuleBase
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x2080070", Offset = "0x207E670", VA = "0x182080070")]
		public Displace()
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x2080100", Offset = "0x207E700", VA = "0x182080100")]
		public Displace(ModuleBase input, ModuleBase x, ModuleBase y, ModuleBase z)
		{
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005F RID: 95 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000060 RID: 96 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000016")]
		public ModuleBase X
		{
			[Token(Token = "0x600005F")]
			[Address(RVA = "0x20802E0", Offset = "0x207E8E0", VA = "0x1820802E0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000060")]
			[Address(RVA = "0x2080310", Offset = "0x207E910", VA = "0x182080310")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000061 RID: 97 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000062 RID: 98 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000017")]
		public ModuleBase Y
		{
			[Token(Token = "0x6000061")]
			[Address(RVA = "0x207ED80", Offset = "0x207D380", VA = "0x18207ED80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000062")]
			[Address(RVA = "0x207EDB0", Offset = "0x207D3B0", VA = "0x18207EDB0")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000064 RID: 100 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000018")]
		public ModuleBase Z
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x2080370", Offset = "0x207E970", VA = "0x182080370")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000064")]
			[Address(RVA = "0x20803A0", Offset = "0x207E9A0", VA = "0x1820803A0")]
			set
			{
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002384 File Offset: 0x00000584
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x2080400", Offset = "0x207EA00", VA = "0x182080400", Slot = "7")]
		public override double GetValue(double x, double y, double z)
		{
			return 0.0;
		}
	}
}
