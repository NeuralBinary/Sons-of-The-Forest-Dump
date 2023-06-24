using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000558 RID: 1368
	[Token(Token = "0x2000558")]
	[AddComponentMenu("Sons/Multiplayer/Host Only Attach")]
	public class HostOnlyAttach : EntityBehaviour
	{
		// Token: 0x06002448 RID: 9288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002448")]
		[Address(RVA = "0x3385780", Offset = "0x3383D80", VA = "0x183385780")]
		private void Awake()
		{
		}

		// Token: 0x06002449 RID: 9289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002449")]
		[Address(RVA = "0x3385870", Offset = "0x3383E70", VA = "0x183385870")]
		private IEnumerator Start()
		{
			return null;
		}

		// Token: 0x0600244A RID: 9290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600244A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public HostOnlyAttach()
		{
		}

		// Token: 0x0400208D RID: 8333
		[Token(Token = "0x400208D")]
		[FieldOffset(Offset = "0x28")]
		public bool _destroyOnClientIfNotAttached;
	}
}
