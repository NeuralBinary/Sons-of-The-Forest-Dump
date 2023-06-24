using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Database
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public class BacktraceDatabaseRecord
	{
		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000254 RID: 596 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000255 RID: 597 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000071")]
		internal string RecordPath
		{
			[Token(Token = "0x6000254")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000256 RID: 598 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x06000257 RID: 599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000072")]
		internal string DiagnosticDataPath
		{
			[Token(Token = "0x6000256")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000257")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000258 RID: 600 RVA: 0x00002AA4 File Offset: 0x00000CA4
		// (set) Token: 0x06000259 RID: 601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000073")]
		internal long Size
		{
			[Token(Token = "0x6000258")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6000259")]
			[Address(RVA = "0x75C1B0", Offset = "0x75A7B0", VA = "0x18075C1B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600025A RID: 602 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600025B RID: 603 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000074")]
		internal BacktraceData Record
		{
			[Token(Token = "0x600025A")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025B")]
			[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600025C RID: 604 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600025D RID: 605 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000075")]
		public ICollection<string> Attachments
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025D")]
			[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600025E RID: 606 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x0600025F RID: 607 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000076")]
		internal string DiagnosticDataJson
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600025F")]
			[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000260 RID: 608 RVA: 0x00002ABC File Offset: 0x00000CBC
		[Token(Token = "0x17000077")]
		public bool Duplicated
		{
			[Token(Token = "0x6000260")]
			[Address(RVA = "0x75C1C0", Offset = "0x75A7C0", VA = "0x18075C1C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000261 RID: 609 RVA: 0x00002AD4 File Offset: 0x00000CD4
		[Token(Token = "0x17000078")]
		public int Count
		{
			[Token(Token = "0x6000261")]
			[Address(RVA = "0x75C1D0", Offset = "0x75A7D0", VA = "0x18075C1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000262")]
		[Address(RVA = "0x75C1E0", Offset = "0x75A7E0", VA = "0x18075C1E0")]
		public string BacktraceDataJson()
		{
			return null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000079")]
		public BacktraceData BacktraceData
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0x75C320", Offset = "0x75A920", VA = "0x18075C320")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000264")]
		[Address(RVA = "0x75C340", Offset = "0x75A940", VA = "0x18075C340")]
		public string ToJson()
		{
			return null;
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000265")]
		[Address(RVA = "0x75C600", Offset = "0x75AC00", VA = "0x18075C600")]
		public static BacktraceDatabaseRecord Deserialize(string json)
		{
			return null;
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000266")]
		[Address(RVA = "0x75C790", Offset = "0x75AD90", VA = "0x18075C790")]
		private BacktraceDatabaseRecord(BacktraceDatabaseRecord.BacktraceDatabaseRawRecord rawRecord)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000267")]
		[Address(RVA = "0x75CB00", Offset = "0x75B100", VA = "0x18075CB00")]
		public BacktraceDatabaseRecord(BacktraceData data)
		{
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000268")]
		[Address(RVA = "0x75CCB0", Offset = "0x75B2B0", VA = "0x18075CCB0", Slot = "4")]
		public virtual void Increment()
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x75CCC0", Offset = "0x75B2C0", VA = "0x18075CCC0")]
		internal static BacktraceDatabaseRecord ReadFromFile(FileInfo file)
		{
			return null;
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600026A")]
		[Address(RVA = "0x75CFE0", Offset = "0x75B5E0", VA = "0x18075CFE0", Slot = "5")]
		public virtual void Unlock()
		{
		}

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0x10")]
		public Guid Id;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x20")]
		internal bool Locked;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x40")]
		public string Hash;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x60")]
		private int _count;

		// Token: 0x02000054 RID: 84
		[Token(Token = "0x2000054")]
		[Serializable]
		private struct BacktraceDatabaseRawRecord
		{
			// Token: 0x040001D2 RID: 466
			[Token(Token = "0x40001D2")]
			[FieldOffset(Offset = "0x0")]
			public string Id;

			// Token: 0x040001D3 RID: 467
			[Token(Token = "0x40001D3")]
			[FieldOffset(Offset = "0x8")]
			public string recordName;

			// Token: 0x040001D4 RID: 468
			[Token(Token = "0x40001D4")]
			[FieldOffset(Offset = "0x10")]
			public string dataPath;

			// Token: 0x040001D5 RID: 469
			[Token(Token = "0x40001D5")]
			[FieldOffset(Offset = "0x18")]
			public long size;

			// Token: 0x040001D6 RID: 470
			[Token(Token = "0x40001D6")]
			[FieldOffset(Offset = "0x20")]
			public string hash;

			// Token: 0x040001D7 RID: 471
			[Token(Token = "0x40001D7")]
			[FieldOffset(Offset = "0x28")]
			public List<string> attachments;
		}
	}
}
