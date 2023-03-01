using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x02000449 RID: 1097
	[Token(Token = "0x2000449")]
	[Serializable]
	public class ListAnyCondition : ACondition
	{
		// Token: 0x06001C06 RID: 7174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x2CF55C0", Offset = "0x2CF45C0", VA = "0x182CF55C0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C07 RID: 7175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x2CF54D0", Offset = "0x2CF44D0", VA = "0x182CF54D0")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001C08 RID: 7176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x2CF5540", Offset = "0x2CF4540", VA = "0x182CF5540", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C09 RID: 7177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C09")]
		[Address(RVA = "0x2CF5820", Offset = "0x2CF4820", VA = "0x182CF5820", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C0A RID: 7178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x2CF5750", Offset = "0x2CF4750", VA = "0x182CF5750", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C0B RID: 7179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C0B")]
		[Address(RVA = "0x2CF3FC0", Offset = "0x2CF2FC0", VA = "0x182CF3FC0")]
		public ListAnyCondition()
		{
		}

		// Token: 0x04001AEA RID: 6890
		[Token(Token = "0x4001AEA")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public ACondition[] _conditions;
	}
}
