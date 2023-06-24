using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000195 RID: 405
	[Token(Token = "0x2000195")]
	[Serializable]
	public class ObiNativeVector4List : ObiNativeList<Vector4>
	{
		// Token: 0x0600078F RID: 1935 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x27DDAA0", Offset = "0x27DC0A0", VA = "0x1827DDAA0")]
		public ObiNativeVector4List(int capacity = 8, int alignment = 16)
		{
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x000046F4 File Offset: 0x000028F4
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x27DDDF0", Offset = "0x27DC3F0", VA = "0x1827DDDF0")]
		public Vector3 GetVector3(int index)
		{
			return default(Vector3);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x27DDE20", Offset = "0x27DC420", VA = "0x1827DDE20")]
		public void SetVector3(int index, Vector3 value)
		{
		}
	}
}
