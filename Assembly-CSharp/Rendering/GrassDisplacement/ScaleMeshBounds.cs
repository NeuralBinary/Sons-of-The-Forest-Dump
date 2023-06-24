using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Rendering.GrassDisplacement
{
	// Token: 0x0200004D RID: 77
	[Token(Token = "0x200004D")]
	[AddComponentMenu("Rendering/GrassDisplacement/ScaleMeshBounds")]
	public class ScaleMeshBounds : MonoBehaviour
	{
		// Token: 0x0600010F RID: 271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x5EC8F0", Offset = "0x5EAEF0", VA = "0x1805EC8F0")]
		private void OnEnable()
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x5EC900", Offset = "0x5EAF00", VA = "0x1805EC900")]
		private void OnValidate()
		{
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x5ECA00", Offset = "0x5EB000", VA = "0x1805ECA00")]
		private void SetBounds(bool rebuildMesh)
		{
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000112")]
		[Address(RVA = "0x5ED020", Offset = "0x5EB620", VA = "0x1805ED020")]
		private void OnDrawGizmosSelected()
		{
		}

		// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000113")]
		[Address(RVA = "0x5ED420", Offset = "0x5EBA20", VA = "0x1805ED420")]
		public ScaleMeshBounds()
		{
		}

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[FormerlySerializedAs("_Scale")]
		private Vector3 _scale;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x30")]
		private Mesh _meshInstance;

		// Token: 0x04000253 RID: 595
		[Token(Token = "0x4000253")]
		[FieldOffset(Offset = "0x38")]
		private Mesh _origMeshSource;

		// Token: 0x04000254 RID: 596
		[Token(Token = "0x4000254")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[FormerlySerializedAs("_Reset")]
		private bool _reset;
	}
}
