using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TriangleNet.Logging;

namespace TriangleNet
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public sealed class Log : ILog<LogItem>
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000022C8 File Offset: 0x000004C8
		// (set) Token: 0x06000077 RID: 119 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000011")]
		public static bool Verbose
		{
			[Token(Token = "0x6000076")]
			[Address(RVA = "0x24864F0", Offset = "0x2484AF0", VA = "0x1824864F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000077")]
			[Address(RVA = "0x2486540", Offset = "0x2484B40", VA = "0x182486540")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000079")]
		[Address(RVA = "0x2486700", Offset = "0x2484D00", VA = "0x182486700")]
		private Log()
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600007A RID: 122 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000012")]
		public static ILog<LogItem> Instance
		{
			[Token(Token = "0x600007A")]
			[Address(RVA = "0x24867B0", Offset = "0x2484DB0", VA = "0x1824867B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007B")]
		[Address(RVA = "0x2486800", Offset = "0x2484E00", VA = "0x182486800", Slot = "4")]
		public void Add(LogItem item)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007C")]
		[Address(RVA = "0x24868A0", Offset = "0x2484EA0", VA = "0x1824868A0", Slot = "5")]
		public void Clear()
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x2486900", Offset = "0x2484F00", VA = "0x182486900", Slot = "6")]
		public void Info(string message)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x2486A00", Offset = "0x2485000", VA = "0x182486A00", Slot = "8")]
		public void Warning(string message, string location)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600007F")]
		[Address(RVA = "0x2486AE0", Offset = "0x24850E0", VA = "0x182486AE0", Slot = "7")]
		public void Error(string message, string location)
		{
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000013")]
		public IList<LogItem> Data
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x17000014")]
		public LogLevel Level
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "10")]
			get
			{
				return LogLevel.Info;
			}
		}

		// Token: 0x0400018A RID: 394
		[Token(Token = "0x400018A")]
		[FieldOffset(Offset = "0x10")]
		private List<LogItem> log;

		// Token: 0x0400018B RID: 395
		[Token(Token = "0x400018B")]
		[FieldOffset(Offset = "0x18")]
		private LogLevel level;

		// Token: 0x0400018C RID: 396
		[Token(Token = "0x400018C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly Log instance;
	}
}
