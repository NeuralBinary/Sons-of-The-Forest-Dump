using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Physics
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class AddForce : MonoBehaviour
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x30F9E40", Offset = "0x30F8440", VA = "0x1830F9E40")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000028")]
		[Address(RVA = "0x30F9FC0", Offset = "0x30F85C0", VA = "0x1830F9FC0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000029")]
		[Address(RVA = "0x30FA020", Offset = "0x30F8620", VA = "0x1830FA020")]
		private void Update()
		{
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020FC File Offset: 0x000002FC
		[Token(Token = "0x600002A")]
		[Address(RVA = "0x30FA220", Offset = "0x30F8820", VA = "0x1830FA220")]
		public Vector3 GetFinalForce()
		{
			return default(Vector3);
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002114 File Offset: 0x00000314
		[Token(Token = "0x600002B")]
		[Address(RVA = "0x781540", Offset = "0x77FB40", VA = "0x180781540")]
		public Vector3 GetForceValue()
		{
			return default(Vector3);
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002C")]
		[Address(RVA = "0x781560", Offset = "0x77FB60", VA = "0x180781560")]
		public void SetForce(Vector3 source)
		{
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600002D")]
		[Address(RVA = "0x30FA390", Offset = "0x30F8990", VA = "0x1830FA390")]
		public AddForce()
		{
		}

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _delay;

		// Token: 0x04000038 RID: 56
		[Token(Token = "0x4000038")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Rigidbody _target;

		// Token: 0x04000039 RID: 57
		[Token(Token = "0x4000039")]
		[FieldOffset(Offset = "0x30")]
		private float _startTime;

		// Token: 0x0400003A RID: 58
		[Token(Token = "0x400003A")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _force;

		// Token: 0x0400003B RID: 59
		[Token(Token = "0x400003B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private ForceMode _forceMode;

		// Token: 0x0400003C RID: 60
		[Token(Token = "0x400003C")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _relativeForceTransform;
	}
}
