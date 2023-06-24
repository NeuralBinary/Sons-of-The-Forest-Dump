using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Endnight.Rendering
{
	// Token: 0x02000080 RID: 128
	[Token(Token = "0x2000080")]
	public class AssetReferenceRenderableCollisionLink : MonoBehaviour
	{
		// Token: 0x060002D9 RID: 729 RVA: 0x0000206A File Offset: 0x0000026A
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
		public List<Collider> GetColliders()
		{
			return null;
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0xA94E00", Offset = "0xA93400", VA = "0x180A94E00")]
		public void RemoveColliders()
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0xA95040", Offset = "0xA93640", VA = "0x180A95040")]
		public void SetConvex(bool isConvex)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0xA951D0", Offset = "0xA937D0", VA = "0x180A951D0")]
		private void RegenerateColliders()
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0xA951E0", Offset = "0xA937E0", VA = "0x180A951E0")]
		public void GenerateColliders(bool ignoreSkinnedMeshRenderers, Mesh cachedMesh)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0xA95760", Offset = "0xA93D60", VA = "0x180A95760")]
		public AssetReferenceRenderableCollisionLink()
		{
		}

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Collider> _colliders;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _useCustomColliderMesh;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Mesh _customColliderMesh;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _ignoreSkinnedMeshRenderers;
	}
}
