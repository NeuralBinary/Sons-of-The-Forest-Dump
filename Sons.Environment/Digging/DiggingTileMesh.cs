using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Environment.Digging
{
	// Token: 0x02000028 RID: 40
	[Token(Token = "0x2000028")]
	[Serializable]
	public class DiggingTileMesh
	{
		// Token: 0x06000108 RID: 264 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000108")]
		[Address(RVA = "0x2FAA800", Offset = "0x2FA8E00", VA = "0x182FAA800")]
		public void OnValidate()
		{
		}

		// Token: 0x06000109 RID: 265 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x2FAA900", Offset = "0x2FA8F00", VA = "0x182FAA900")]
		public void GetMeshData(float digDirection, out Mesh mesh, out Mesh meshCollider, out Vector3 rotation, out Material material, out Texture3D vectorFieldCollider, out GameObject fracturePrefab, out bool disableColliders)
		{
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2FAAB10", Offset = "0x2FA9110", VA = "0x182FAAB10")]
		public bool Matches(DiggingTileTypeFlags typeFlags, DiggingTileRemovedFlags getRemovedFlags)
		{
			return default(bool);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002594 File Offset: 0x00000794
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2FAAB40", Offset = "0x2FA9140", VA = "0x182FAAB40")]
		private bool IsSideOpen(DiggingTileRemovedFlags check)
		{
			return default(bool);
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600010C")]
		[Address(RVA = "0x2FAAB50", Offset = "0x2FA9150", VA = "0x182FAAB50")]
		public void SetRemovedFlag(DiggingTileRemovedFlags flag, bool value)
		{
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x600010D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public DiggingTileMesh()
		{
		}

		// Token: 0x0400014F RID: 335
		[Token(Token = "0x400014F")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private string _name;

		// Token: 0x04000150 RID: 336
		[Token(Token = "0x4000150")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Mesh _mesh;

		// Token: 0x04000151 RID: 337
		[Token(Token = "0x4000151")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Mesh _meshCollider;

		// Token: 0x04000152 RID: 338
		[Token(Token = "0x4000152")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _disableColliders;

		// Token: 0x04000153 RID: 339
		[Token(Token = "0x4000153")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Material _material;

		// Token: 0x04000154 RID: 340
		[Token(Token = "0x4000154")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DiggingTileRemovedFlags _removedFlag;

		// Token: 0x04000155 RID: 341
		[Token(Token = "0x4000155")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _invertRemoved;

		// Token: 0x04000156 RID: 342
		[Token(Token = "0x4000156")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private DiggingTileTypeFlags _typeFlag;

		// Token: 0x04000157 RID: 343
		[Token(Token = "0x4000157")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Vector3 _rotation;

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private bool _useDigDirection;

		// Token: 0x04000159 RID: 345
		[Token(Token = "0x4000159")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Texture3D _vectorFieldCollider;

		// Token: 0x0400015A RID: 346
		[Token(Token = "0x400015A")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _fracturePrefab;
	}
}
