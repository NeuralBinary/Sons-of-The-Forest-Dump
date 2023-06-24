using System;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000067 RID: 103
	[Token(Token = "0x2000067")]
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	public sealed class OptionAttribute : BaseAttribute
	{
		// Token: 0x060001FA RID: 506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FA")]
		[Address(RVA = "0x991C70", Offset = "0x990270", VA = "0x180991C70")]
		private OptionAttribute(string shortName, string longName)
		{
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x991F10", Offset = "0x990510", VA = "0x180991F10")]
		public OptionAttribute()
		{
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x991F60", Offset = "0x990560", VA = "0x180991F60")]
		public OptionAttribute(string longName)
		{
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x991FC0", Offset = "0x9905C0", VA = "0x180991FC0")]
		public OptionAttribute(char shortName, string longName)
		{
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x992040", Offset = "0x990640", VA = "0x180992040")]
		public OptionAttribute(char shortName)
		{
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000064")]
		public string LongName
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000065")]
		public string ShortName
		{
			[Token(Token = "0x6000200")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000201 RID: 513 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000202 RID: 514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000066")]
		public string SetName
		{
			[Token(Token = "0x6000201")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000202")]
			[Address(RVA = "0x9920D0", Offset = "0x9906D0", VA = "0x1809920D0")]
			set
			{
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000203 RID: 515 RVA: 0x00002A78 File Offset: 0x00000C78
		// (set) Token: 0x06000204 RID: 516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000067")]
		public bool FlagCounter
		{
			[Token(Token = "0x6000203")]
			[Address(RVA = "0x992180", Offset = "0x990780", VA = "0x180992180")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000204")]
			[Address(RVA = "0x7C3310", Offset = "0x7C1910", VA = "0x1807C3310")]
			set
			{
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000205 RID: 517 RVA: 0x00002A90 File Offset: 0x00000C90
		// (set) Token: 0x06000206 RID: 518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000068")]
		public char Separator
		{
			[Token(Token = "0x6000205")]
			[Address(RVA = "0x992190", Offset = "0x990790", VA = "0x180992190")]
			get
			{
				return '\0';
			}
			[Token(Token = "0x6000206")]
			[Address(RVA = "0x9921A0", Offset = "0x9907A0", VA = "0x1809921A0")]
			set
			{
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000207 RID: 519 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000208 RID: 520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000069")]
		public string Group
		{
			[Token(Token = "0x6000207")]
			[Address(RVA = "0x620F10", Offset = "0x61F510", VA = "0x180620F10")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000208")]
			[Address(RVA = "0x620F20", Offset = "0x61F520", VA = "0x180620F20")]
			set
			{
			}
		}

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x40")]
		private readonly string longName;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x48")]
		private readonly string shortName;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x50")]
		private string setName;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x58")]
		private bool flagCounter;

		// Token: 0x040000EE RID: 238
		[Token(Token = "0x40000EE")]
		[FieldOffset(Offset = "0x5A")]
		private char separator;

		// Token: 0x040000EF RID: 239
		[Token(Token = "0x40000EF")]
		[FieldOffset(Offset = "0x60")]
		private string group;
	}
}
