using System;
using System.Collections.Generic;
using Endnight.Utilities.PropertyAttributes;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.VFX;

namespace Sons.Environment.Digging
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[Serializable]
	public class DiggingTileGrid : ISerializationCallbackReceiver
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000D2")]
		[Address(RVA = "0x2FA1720", Offset = "0x2F9FD20", VA = "0x182FA1720")]
		public DiggingTile Get(int x, int y, int z)
		{
			return null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D3")]
		[Address(RVA = "0x2FA17E0", Offset = "0x2F9FDE0", VA = "0x182FA17E0")]
		public void Rebuild()
		{
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D4")]
		[Address(RVA = "0x2FA1D50", Offset = "0x2FA0350", VA = "0x182FA1D50")]
		public void OnValidate()
		{
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x2FA25F0", Offset = "0x2FA0BF0", VA = "0x182FA25F0")]
		private void RefreshMesh(DiggingTile eachNode)
		{
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D6")]
		[Address(RVA = "0x2FA30C0", Offset = "0x2FA16C0", VA = "0x182FA30C0")]
		private void VerifyNodeComponents(DiggingTile eachNode)
		{
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D7")]
		[Address(RVA = "0x2FA33C0", Offset = "0x2FA19C0", VA = "0x182FA33C0")]
		private void NodeChanged(DiggingTile node)
		{
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x2FA3560", Offset = "0x2FA1B60", VA = "0x182FA3560")]
		private void GenerateVfx(DiggingTile node, int x, int y, int z)
		{
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x2FA38A0", Offset = "0x2FA1EA0", VA = "0x182FA38A0")]
		private void SendCrumbleEvent(DiggingTile node)
		{
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x2FA3D20", Offset = "0x2FA2320", VA = "0x182FA3D20")]
		private void InstanceFracture(DiggingTile tile)
		{
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x2FA41B0", Offset = "0x2FA27B0", VA = "0x182FA41B0")]
		private void ActivateFractureSides(GameObject fracturePrefab, DiggingTile tile)
		{
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x2FA4E90", Offset = "0x2FA3490", VA = "0x182FA4E90")]
		private void SendCrumbleEvents(int x, int y, int z)
		{
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x2FA5380", Offset = "0x2FA3980", VA = "0x182FA5380")]
		private void SetVectorFieldColliders(int x, int y, int z)
		{
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000DE")]
		[Address(RVA = "0x2FA5DD0", Offset = "0x2FA43D0", VA = "0x182FA5DD0")]
		private void SetVfxTexture(int volumeId, DiggingTile target)
		{
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000DF")]
		[Address(RVA = "0x2FA5F50", Offset = "0x2FA4550", VA = "0x182FA5F50")]
		private DiggingTile GetTile(int x, int y, int z)
		{
			return null;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E0")]
		[Address(RVA = "0x2FA6010", Offset = "0x2FA4610", VA = "0x182FA6010")]
		private void GetMeshSource(DiggingTile diggingTile, out Mesh mesh, out Mesh meshCollider, out Vector3 rotation, out Material material, out Texture3D vectorFieldCollider, out GameObject fracturePrefab, out bool disableColliders)
		{
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E1")]
		[Address(RVA = "0x2FA60B0", Offset = "0x2FA46B0", VA = "0x182FA60B0")]
		private void SnapRotation(ref Vector3 rotation)
		{
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E2")]
		[Address(RVA = "0x2FA60F0", Offset = "0x2FA46F0", VA = "0x182FA60F0")]
		private void UpdateFlags(int x, int y, int z, bool isRemoved)
		{
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E3")]
		[Address(RVA = "0x2FA74B0", Offset = "0x2FA5AB0", VA = "0x182FA74B0")]
		private static void ValidateX(ref List<List<List<DiggingTile>>> grid, int sizeX, int sizeY, int sizeZ)
		{
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E4")]
		[Address(RVA = "0x2FA7670", Offset = "0x2FA5C70", VA = "0x182FA7670")]
		private static void ValidateY(ref List<List<DiggingTile>> xArray, int sizeY, int sizeZ)
		{
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E5")]
		[Address(RVA = "0x2FA7900", Offset = "0x2FA5F00", VA = "0x182FA7900")]
		private static void ValidateZ(ref List<DiggingTile> yArray, int size)
		{
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E6")]
		[Address(RVA = "0x2FA79F0", Offset = "0x2FA5FF0", VA = "0x182FA79F0")]
		private static void ResizeZ(List<DiggingTile> yArray, int size)
		{
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000E7")]
		[Address(RVA = "0x2FA7BE0", Offset = "0x2FA61E0", VA = "0x182FA7BE0")]
		private static DiggingTile GetNewTile(GameObject sourcePrefab)
		{
			return null;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x2FA7C60", Offset = "0x2FA6260", VA = "0x182FA7C60")]
		private static void ResizeY(List<List<DiggingTile>> xArray, int size)
		{
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x2FA7E20", Offset = "0x2FA6420", VA = "0x182FA7E20")]
		private static void ResizeX(List<List<List<DiggingTile>>> grid, int size)
		{
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000EA")]
		[Address(RVA = "0x2FA80C0", Offset = "0x2FA66C0", VA = "0x182FA80C0")]
		private static void Clear(List<List<DiggingTile>> xArray)
		{
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000EB")]
		[Address(RVA = "0x2FA81C0", Offset = "0x2FA67C0", VA = "0x182FA81C0")]
		private static void Clear(List<DiggingTile> yArray)
		{
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000EC")]
		[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
		public void SetTransformRoot(Transform transform)
		{
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000ED")]
		[Address(RVA = "0x2FA8360", Offset = "0x2FA6960", VA = "0x182FA8360", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000EE")]
		[Address(RVA = "0x2FA84F0", Offset = "0x2FA6AF0", VA = "0x182FA84F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		// Token: 0x060000EF RID: 239 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000EF")]
		[Address(RVA = "0x2FA8840", Offset = "0x2FA6E40", VA = "0x182FA8840")]
		public DiggingTile GetClosest(Vector3 location, out float distance, bool includeRemoved = false)
		{
			return null;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000F0")]
		[Address(RVA = "0x2FA88F0", Offset = "0x2FA6EF0", VA = "0x182FA88F0")]
		private int[] GetClosestCoordinate(Vector3 location, out DiggingTile tile, out float distance, bool includeRemoved = false)
		{
			return null;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
		public GameObject GetBrokenGroundPrefab()
		{
			return null;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
		public VisualEffect GetBrokenGroundVisualEffect()
		{
			return null;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x2FA8D00", Offset = "0x2FA7300", VA = "0x182FA8D00")]
		public List<DiggingTileMesh> GetMeshes()
		{
			return null;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x2FA8D20", Offset = "0x2FA7320", VA = "0x182FA8D20")]
		public void Awake()
		{
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x2FA8F80", Offset = "0x2FA7580", VA = "0x182FA8F80")]
		public void SetVisibility(bool value)
		{
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x2FA9180", Offset = "0x2FA7780", VA = "0x182FA9180")]
		public void DigAll()
		{
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x2FA92E0", Offset = "0x2FA78E0", VA = "0x182FA92E0")]
		public DiggingTileGrid()
		{
		}

		// Token: 0x04000121 RID: 289
		[Token(Token = "0x4000121")]
		private const string CrumbleOriginId = "CrumbleOrigin";

		// Token: 0x04000122 RID: 290
		[Token(Token = "0x4000122")]
		private const string CrumbleAngleId = "CrumbleAngle";

		// Token: 0x04000123 RID: 291
		[Token(Token = "0x4000123")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int _sizeX;

		// Token: 0x04000124 RID: 292
		[Token(Token = "0x4000124")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int _sizeY;

		// Token: 0x04000125 RID: 293
		[Token(Token = "0x4000125")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int _sizeZ;

		// Token: 0x04000126 RID: 294
		[Token(Token = "0x4000126")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Vector3 _spacing;

		// Token: 0x04000127 RID: 295
		[Token(Token = "0x4000127")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _rotationSnap;

		// Token: 0x04000128 RID: 296
		[Token(Token = "0x4000128")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<Vector3> _offsets;

		// Token: 0x04000129 RID: 297
		[Token(Token = "0x4000129")]
		[FieldOffset(Offset = "0x38")]
		private List<List<List<DiggingTile>>> _tiles;

		// Token: 0x0400012A RID: 298
		[Token(Token = "0x400012A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[ReadOnly]
		private int _serializedSizeX;

		// Token: 0x0400012B RID: 299
		[Token(Token = "0x400012B")]
		[FieldOffset(Offset = "0x44")]
		[ReadOnly]
		[SerializeField]
		private int _serializedSizeY;

		// Token: 0x0400012C RID: 300
		[Token(Token = "0x400012C")]
		[FieldOffset(Offset = "0x48")]
		[ReadOnly]
		[SerializeField]
		private int _serializedSizeZ;

		// Token: 0x0400012D RID: 301
		[Token(Token = "0x400012D")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<DiggingTile> _serializedGrid;

		// Token: 0x0400012E RID: 302
		[Token(Token = "0x400012E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Transform _transformRoot;

		// Token: 0x0400012F RID: 303
		[Token(Token = "0x400012F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Mesh _solid;

		// Token: 0x04000130 RID: 304
		[Token(Token = "0x4000130")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[FormerlySerializedAs("_removed")]
		private Mesh _brokenGround;

		// Token: 0x04000131 RID: 305
		[Token(Token = "0x4000131")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GameObject _brokenGroundPrefab;

		// Token: 0x04000132 RID: 306
		[Token(Token = "0x4000132")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private VisualEffect _brokenGroundVfxObject;

		// Token: 0x04000133 RID: 307
		[Token(Token = "0x4000133")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Mesh _noRotateMesh;

		// Token: 0x04000134 RID: 308
		[Token(Token = "0x4000134")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private DiggingTileMeshData _meshData;

		// Token: 0x04000135 RID: 309
		[Token(Token = "0x4000135")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Material _baseMaterial;

		// Token: 0x04000136 RID: 310
		[Token(Token = "0x4000136")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _tileSource;

		// Token: 0x04000137 RID: 311
		[Token(Token = "0x4000137")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _particlePrefab;

		// Token: 0x04000138 RID: 312
		[Token(Token = "0x4000138")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private VisualEffect _vfxObject;

		// Token: 0x04000139 RID: 313
		[Token(Token = "0x4000139")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private string _digParticlePositionName;

		// Token: 0x0400013A RID: 314
		[Token(Token = "0x400013A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private string _digParticleEventName;

		// Token: 0x0400013B RID: 315
		[Token(Token = "0x400013B")]
		[FieldOffset(Offset = "0xC0")]
		private int _collisionVolumeAId;

		// Token: 0x0400013C RID: 316
		[Token(Token = "0x400013C")]
		[FieldOffset(Offset = "0xC4")]
		private int _collisionVolumeBId;

		// Token: 0x0400013D RID: 317
		[Token(Token = "0x400013D")]
		[FieldOffset(Offset = "0xC8")]
		private int _collisionVolumeCId;

		// Token: 0x0400013E RID: 318
		[Token(Token = "0x400013E")]
		[FieldOffset(Offset = "0xCC")]
		private int _collisionVolumeDId;

		// Token: 0x0400013F RID: 319
		[Token(Token = "0x400013F")]
		[FieldOffset(Offset = "0xD0")]
		private int _collisionVolumeEId;

		// Token: 0x04000140 RID: 320
		[Token(Token = "0x4000140")]
		[FieldOffset(Offset = "0xD4")]
		private int _collisionVolumeFId;

		// Token: 0x04000141 RID: 321
		[Token(Token = "0x4000141")]
		[FieldOffset(Offset = "0xD8")]
		private int _collisionAngleAId;

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0xDC")]
		private int _collisionAngleBId;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0xE0")]
		private int _collisionAngleCId;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0xE4")]
		private int _collisionAngleDId;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0xE8")]
		private int _collisionAngleEId;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0xEC")]
		private int _collisionAngleFId;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0xF0")]
		private VFXEventAttribute _vfxEventAttribute;
	}
}
