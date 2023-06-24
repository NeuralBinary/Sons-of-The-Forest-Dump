using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200043A RID: 1082
	[Token(Token = "0x200043A")]
	[Serializable]
	public class ListAllCondition : ACondition
	{
		// Token: 0x170003DC RID: 988
		// (get) Token: 0x06001C3D RID: 7229 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DC")]
		public virtual ACondition[] Conditions
		{
			[Token(Token = "0x6001C3D")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C3E RID: 7230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3E")]
		[Address(RVA = "0x32C1640", Offset = "0x32BFC40", VA = "0x1832C1640", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C3F RID: 7231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C3F")]
		[Address(RVA = "0x32C18E0", Offset = "0x32BFEE0", VA = "0x1832C18E0")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x32C1990", Offset = "0x32BFF90", VA = "0x1832C1990", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x32C1AA0", Offset = "0x32C00A0", VA = "0x1832C1AA0", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C42 RID: 7234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C42")]
		[Address(RVA = "0x32C1BA0", Offset = "0x32C01A0", VA = "0x1832C1BA0", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C43 RID: 7235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C43")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public ListAllCondition()
		{
		}

		// Token: 0x04001B0D RID: 6925
		[Token(Token = "0x4001B0D")]
		[FieldOffset(Offset = "0x20")]
		public ACondition[] _conditions;
	}
}
