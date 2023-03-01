using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000432 RID: 1074
	[Token(Token = "0x2000432")]
	[Serializable]
	public class Task : ACondition
	{
		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001BA3 RID: 7075 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BA4 RID: 7076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CA")]
		public virtual ACondition _availableCondition
		{
			[Token(Token = "0x6001BA3")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BA4")]
			[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001BA5 RID: 7077 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06001BA6 RID: 7078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170003CB")]
		public virtual ACondition _completeCondition
		{
			[Token(Token = "0x6001BA5")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6001BA6")]
			[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x2CEDAC0", Offset = "0x2CECAC0", VA = "0x182CEDAC0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x2CEE1B0", Offset = "0x2CED1B0", VA = "0x182CEE1B0", Slot = "13")]
		public virtual void SetAvailable()
		{
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x2CEDA90", Offset = "0x2CECA90", VA = "0x182CEDA90", Slot = "14")]
		public virtual void Clone(Task other)
		{
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public Task()
		{
		}

		// Token: 0x04001AC9 RID: 6857
		[Token(Token = "0x4001AC9")]
		[FieldOffset(Offset = "0x20")]
		public bool _available;
	}
}
