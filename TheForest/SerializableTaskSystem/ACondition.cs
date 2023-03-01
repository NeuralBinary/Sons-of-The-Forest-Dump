using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000444 RID: 1092
	[Token(Token = "0x2000444")]
	[Obsolete]
	[Serializable]
	public abstract class ACondition
	{
		// Token: 0x06001BEB RID: 7147
		[Token(Token = "0x6001BEB")]
		public abstract void Init();

		// Token: 0x06001BEC RID: 7148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x2CDD700", Offset = "0x2CDC700", VA = "0x182CDD700", Slot = "5")]
		public virtual void Prepare(Action onStatusChange)
		{
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0xDCE970", Offset = "0xDCD970", VA = "0x180DCE970", Slot = "6")]
		public virtual void Clear()
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x2CDD880", Offset = "0x2CDC880", VA = "0x182CDD880", Slot = "7")]
		public virtual void SetDone()
		{
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x2CDD770", Offset = "0x2CDC770", VA = "0x182CDD770", Slot = "8")]
		public virtual void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x2CDD5B0", Offset = "0x2CDC5B0", VA = "0x182CDD5B0", Slot = "9")]
		public virtual void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001BF1 RID: 7153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF1")]
		[Address(RVA = "0x2CDD8D0", Offset = "0x2CDC8D0", VA = "0x182CDD8D0")]
		protected ACondition()
		{
		}

		// Token: 0x04001AE2 RID: 6882
		[Token(Token = "0x4001AE2")]
		[FieldOffset(Offset = "0x10")]
		public int _id;

		// Token: 0x04001AE3 RID: 6883
		[Token(Token = "0x4001AE3")]
		[FieldOffset(Offset = "0x14")]
		public bool _allowInMp;

		// Token: 0x04001AE4 RID: 6884
		[Token(Token = "0x4001AE4")]
		[FieldOffset(Offset = "0x15")]
		public bool _done;

		// Token: 0x04001AE5 RID: 6885
		[Token(Token = "0x4001AE5")]
		[FieldOffset(Offset = "0x18")]
		public Action OnStatusChange;
	}
}
