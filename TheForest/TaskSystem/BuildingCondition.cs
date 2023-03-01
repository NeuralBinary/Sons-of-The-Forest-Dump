using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000437 RID: 1079
	[Token(Token = "0x2000437")]
	[Serializable]
	public class BuildingCondition : ACondition
	{
		// Token: 0x06001BB7 RID: 7095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x2CDDF50", Offset = "0x2CDCF50", VA = "0x182CDDF50", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BB8 RID: 7096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x2CDDE30", Offset = "0x2CDCE30", VA = "0x182CDDE30", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BB9 RID: 7097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnStructureBuild(object o)
		{
		}

		// Token: 0x06001BBA RID: 7098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x665E20", Offset = "0x664E20", VA = "0x180665E20")]
		public BuildingCondition()
		{
		}

		// Token: 0x04001ACE RID: 6862
		[Token(Token = "0x4001ACE")]
		[FieldOffset(Offset = "0x20")]
		public BuildingTypeList[] _buildings;
	}
}
