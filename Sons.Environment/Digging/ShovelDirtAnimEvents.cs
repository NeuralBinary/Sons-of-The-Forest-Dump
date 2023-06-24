using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000038 RID: 56
	[Token(Token = "0x2000038")]
	public class ShovelDirtAnimEvents : MonoBehaviour
	{
		// Token: 0x0600016E RID: 366 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600016E")]
		[Address(RVA = "0x2FB2430", Offset = "0x2FB0A30", VA = "0x182FB2430")]
		private void Start()
		{
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600016F")]
		[Address(RVA = "0x2FB24C0", Offset = "0x2FB0AC0", VA = "0x182FB24C0")]
		public void DisconnectFromShovel(Vector3 speed)
		{
		}

		// Token: 0x06000170 RID: 368 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000170")]
		[Address(RVA = "0x2FB28F0", Offset = "0x2FB0EF0", VA = "0x182FB28F0")]
		public void DisconnectFromShovelB()
		{
		}

		// Token: 0x06000171 RID: 369 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000171")]
		[Address(RVA = "0x2FB2960", Offset = "0x2FB0F60", VA = "0x182FB2960")]
		private IEnumerator ConvertToRigidBody(GameObject goTarget, bool smallChunks = false)
		{
			return null;
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000172")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShovelDirtAnimEvents()
		{
		}

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject[] _chunksA;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject[] _chunksB;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Rigidbody _rigidBody;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x38")]
		private Animator _animator;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x40")]
		private Vector3 _speed;
	}
}
