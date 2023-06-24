using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player.Data
{
	// Token: 0x0200048C RID: 1164
	[Token(Token = "0x200048C")]
	public class BoolData : MonoBehaviour
	{
		// Token: 0x06001E34 RID: 7732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E34")]
		[Address(RVA = "0x7AAFD0", Offset = "0x7A95D0", VA = "0x1807AAFD0")]
		public void SetValue(bool value)
		{
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x00008928 File Offset: 0x00006B28
		[Token(Token = "0x6001E35")]
		[Address(RVA = "0x32EECE0", Offset = "0x32ED2E0", VA = "0x1832EECE0")]
		public static implicit operator bool(BoolData bd)
		{
			return default(bool);
		}

		// Token: 0x06001E36 RID: 7734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001E36")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BoolData()
		{
		}

		// Token: 0x04001C59 RID: 7257
		[Token(Token = "0x4001C59")]
		[FieldOffset(Offset = "0x20")]
		private bool _value;
	}
}
