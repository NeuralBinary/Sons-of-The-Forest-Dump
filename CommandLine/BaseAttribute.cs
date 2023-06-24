using System;
using System.Runtime.CompilerServices;
using CommandLine.Infrastructure;
using Il2CppDummyDll;

namespace CommandLine
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public abstract class BaseAttribute : Attribute
	{
		// Token: 0x06000193 RID: 403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000193")]
		[Address(RVA = "0x98F1E0", Offset = "0x98D7E0", VA = "0x18098F1E0")]
		protected internal BaseAttribute()
		{
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x06000194 RID: 404 RVA: 0x000026B8 File Offset: 0x000008B8
		// (set) Token: 0x06000195 RID: 405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004D")]
		public bool Required
		{
			[Token(Token = "0x6000194")]
			[Address(RVA = "0x5FD5C0", Offset = "0x5FBBC0", VA = "0x1805FD5C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000195")]
			[Address(RVA = "0x5FD5D0", Offset = "0x5FBBD0", VA = "0x1805FD5D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x06000196 RID: 406 RVA: 0x000026D0 File Offset: 0x000008D0
		// (set) Token: 0x06000197 RID: 407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004E")]
		public int Min
		{
			[Token(Token = "0x6000196")]
			[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000197")]
			[Address(RVA = "0x98F3A0", Offset = "0x98D9A0", VA = "0x18098F3A0")]
			set
			{
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000198 RID: 408 RVA: 0x000026E8 File Offset: 0x000008E8
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700004F")]
		public int Max
		{
			[Token(Token = "0x6000198")]
			[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000199")]
			[Address(RVA = "0x98F410", Offset = "0x98DA10", VA = "0x18098F410")]
			set
			{
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600019B RID: 411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000050")]
		public object Default
		{
			[Token(Token = "0x600019A")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019B")]
			[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
			set
			{
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000051")]
		public string HelpText
		{
			[Token(Token = "0x600019C")]
			[Address(RVA = "0x98F480", Offset = "0x98DA80", VA = "0x18098F480")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019D")]
			[Address(RVA = "0x98F4E0", Offset = "0x98DAE0", VA = "0x18098F4E0")]
			set
			{
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000052")]
		public string MetaValue
		{
			[Token(Token = "0x600019E")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x98F560", Offset = "0x98DB60", VA = "0x18098F560")]
			set
			{
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00002700 File Offset: 0x00000900
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000053")]
		public bool Hidden
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x98F610", Offset = "0x98DC10", VA = "0x18098F610")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x98F620", Offset = "0x98DC20", VA = "0x18098F620")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060001A3 RID: 419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000054")]
		public Type ResourceType
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x98F630", Offset = "0x98DC30", VA = "0x18098F630")]
			set
			{
			}
		}

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x10")]
		private int min;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x14")]
		private int max;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x18")]
		private object @default;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x20")]
		private LocalizableAttributeProperty helpText;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x28")]
		private string metaValue;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x30")]
		private Type resourceType;
	}
}
