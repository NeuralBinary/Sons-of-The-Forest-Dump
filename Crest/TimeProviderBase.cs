using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000071 RID: 113
	[Token(Token = "0x2000071")]
	public abstract class TimeProviderBase : MonoBehaviour, ITimeProvider
	{
		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002C6 RID: 710
		[Token(Token = "0x170000AA")]
		public abstract float CurrentTime { [Token(Token = "0x60002C6")] get; }

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002C7 RID: 711
		[Token(Token = "0x170000AB")]
		public abstract float DeltaTime { [Token(Token = "0x60002C7")] get; }

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002C8 RID: 712
		[Token(Token = "0x170000AC")]
		public abstract float DeltaTimeDynamics { [Token(Token = "0x60002C8")] get; }

		// Token: 0x060002C9 RID: 713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002C9")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		protected TimeProviderBase()
		{
		}
	}
}
