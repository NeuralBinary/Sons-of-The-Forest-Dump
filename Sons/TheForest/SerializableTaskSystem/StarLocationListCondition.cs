using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000448 RID: 1096
	[Token(Token = "0x2000448")]
	[Serializable]
	public class StarLocationListCondition : ListAllCondition
	{
		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001C7D RID: 7293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170003DF")]
		public override ACondition[] Conditions
		{
			[Token(Token = "0x6001C7D")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001C7E RID: 7294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7E")]
		[Address(RVA = "0x32C4200", Offset = "0x32C2800", VA = "0x1832C4200", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C7F RID: 7295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C7F")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public StarLocationListCondition()
		{
		}

		// Token: 0x04001B1D RID: 6941
		[Token(Token = "0x4001B1D")]
		[FieldOffset(Offset = "0x28")]
		[Header("StarLocation List")]
		public StarLocationCondition[] _starConditions;
	}
}
