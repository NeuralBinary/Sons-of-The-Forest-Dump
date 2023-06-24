using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000029 RID: 41
	[Token(Token = "0x2000029")]
	[CreateAssetMenu(menuName = "Sons/Digging/Mesh Data", fileName = "DiggingTileMeshData", order = 0)]
	public class DiggingTileMeshData : ScriptableObject
	{
		// Token: 0x0600010E RID: 270 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600010E")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public void SetFrom(List<DiggingTileMesh> meshes)
		{
		}

		// Token: 0x0600010F RID: 271 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600010F")]
		[Address(RVA = "0x2FAAB70", Offset = "0x2FA9170", VA = "0x182FAAB70")]
		public void GetMeshSource(DiggingTile diggingTile, out Mesh mesh, out Mesh meshCollider, out Vector3 rotation, out Material material, out Texture3D vectorFieldCollider, out GameObject fracturePrefab, out bool disableColliders)
		{
		}

		// Token: 0x06000110 RID: 272 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000110")]
		[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
		public List<DiggingTileMesh> GetMeshes()
		{
			return null;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000111")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public DiggingTileMeshData()
		{
		}

		// Token: 0x0400015B RID: 347
		[Token(Token = "0x400015B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<DiggingTileMesh> _meshes;
	}
}
