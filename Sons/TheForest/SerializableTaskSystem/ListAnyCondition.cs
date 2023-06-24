using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.SerializableTaskSystem
{
	// Token: 0x0200043B RID: 1083
	[Token(Token = "0x200043B")]
	[Serializable]
	public class ListAnyCondition : ACondition
	{
		// Token: 0x06001C44 RID: 7236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C44")]
		[Address(RVA = "0x32C1CA0", Offset = "0x32C02A0", VA = "0x1832C1CA0", Slot = "4")]
		public override void Init()
		{
		}

		// Token: 0x06001C45 RID: 7237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C45")]
		[Address(RVA = "0x32C1EC0", Offset = "0x32C04C0", VA = "0x1832C1EC0")]
		public void CheckCompletion()
		{
		}

		// Token: 0x06001C46 RID: 7238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C46")]
		[Address(RVA = "0x32BEAE0", Offset = "0x32BD0E0", VA = "0x1832BEAE0", Slot = "6")]
		public override void Clear()
		{
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C47")]
		[Address(RVA = "0x32C1F30", Offset = "0x32C0530", VA = "0x1832C1F30", Slot = "8")]
		public override void SaveDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C48")]
		[Address(RVA = "0x32C2000", Offset = "0x32C0600", VA = "0x1832C2000", Slot = "9")]
		public override void LoadDone(ICollection<int> doneConditions)
		{
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001C49")]
		[Address(RVA = "0x32C1170", Offset = "0x32BF770", VA = "0x1832C1170")]
		public ListAnyCondition()
		{
		}

		// Token: 0x04001B0E RID: 6926
		[Token(Token = "0x4001B0E")]
		[FieldOffset(Offset = "0x20")]
		[HideInInspector]
		public ACondition[] _conditions;
	}
}
