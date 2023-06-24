using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200043C RID: 1084
	[Token(Token = "0x200043C")]
	[Serializable]
	public class BuildingCondition : ACondition
	{
		// Token: 0x06001C4A RID: 7242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4A")]
		[Address(RVA = "0x32C20D0", Offset = "0x32C06D0", VA = "0x1832C20D0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4B")]
		[Address(RVA = "0x32C21D0", Offset = "0x32C07D0", VA = "0x1832C21D0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4C")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public void OnStructureBuild(object o)
		{
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4D")]
		[Address(RVA = "0x32C2320", Offset = "0x32C0920", VA = "0x1832C2320", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C4E RID: 7246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4E")]
		[Address(RVA = "0x32C23F0", Offset = "0x32C09F0", VA = "0x1832C23F0", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C4F RID: 7247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C4F")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public BuildingCondition()
		{
		}

		// Token: 0x04001B0F RID: 6927
		[Token(Token = "0x4001B0F")]
		[FieldOffset(Offset = "0x20")]
		public BuildingTypeList[] _buildings;
	}
}
