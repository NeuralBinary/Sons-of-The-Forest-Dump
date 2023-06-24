using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	public class FleePath : RandomPath
	{
		// Token: 0x0600082A RID: 2090 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x6D6AE0", Offset = "0x6D50E0", VA = "0x1806D6AE0")]
		public FleePath()
		{
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x6D6C20", Offset = "0x6D5220", VA = "0x1806D6C20")]
		public static FleePath Construct(Vector3 start, Vector3 avoid, int searchLength, [Optional] OnPathDelegate callback)
		{
			return null;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x6D6D80", Offset = "0x6D5380", VA = "0x1806D6D80")]
		protected void Setup(Vector3 start, Vector3 avoid, int searchLength, OnPathDelegate callback)
		{
		}
	}
}
