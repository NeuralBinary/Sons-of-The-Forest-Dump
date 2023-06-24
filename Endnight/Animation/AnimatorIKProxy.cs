using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Animation
{
	// Token: 0x020000C7 RID: 199
	[Token(Token = "0x20000C7")]
	[AddComponentMenu("Endnight/Animation/Animator IK Proxy")]
	public class AnimatorIKProxy : MonoBehaviour
	{
		// Token: 0x060004B4 RID: 1204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B4")]
		[Address(RVA = "0xAAE770", Offset = "0xAACD70", VA = "0x180AAE770")]
		private void OnAnimatorIK(int layerIndex)
		{
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B5")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetReceiver(IAnimatorIKProxyReceiver receiver)
		{
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B6")]
		[Address(RVA = "0xAAE7D0", Offset = "0xAACDD0", VA = "0x180AAE7D0")]
		public static void SetupReceiver(Animator target, IAnimatorIKProxyReceiver receiver)
		{
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004B7")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AnimatorIKProxy()
		{
		}

		// Token: 0x04000300 RID: 768
		[Token(Token = "0x4000300")]
		[FieldOffset(Offset = "0x20")]
		private IAnimatorIKProxyReceiver _receiver;
	}
}
