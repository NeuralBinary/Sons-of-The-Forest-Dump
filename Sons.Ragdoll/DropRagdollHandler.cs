using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ragdoll
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public class DropRagdollHandler : MonoBehaviour
	{
		// Token: 0x06000003 RID: 3 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x3117F10", Offset = "0x3116510", VA = "0x183117F10")]
		private void Awake()
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000004")]
		[Address(RVA = "0x31181D0", Offset = "0x31167D0", VA = "0x1831181D0")]
		public void OnDropFromCarry()
		{
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public DropRagdollHandler()
		{
		}

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform[] _ragdollBodiesToResetOnDrop;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x28")]
		private Vector3[] _ragdollBodiesToZeroOnDropLocalPos;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x30")]
		private Quaternion[] _ragdollBodiesToZeroOnDropLocalRot;
	}
}
