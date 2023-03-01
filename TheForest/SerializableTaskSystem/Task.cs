using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000445 RID: 1093
	[Token(Token = "0x2000445")]
	[Serializable]
	public class Task : ACondition
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001BF2 RID: 7154 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF3 RID: 7155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D0")]
		public virtual ACondition _availableCondition
		{
			[Token(Token = "0x6001BF2")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "10")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF3")]
			[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270", Slot = "11")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001BF4 RID: 7156 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BF5 RID: 7157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003D1")]
		public virtual ACondition _completeCondition
		{
			[Token(Token = "0x6001BF4")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210", Slot = "12")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BF5")]
			[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250", Slot = "13")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x2CEDC60", Offset = "0x2CECC60", VA = "0x182CEDC60", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x2CEE200", Offset = "0x2CED200", VA = "0x182CEE200", Slot = "14")]
		public virtual void SetAvailable()
		{
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x2CEE030", Offset = "0x2CED030", VA = "0x182CEE030", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF9")]
		[Address(RVA = "0x2CEDE00", Offset = "0x2CECE00", VA = "0x182CEDE00", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BFA")]
		[Address(RVA = "0x2CDD8D0", Offset = "0x2CDC8D0", VA = "0x182CDD8D0")]
		public Task()
		{
		}

		// Token: 0x04001AE6 RID: 6886
		[Token(Token = "0x4001AE6")]
		[FieldOffset(Offset = "0x20")]
		public bool _available;
	}
}
