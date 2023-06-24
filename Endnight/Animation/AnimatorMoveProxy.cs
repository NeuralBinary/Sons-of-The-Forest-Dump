using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000C8 RID: 200
	[Token(Token = "0x20000C8")]
	[AddComponentMenu("Endnight/Animation/Animator Move Proxy")]
	public class AnimatorMoveProxy : MonoBehaviour
	{
		// Token: 0x060004B8 RID: 1208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B8")]
		[Address(RVA = "0xAAEA50", Offset = "0xAAD050", VA = "0x180AAEA50")]
		private void OnAnimatorMove()
		{
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B9")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetReceiver(IAnimatorMoveProxyReceiver receiver)
		{
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BA")]
		[Address(RVA = "0xAAEAA0", Offset = "0xAAD0A0", VA = "0x180AAEAA0")]
		public static void SetupReceiver(Animator target, IAnimatorMoveProxyReceiver receiver)
		{
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BB")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimatorMoveProxy()
		{
		}

		// Token: 0x04000301 RID: 769
		[Token(Token = "0x4000301")]
		[FieldOffset(Offset = "0x20")]
		private IAnimatorMoveProxyReceiver _receiver;
	}
}
