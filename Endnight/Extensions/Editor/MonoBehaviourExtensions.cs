using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Extensions.Editor
{
	// Token: 0x020000B7 RID: 183
	[Token(Token = "0x20000B7")]
	public static class MonoBehaviourExtensions
	{
		// Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000450")]
		[Address(RVA = "0xAA7D10", Offset = "0xAA6310", VA = "0x180AA7D10")]
		public static void ExplicitInvoke(this MonoBehaviour owner, Action blackScreen, float delay)
		{
		}

		// Token: 0x06000451 RID: 1105 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x6000451")]
		[Address(RVA = "0xAA7DE0", Offset = "0xAA63E0", VA = "0x180AA7DE0")]
		private static IEnumerator InvokeDelayedInternal(Action blackScreen, float delay)
		{
			return null;
		}
	}
}
