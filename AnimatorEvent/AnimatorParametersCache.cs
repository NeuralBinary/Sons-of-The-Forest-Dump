using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Ashkatchap.AnimatorEvents
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class AnimatorParametersCache : MonoBehaviour
	{
		// Token: 0x0600000E RID: 14 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x5BDC50", Offset = "0x5BC250", VA = "0x1805BDC50")]
		private void Awake()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x0000209C File Offset: 0x0000029C
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x5BDF40", Offset = "0x5BC540", VA = "0x1805BDF40")]
		public bool TryGetParameterType(int parameterHash, out AnimatorControllerParameterType type)
		{
			return default(bool);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimatorParametersCache()
		{
		}

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x20")]
		public AnimatorControllerParameter[] parameters;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<int, AnimatorControllerParameterType> parameterType;
	}
}
