using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000202 RID: 514
	[Token(Token = "0x2000202")]
	public class ObiRopeAttach : MonoBehaviour
	{
		// Token: 0x06000A99 RID: 2713 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x2824640", Offset = "0x2822C40", VA = "0x182824640")]
		public void LateUpdate()
		{
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ObiRopeAttach()
		{
		}

		// Token: 0x04000882 RID: 2178
		[Token(Token = "0x4000882")]
		[FieldOffset(Offset = "0x20")]
		public ObiPathSmoother generator;

		// Token: 0x04000883 RID: 2179
		[Token(Token = "0x4000883")]
		[FieldOffset(Offset = "0x28")]
		[Range(0f, 1f)]
		public float m;
	}
}
