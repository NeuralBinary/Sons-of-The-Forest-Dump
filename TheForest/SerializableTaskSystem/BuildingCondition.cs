using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200044A RID: 1098
	[Token(Token = "0x200044A")]
	[Serializable]
	public class BuildingCondition : ACondition
	{
		// Token: 0x06001C0C RID: 7180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x2CF40E0", Offset = "0x2CF30E0", VA = "0x182CF40E0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C0D RID: 7181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x2CF3FD0", Offset = "0x2CF2FD0", VA = "0x182CF3FD0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C0E RID: 7182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x5393B0", Offset = "0x5383B0", VA = "0x1805393B0")]
		public void OnStructureBuild(object o)
		{
		}

		// Token: 0x06001C0F RID: 7183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0F")]
		[Address(RVA = "0x2CF42B0", Offset = "0x2CF32B0", VA = "0x182CF42B0", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C10 RID: 7184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x2CF41E0", Offset = "0x2CF31E0", VA = "0x182CF41E0", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C11 RID: 7185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C11")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public BuildingCondition()
		{
		}

		// Token: 0x04001AEB RID: 6891
		[Token(Token = "0x4001AEB")]
		[FieldOffset(Offset = "0x20")]
		public BuildingTypeList[] _buildings;
	}
}
