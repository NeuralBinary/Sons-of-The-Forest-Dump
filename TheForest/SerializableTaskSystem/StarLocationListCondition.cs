using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000456 RID: 1110
	[Token(Token = "0x2000456")]
	[Serializable]
	public class StarLocationListCondition : ListAllCondition
	{
		// Token: 0x170003D5 RID: 981
		// (get) Token: 0x06001C3F RID: 7231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003D5")]
		public override ACondition[] Conditions
		{
			[Token(Token = "0x6001C3F")]
			[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C40 RID: 7232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C40")]
		[Address(RVA = "0x2D04320", Offset = "0x2D03320", VA = "0x182D04320", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C41 RID: 7233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C41")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public StarLocationListCondition()
		{
		}

		// Token: 0x04001AF9 RID: 6905
		[Token(Token = "0x4001AF9")]
		[FieldOffset(Offset = "0x28")]
		[Header("StarLocation List")]
		public StarLocationCondition[] _starConditions;
	}
}
