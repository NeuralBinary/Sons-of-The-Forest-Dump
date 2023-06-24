using System;
using Il2CppDummyDll;

namespace TriangleNet.Logging
{
	// Token: 0x02000064 RID: 100
	[Token(Token = "0x2000064")]
	public class LogItem : ILogItem
	{
		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002EA RID: 746 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x17000086")]
		public DateTime Time
		{
			[Token(Token = "0x60002EA")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360", Slot = "4")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x17000087")]
		public LogLevel Level
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x66F520", Offset = "0x66DB20", VA = "0x18066F520", Slot = "5")]
			get
			{
				return LogLevel.Info;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002EC RID: 748 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000088")]
		public string Message
		{
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000089")]
		public string Info
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EE")]
		[Address(RVA = "0x24DC1E0", Offset = "0x24DA7E0", VA = "0x1824DC1E0")]
		public LogItem(LogLevel level, string message)
		{
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002EF")]
		[Address(RVA = "0x24DC240", Offset = "0x24DA840", VA = "0x1824DC240")]
		public LogItem(LogLevel level, string message, string info)
		{
		}

		// Token: 0x040002F1 RID: 753
		[Token(Token = "0x40002F1")]
		[FieldOffset(Offset = "0x10")]
		private DateTime time;

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x18")]
		private LogLevel level;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x20")]
		private string message;

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x28")]
		private string info;
	}
}
