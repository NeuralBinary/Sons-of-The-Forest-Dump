using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	[Serializable]
	public class Task : ACondition
	{
		// Token: 0x170003DA RID: 986
		// (get) Token: 0x06001C30 RID: 7216 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C31 RID: 7217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DA")]
		public virtual ACondition _availableCondition
		{
			[Token(Token = "0x6001C30")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C31")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003DB RID: 987
		// (get) Token: 0x06001C32 RID: 7218 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001C33 RID: 7219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003DB")]
		public virtual ACondition _completeCondition
		{
			[Token(Token = "0x6001C32")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001C33")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001C34 RID: 7220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C34")]
		[Address(RVA = "0x32C1180", Offset = "0x32BF780", VA = "0x1832C1180", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C35 RID: 7221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C35")]
		[Address(RVA = "0x32C1320", Offset = "0x32BF920", VA = "0x1832C1320", Slot = "14")]
		public virtual void SetAvailable()
		{
		}

		// Token: 0x06001C36 RID: 7222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C36")]
		[Address(RVA = "0x32C1370", Offset = "0x32BF970", VA = "0x1832C1370", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C37 RID: 7223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C37")]
		[Address(RVA = "0x32C1470", Offset = "0x32BFA70", VA = "0x1832C1470", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C38 RID: 7224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C38")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public Task()
		{
		}

		// Token: 0x04001B0A RID: 6922
		[Token(Token = "0x4001B0A")]
		[FieldOffset(Offset = "0x20")]
		public bool _available;
	}
}
