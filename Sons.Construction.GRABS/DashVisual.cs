using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	public class DashVisual : MonoBehaviour
	{
		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000255 RID: 597 RVA: 0x00002D2C File Offset: 0x00000F2C
		[Token(Token = "0x17000091")]
		public Vector3 Size
		{
			[Token(Token = "0x6000255")]
			[Address(RVA = "0x29A0830", Offset = "0x299EE30", VA = "0x1829A0830")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000256")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DashVisual()
		{
		}

		// Token: 0x04000106 RID: 262
		[Token(Token = "0x4000106")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Vector3 _size;
	}
}
