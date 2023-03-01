using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000537 RID: 1335
	[Token(Token = "0x2000537")]
	[AddComponentMenu("Sons/Multiplayer/Auto Attach Bolt Entity")]
	public class MultiplayerAutoAttach : EntityBehaviour
	{
		// Token: 0x060022B7 RID: 8887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x2D5F220", Offset = "0x2D5E220", VA = "0x182D5F220")]
		private void OnEnable()
		{
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x2D5F1B0", Offset = "0x2D5E1B0", VA = "0x182D5F1B0")]
		private IEnumerator DelayedOnEnable()
		{
			return null;
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x59FF50", Offset = "0x59EF50", VA = "0x18059FF50")]
		public MultiplayerAutoAttach()
		{
		}

		// Token: 0x04001F6F RID: 8047
		[Token(Token = "0x4001F6F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AttachOption _attachOption;
	}
}
