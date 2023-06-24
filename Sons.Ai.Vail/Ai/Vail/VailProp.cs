using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	public class VailProp : MonoBehaviour
	{
		// Token: 0x0600082C RID: 2092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10", Slot = "4")]
		protected virtual void Setup(VailActor actor)
		{
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x2B66BA0", Offset = "0x2B651A0", VA = "0x182B66BA0")]
		private void Awake()
		{
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public VailProp()
		{
		}

		// Token: 0x04000672 RID: 1650
		[Token(Token = "0x4000672")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		protected VailActor _actor;
	}
}
