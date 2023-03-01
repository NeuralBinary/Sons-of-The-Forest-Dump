using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x0200054E RID: 1358
	[Token(Token = "0x200054E")]
	[AddComponentMenu("Sons/Multiplayer/Host Only Attach")]
	public class HostOnlyAttach : EntityBehaviour
	{
		// Token: 0x06002352 RID: 9042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002352")]
		[Address(RVA = "0x2D5DF20", Offset = "0x2D5CF20", VA = "0x182D5DF20")]
		private void Awake()
		{
		}

		// Token: 0x06002353 RID: 9043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002353")]
		[Address(RVA = "0x2D5DFA0", Offset = "0x2D5CFA0", VA = "0x182D5DFA0")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x06002354 RID: 9044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002354")]
		[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
		public HostOnlyAttach()
		{
		}

		// Token: 0x04001FD3 RID: 8147
		[Token(Token = "0x4001FD3")]
		[FieldOffset(Offset = "0x28")]
		public bool _destroyOnClientIfNotAttached;
	}
}
