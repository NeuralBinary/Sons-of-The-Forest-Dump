using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Lodding
{
	// Token: 0x02000012 RID: 18
	[Token(Token = "0x2000012")]
	[Serializable]
	public class SubBillboardData
	{
		// Token: 0x060000A9 RID: 169 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0xAFF460", Offset = "0xAFDA60", VA = "0x180AFF460")]
		public int GetRegisteredCount()
		{
			return 0;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x30C6AB0", Offset = "0x30C50B0", VA = "0x1830C6AB0")]
		public bool GetIsVisible()
		{
			return default(bool);
		}

		// Token: 0x060000AB RID: 171 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x23BB6A0", Offset = "0x23B9CA0", VA = "0x1823BB6A0")]
		public Vector3 GetCenter()
		{
			return default(Vector3);
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x270DED0", Offset = "0x270C4D0", VA = "0x18270DED0")]
		public void SetCenter(Vector3 center)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x30C6AC0", Offset = "0x30C50C0", VA = "0x1830C6AC0")]
		public int RegisterCache(Vector3 position, Quaternion rotation, float scale)
		{
			return 0;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x30C6B00", Offset = "0x30C5100", VA = "0x1830C6B00")]
		public int Register(Vector3 position, Quaternion rotation, float scale, bool flagRebuildMesh = true)
		{
			return 0;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x30C71A0", Offset = "0x30C57A0", VA = "0x1830C71A0")]
		internal void SetRebuildMesh(bool value)
		{
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x30C7210", Offset = "0x30C5810", VA = "0x1830C7210")]
		private static int GetStartV(int index)
		{
			return 0;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x30C7220", Offset = "0x30C5820", VA = "0x1830C7220")]
		public void SetPosition(int index, Vector3 position)
		{
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x30C7430", Offset = "0x30C5A30", VA = "0x1830C7430")]
		public void SetAlive(int index, bool alive)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x30C7720", Offset = "0x30C5D20", VA = "0x1830C7720")]
		public void RebuildMeshes()
		{
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x30C8910", Offset = "0x30C6F10", VA = "0x1830C8910")]
		public void LateUpdate()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x30C8AC0", Offset = "0x30C70C0", VA = "0x1830C8AC0")]
		private bool ShouldRebuildMesh()
		{
			return default(bool);
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x30C8B40", Offset = "0x30C7140", VA = "0x1830C8B40")]
		private void UpdatePositions()
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x30C8BF0", Offset = "0x30C71F0", VA = "0x1830C8BF0")]
		private void UpdateAlive()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x30C8CA0", Offset = "0x30C72A0", VA = "0x1830C8CA0")]
		public void Dispose()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x30C8DA0", Offset = "0x30C73A0", VA = "0x1830C8DA0")]
		public void AssignMaterial(Material materialInstance)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x30C8E10", Offset = "0x30C7410", VA = "0x1830C8E10")]
		public Material GetSharedMaterial()
		{
			return null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x30C8E70", Offset = "0x30C7470", VA = "0x1830C8E70")]
		public Material GetMaterialInstance()
		{
			return null;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BC")]
		[Address(RVA = "0x30C8ED0", Offset = "0x30C74D0", VA = "0x1830C8ED0")]
		public void OnValidate(CustomBillboard holder)
		{
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x30C8F00", Offset = "0x30C7500", VA = "0x1830C8F00")]
		public void Initialize(CustomBillboard holder, int index)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x30C9330", Offset = "0x30C7930", VA = "0x1830C9330")]
		public void CreateMissingBucketObjects(CustomBillboard customBillboard, int index)
		{
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
		public void SetMeshRenderer(MeshRenderer source)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
		public void SetGameObject(GameObject source)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
		public void SetMeshFilter(MeshFilter source)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x30C9DC0", Offset = "0x30C83C0", VA = "0x1830C9DC0")]
		public void SetVisibility(bool visible)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x30C9E40", Offset = "0x30C8440", VA = "0x1830C9E40")]
		public void DrawGizmosSelected(CustomBillboard customBillboard, float bucketSize)
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x30CA170", Offset = "0x30C8770", VA = "0x1830CA170")]
		public void SetActive(bool activeValue, CustomBillboard holder, int index)
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x30CA200", Offset = "0x30C8800", VA = "0x1830CA200")]
		public void SetSkipBuildCount(int skipBuildCount)
		{
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x30CA270", Offset = "0x30C8870", VA = "0x1830CA270")]
		public void ClearCachedData()
		{
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C7")]
		[Address(RVA = "0x30CA310", Offset = "0x30C8910", VA = "0x1830CA310")]
		public void ClearMeshes()
		{
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C8")]
		[Address(RVA = "0x30CA5F0", Offset = "0x30C8BF0", VA = "0x1830CA5F0")]
		public SubBillboardData()
		{
		}

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x10")]
		private Mesh _mesh;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[FormerlySerializedAs("GameObject")]
		private GameObject _gameObject;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x20")]
		[FormerlySerializedAs("MeshRenderer")]
		[SerializeField]
		private MeshRenderer _meshRenderer;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[FormerlySerializedAs("MeshFilter")]
		private MeshFilter _meshFilter;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<bool> _registeredAlive;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private List<Vector3> _registeredPositions;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<float> _registeredRotations;

		// Token: 0x040000C9 RID: 201
		[Token(Token = "0x40000C9")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private List<float> _registeredScales;

		// Token: 0x040000CA RID: 202
		[Token(Token = "0x40000CA")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<float> _registeredLuminance;

		// Token: 0x040000CB RID: 203
		[Token(Token = "0x40000CB")]
		[FieldOffset(Offset = "0x58")]
		private int _skipBuildCount;

		// Token: 0x040000CC RID: 204
		[Token(Token = "0x40000CC")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private float _horizontalOffset;

		// Token: 0x040000CD RID: 205
		[Token(Token = "0x40000CD")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _horizontalSize;

		// Token: 0x040000CE RID: 206
		[Token(Token = "0x40000CE")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private bool _usesHorizontal;

		// Token: 0x040000CF RID: 207
		[Token(Token = "0x40000CF")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 _center;

		// Token: 0x040000D0 RID: 208
		[Token(Token = "0x40000D0")]
		[FieldOffset(Offset = "0x74")]
		private Vector3 _hOffset0;

		// Token: 0x040000D1 RID: 209
		[Token(Token = "0x40000D1")]
		[FieldOffset(Offset = "0x80")]
		private Vector3 _hOffset1;

		// Token: 0x040000D2 RID: 210
		[Token(Token = "0x40000D2")]
		[FieldOffset(Offset = "0x8C")]
		private Vector3 _hOffset2;

		// Token: 0x040000D3 RID: 211
		[Token(Token = "0x40000D3")]
		[FieldOffset(Offset = "0x98")]
		private Vector3 _hOffset3;

		// Token: 0x040000D4 RID: 212
		[Token(Token = "0x40000D4")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3[] _vertices;

		// Token: 0x040000D5 RID: 213
		[Token(Token = "0x40000D5")]
		[FieldOffset(Offset = "0xB0")]
		private Color[] _colors;

		// Token: 0x040000D6 RID: 214
		[Token(Token = "0x40000D6")]
		[FieldOffset(Offset = "0xB8")]
		private bool _positionChange;

		// Token: 0x040000D7 RID: 215
		[Token(Token = "0x40000D7")]
		[FieldOffset(Offset = "0xB9")]
		private bool _aliveChange;

		// Token: 0x040000D8 RID: 216
		[Token(Token = "0x40000D8")]
		[FieldOffset(Offset = "0xBA")]
		private bool _usingHorizontal;

		// Token: 0x040000D9 RID: 217
		[Token(Token = "0x40000D9")]
		[FieldOffset(Offset = "0xBB")]
		private bool _rebuildMesh;

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0xBC")]
		private int _rebuildMeshRequestFrame;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0xC0")]
		private ProfilerMarker _registerProfilerMarker;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0xC8")]
		private bool _hasCreatedProfilerMarker;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker _profilerMarkerRebuildMeshes;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker _profilerMarkerLateUpdate;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker _profilerMarkerUpdateAlive;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker _registerBillboardProfilerMarker;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker _getInterpolatedProbeProfilerMarker;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x28")]
		private static ProfilerMarker _setRebuildMeshProfilerMarker;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0xC9")]
		private bool _isVisible;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0xCC")]
		private int _vertexCount;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0xD0")]
		private int _registeredCount;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0xD8")]
		private SubBillboardData.CustomSphericalHarmonicsData shData;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0xE0")]
		private bool _isActive;

		// Token: 0x02000013 RID: 19
		[Token(Token = "0x2000013")]
		internal class CustomSphericalHarmonicsData
		{
			// Token: 0x060000CA RID: 202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000CA")]
			[Address(RVA = "0x30CAD50", Offset = "0x30C9350", VA = "0x1830CAD50")]
			public CustomSphericalHarmonicsData()
			{
			}

			// Token: 0x040000E8 RID: 232
			[Token(Token = "0x40000E8")]
			[FieldOffset(Offset = "0x10")]
			internal Color[] _ambientLighting;

			// Token: 0x040000E9 RID: 233
			[Token(Token = "0x40000E9")]
			[FieldOffset(Offset = "0x18")]
			internal Vector3[] _shDirections;
		}
	}
}
