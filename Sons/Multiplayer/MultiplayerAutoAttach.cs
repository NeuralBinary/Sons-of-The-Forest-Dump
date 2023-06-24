using System;
using System.Collections;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000540 RID: 1344
	[Token(Token = "0x2000540")]
	[AddComponentMenu("Sons/Multiplayer/Auto Attach Bolt Entity")]
	public class MultiplayerAutoAttach : EntityBehaviour
	{
		// Token: 0x060023AB RID: 9131 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AB")]
		[Address(RVA = "0x3352FC0", Offset = "0x33515C0", VA = "0x183352FC0")]
		private void OnEnable()
		{
		}

		// Token: 0x060023AC RID: 9132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60023AC")]
		[Address(RVA = "0x33530A0", Offset = "0x33516A0", VA = "0x1833530A0")]
		private IEnumerator DelayedOnEnable()
		{
			return null;
		}

		// Token: 0x060023AD RID: 9133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60023AD")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerAutoAttach()
		{
		}

		// Token: 0x04002024 RID: 8228
		[Token(Token = "0x4002024")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AttachOption _attachOption;
	}
}
