using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000431 RID: 1073
	[Token(Token = "0x2000431")]
	[Serializable]
	public abstract class ACondition
	{
		// Token: 0x06001B9D RID: 7069
		[Token(Token = "0x6001B9D")]
		public abstract void Init();

		// Token: 0x06001B9E RID: 7070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9E")]
		[Address(RVA = "0x2CDD690", Offset = "0x2CDC690", VA = "0x182CDD690", Slot = "5")]
		public virtual void Prepare(Action onStatusChange)
		{
		}

		// Token: 0x06001B9F RID: 7071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B9F")]
		[Address(RVA = "0xDCE970", Offset = "0xDCD970", VA = "0x180DCE970", Slot = "6")]
		public virtual void Clear()
		{
		}

		// Token: 0x06001BA0 RID: 7072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA0")]
		[Address(RVA = "0x2CDD830", Offset = "0x2CDC830", VA = "0x182CDD830", Slot = "7")]
		public virtual void SetDone()
		{
		}

		// Token: 0x06001BA1 RID: 7073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA1")]
		[Address(RVA = "0x2CDD590", Offset = "0x2CDC590", VA = "0x182CDD590", Slot = "8")]
		public virtual void Clone(ACondition other)
		{
		}

		// Token: 0x06001BA2 RID: 7074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA2")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		protected ACondition()
		{
		}

		// Token: 0x04001AC6 RID: 6854
		[Token(Token = "0x4001AC6")]
		[FieldOffset(Offset = "0x10")]
		public bool _allowInMp;

		// Token: 0x04001AC7 RID: 6855
		[Token(Token = "0x4001AC7")]
		[FieldOffset(Offset = "0x11")]
		public bool _done;

		// Token: 0x04001AC8 RID: 6856
		[Token(Token = "0x4001AC8")]
		[FieldOffset(Offset = "0x18")]
		public Action OnStatusChange;
	}
}
