using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000436 RID: 1078
	[Token(Token = "0x2000436")]
	[Obsolete]
	[Serializable]
	public abstract class ACondition
	{
		// Token: 0x06001C29 RID: 7209
		[Token(Token = "0x6001C29")]
		public abstract void Init();

		// Token: 0x06001C2A RID: 7210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2A")]
		[Address(RVA = "0x32C0F70", Offset = "0x32BF570", VA = "0x1832C0F70", Slot = "5")]
		public virtual void Prepare(Action onStatusChange)
		{
		}

		// Token: 0x06001C2B RID: 7211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2B")]
		[Address(RVA = "0xFC5D60", Offset = "0xFC4360", VA = "0x180FC5D60", Slot = "6")]
		public virtual void Clear()
		{
		}

		// Token: 0x06001C2C RID: 7212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2C")]
		[Address(RVA = "0x32C1020", Offset = "0x32BF620", VA = "0x1832C1020", Slot = "7")]
		public virtual void SetDone()
		{
		}

		// Token: 0x06001C2D RID: 7213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2D")]
		[Address(RVA = "0x32C10A0", Offset = "0x32BF6A0", VA = "0x1832C10A0", Slot = "8")]
		public virtual void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C2E RID: 7214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2E")]
		[Address(RVA = "0x32C1100", Offset = "0x32BF700", VA = "0x1832C1100", Slot = "9")]
		public virtual void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C2F RID: 7215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C2F")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		protected ACondition()
		{
		}

		// Token: 0x04001B06 RID: 6918
		[Token(Token = "0x4001B06")]
		[FieldOffset(Offset = "0x10")]
		public int _id;

		// Token: 0x04001B07 RID: 6919
		[Token(Token = "0x4001B07")]
		[FieldOffset(Offset = "0x14")]
		public bool _allowInMp;

		// Token: 0x04001B08 RID: 6920
		[Token(Token = "0x4001B08")]
		[FieldOffset(Offset = "0x15")]
		public bool _done;

		// Token: 0x04001B09 RID: 6921
		[Token(Token = "0x4001B09")]
		[FieldOffset(Offset = "0x18")]
		public Action OnStatusChange;
	}
}
