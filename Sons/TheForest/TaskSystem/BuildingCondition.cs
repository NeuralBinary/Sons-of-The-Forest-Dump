using System;
using Il2CppDummyDll;

namespace TheForest.TaskSystem
{
	// Token: 0x02000429 RID: 1065
	[Token(Token = "0x2000429")]
	[Serializable]
	public class BuildingCondition : ACondition
	{
		// Token: 0x06001BF5 RID: 7157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF5")]
		[Address(RVA = "0x32BEE40", Offset = "0x32BD440", VA = "0x1832BEE40", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001BF6 RID: 7158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF6")]
		[Address(RVA = "0x32BEF40", Offset = "0x32BD540", VA = "0x1832BEF40", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001BF7 RID: 7159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF7")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnStructureBuild(object o)
		{
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001BF8")]
		[Address(RVA = "0x704F00", Offset = "0x703500", VA = "0x180704F00")]
		public BuildingCondition()
		{
		}

		// Token: 0x04001AF2 RID: 6898
		[Token(Token = "0x4001AF2")]
		[FieldOffset(Offset = "0x20")]
		public BuildingTypeList[] _buildings;
	}
}
