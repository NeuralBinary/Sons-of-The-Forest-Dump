using System;
using Il2CppDummyDll;
using UnityEngine;

namespace TheForest.Player.Data
{
	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	public class BoolData : MonoBehaviour
	{
		// Token: 0x06001DE4 RID: 7652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE4")]
		[Address(RVA = "0x6DE720", Offset = "0x6DD720", VA = "0x1806DE720")]
		public void SetValue(bool value)
		{
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x6001DE5")]
		[Address(RVA = "0x2D0C5A0", Offset = "0x2D0B5A0", VA = "0x182D0C5A0")]
		public static implicit operator bool(BoolData bd)
		{
			return default(bool);
		}

		// Token: 0x06001DE6 RID: 7654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DE6")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BoolData()
		{
		}

		// Token: 0x04001C29 RID: 7209
		[Token(Token = "0x4001C29")]
		[FieldOffset(Offset = "0x20")]
		private bool _value;
	}
}
