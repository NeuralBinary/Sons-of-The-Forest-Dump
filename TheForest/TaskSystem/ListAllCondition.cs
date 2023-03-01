using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000435 RID: 1077
	[Token(Token = "0x2000435")]
	[Serializable]
	public class ListAllCondition : ACondition
	{
		// Token: 0x06001BAF RID: 7087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x2CE50A0", Offset = "0x2CE40A0", VA = "0x182CE50A0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BB0 RID: 7088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x2CE4FA0", Offset = "0x2CE3FA0", VA = "0x182CE4FA0")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001BB1 RID: 7089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x2CE5010", Offset = "0x2CE4010", VA = "0x182CE5010", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BB2 RID: 7090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public ListAllCondition()
		{
		}

		// Token: 0x04001ACC RID: 6860
		[Token(Token = "0x4001ACC")]
		[FieldOffset(Offset = "0x20")]
		public ACondition[] _conditions;
	}
}
