using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000423 RID: 1059
	[Token(Token = "0x2000423")]
	[Serializable]
	public abstract class ACondition
	{
		// Token: 0x06001BDB RID: 7131
		[Token(Token = "0x6001BDB")]
		public abstract void Init();

		// Token: 0x06001BDC RID: 7132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDC")]
		[Address(RVA = "0x32BE4D0", Offset = "0x32BCAD0", VA = "0x1832BE4D0", Slot = "5")]
		public virtual void Prepare(Action onStatusChange)
		{
		}

		// Token: 0x06001BDD RID: 7133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDD")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC4360", VA = "0x180FC5D60", Slot = "6")]
		public virtual void Clear()
		{
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDE")]
		[Address(RVA = "0x32BE580", Offset = "0x32BCB80", VA = "0x1832BE580", Slot = "7")]
		public virtual void SetDone()
		{
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BDF")]
		[Address(RVA = "0x32BE600", Offset = "0x32BCC00", VA = "0x1832BE600", Slot = "8")]
		public virtual void Clone(ACondition other)
		{
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BE0")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		protected ACondition()
		{
		}

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x10")]
		public bool _allowInMp;

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x11")]
		public bool _done;

		// Token: 0x04001AEC RID: 6892
		[Token(Token = "0x4001AEC")]
		[FieldOffset(Offset = "0x18")]
		public Action OnStatusChange;
	}
}
