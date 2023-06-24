using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x0200002B RID: 43
	[Token(Token = "0x200002B")]
	[AddComponentMenu("Sons/VFX/TreeBroken")]
	public class TreeBroken : MonoBehaviour
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x3175320", Offset = "0x3173920", VA = "0x183175320")]
		public void AddForce(Vector3 force, ForceMode forceMode)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetTarget(Rigidbody target)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TreeBroken()
		{
		}

		// Token: 0x04000101 RID: 257
		[Token(Token = "0x4000101")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _targetRigidBody;
	}
}
