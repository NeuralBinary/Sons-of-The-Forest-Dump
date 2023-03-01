using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	[Serializable]
	public class ListAllCondition : ACondition
	{
		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D2")]
		public virtual ACondition[] Conditions
		{
			[Token(Token = "0x6001BFF")]
			[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C00 RID: 7168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C00")]
		[Address(RVA = "0x2CF5130", Offset = "0x2CF4130", VA = "0x182CF5130", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C01")]
		[Address(RVA = "0x2CF4FD0", Offset = "0x2CF3FD0", VA = "0x182CF4FD0")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001C02 RID: 7170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C02")]
		[Address(RVA = "0x2CF5080", Offset = "0x2CF4080", VA = "0x182CF5080", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C03 RID: 7171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C03")]
		[Address(RVA = "0x2CF5410", Offset = "0x2CF4410", VA = "0x182CF5410", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C04 RID: 7172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C04")]
		[Address(RVA = "0x2CF5350", Offset = "0x2CF4350", VA = "0x182CF5350", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C05 RID: 7173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C05")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public ListAllCondition()
		{
		}

		// Token: 0x04001AE9 RID: 6889
		[Token(Token = "0x4001AE9")]
		[FieldOffset(Offset = "0x20")]
		public ACondition[] _conditions;
	}
}
