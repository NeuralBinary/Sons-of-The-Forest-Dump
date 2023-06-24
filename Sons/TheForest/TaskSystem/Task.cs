using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000424 RID: 1060
	[Token(Token = "0x2000424")]
	[Serializable]
	public class Task : ACondition
	{
		// Token: 0x170003D4 RID: 980
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BE2 RID: 7138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D4")]
		public virtual ACondition _availableCondition
		{
			[Token(Token = "0x6001BE1")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE2")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BE4 RID: 7140 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D5")]
		public virtual ACondition _completeCondition
		{
			[Token(Token = "0x6001BE3")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BE4")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BE5 RID: 7141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE5")]
		[Address(RVA = "0x32BE620", Offset = "0x32BCC20", VA = "0x1832BE620", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BE6 RID: 7142 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE6")]
		[Address(RVA = "0x32BE7C0", Offset = "0x32BCDC0", VA = "0x1832BE7C0", Slot = "13")]
		public virtual void SetAvailable()
		{
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE7")]
		[Address(RVA = "0x32BE810", Offset = "0x32BCE10", VA = "0x1832BE810", Slot = "14")]
		public virtual void Clone(Task other)
		{
		}

		// Token: 0x06001BE8 RID: 7144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE8")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public Task()
		{
		}

		// Token: 0x04001AED RID: 6893
		[Token(Token = "0x4001AED")]
		[FieldOffset(Offset = "0x20")]
		public bool _available;
	}
}
