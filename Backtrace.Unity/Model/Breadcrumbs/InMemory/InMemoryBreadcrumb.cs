using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Backtrace.Unity.Model.Breadcrumbs.InMemory
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[Serializable]
	public class InMemoryBreadcrumb
	{
		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002EB RID: 747 RVA: 0x00002068 File Offset: 0x00000268
		// (set) Token: 0x060002EC RID: 748 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x1700008F")]
		public string Message
		{
			[Token(Token = "0x60002EB")]
			[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
			get
			{
				return null;
			}
			[Token(Token = "0x60002EC")]
			[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
			set
			{
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002ED RID: 749 RVA: 0x00002F9C File Offset: 0x0000119C
		// (set) Token: 0x060002EE RID: 750 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000090")]
		public double Timestamp
		{
			[Token(Token = "0x60002ED")]
			[Address(RVA = "0x761A50", Offset = "0x760050", VA = "0x180761A50")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60002EE")]
			[Address(RVA = "0x761B30", Offset = "0x760130", VA = "0x180761B30")]
			set
			{
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002EF RID: 751 RVA: 0x00002FB4 File Offset: 0x000011B4
		// (set) Token: 0x060002F0 RID: 752 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000091")]
		public BreadcrumbLevel Type
		{
			[Token(Token = "0x60002EF")]
			[Address(RVA = "0x761C90", Offset = "0x760290", VA = "0x180761C90")]
			get
			{
				return (BreadcrumbLevel)0;
			}
			[Token(Token = "0x60002F0")]
			[Address(RVA = "0x761DB0", Offset = "0x7603B0", VA = "0x180761DB0")]
			set
			{
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002F1 RID: 753 RVA: 0x00002FCC File Offset: 0x000011CC
		// (set) Token: 0x060002F2 RID: 754 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000092")]
		public UnityEngineLogLevel Level
		{
			[Token(Token = "0x60002F1")]
			[Address(RVA = "0x761FA0", Offset = "0x7605A0", VA = "0x180761FA0")]
			get
			{
				return UnityEngineLogLevel.None;
			}
			[Token(Token = "0x60002F2")]
			[Address(RVA = "0x7620C0", Offset = "0x7606C0", VA = "0x1807620C0")]
			set
			{
			}
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002F3")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public InMemoryBreadcrumb()
		{
		}

		// Token: 0x04000212 RID: 530
		[Token(Token = "0x4000212")]
		[FieldOffset(Offset = "0x10")]
		public string message;

		// Token: 0x04000213 RID: 531
		[Token(Token = "0x4000213")]
		[FieldOffset(Offset = "0x18")]
		public string timestamp;

		// Token: 0x04000214 RID: 532
		[Token(Token = "0x4000214")]
		[FieldOffset(Offset = "0x20")]
		public string type;

		// Token: 0x04000215 RID: 533
		[Token(Token = "0x4000215")]
		[FieldOffset(Offset = "0x28")]
		public string level;

		// Token: 0x04000216 RID: 534
		[Token(Token = "0x4000216")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public IDictionary<string, string> Attributes;
	}
}
