using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x0200018F RID: 399
	[Token(Token = "0x200018F")]
	[Serializable]
	public class ObiNativeQuaternionList : ObiNativeList<Quaternion>
	{
		// Token: 0x06000788 RID: 1928 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000788")]
		[Address(RVA = "0x27DC4E0", Offset = "0x27DAAE0", VA = "0x1827DC4E0")]
		public ObiNativeQuaternionList(int capacity = 8, int alignment = 16)
		{
		}

		// Token: 0x06000789 RID: 1929 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000789")]
		[Address(RVA = "0x27DC750", Offset = "0x27DAD50", VA = "0x1827DC750")]
		public ObiNativeQuaternionList(int capacity, int alignment, Quaternion defaultValue)
		{
		}
	}
}
