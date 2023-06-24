using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Electricity
{
	// Token: 0x0200000D RID: 13
	[Token(Token = "0x200000D")]
	public class PowerSource : MonoBehaviour
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000039 RID: 57 RVA: 0x0000212C File Offset: 0x0000032C
		[Token(Token = "0x1700000E")]
		public float Power
		{
			[Token(Token = "0x6000039")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600003A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public PowerSource()
		{
		}

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _power;
	}
}
