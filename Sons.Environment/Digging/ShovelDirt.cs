using System;
using Il2CppDummyDll;
using Sons.Physics;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000037 RID: 55
	[Token(Token = "0x2000037")]
	public class ShovelDirt : MonoBehaviour
	{
		// Token: 0x0600016C RID: 364 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600016C")]
		[Address(RVA = "0x2FB1E60", Offset = "0x2FB0460", VA = "0x182FB1E60")]
		public void Detach(Vector3 velocity)
		{
		}

		// Token: 0x0600016D RID: 365 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600016D")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShovelDirt()
		{
		}

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Rigidbody _rigidbody;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AddForce _addForce;

		// Token: 0x040001B2 RID: 434
		[Token(Token = "0x40001B2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Animation _animation;
	}
}
