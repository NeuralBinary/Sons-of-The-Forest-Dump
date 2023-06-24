using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace NWH.DWP2.WaterData
{
	// Token: 0x02000007 RID: 7
	[Token(Token = "0x2000007")]
	public class RaycastWaterDataProvider : WaterDataProvider
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x26FBCA0", Offset = "0x26FA2A0", VA = "0x1826FBCA0", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002110 File Offset: 0x00000310
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		public override bool SupportsWaterHeightQueries()
		{
			return default(bool);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002128 File Offset: 0x00000328
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public override bool SupportsWaterNormalQueries()
		{
			return default(bool);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002140 File Offset: 0x00000340
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "7")]
		public override bool SupportsWaterFlowQueries()
		{
			return default(bool);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x26FBEC0", Offset = "0x26FA4C0", VA = "0x1826FBEC0", Slot = "8")]
		public override void GetWaterHeights(ref Vector3[] points, ref float[] waterHeights)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x26FC6E0", Offset = "0x26FACE0", VA = "0x1826FC6E0", Slot = "10")]
		public override void GetWaterNormals(ref Vector3[] points, ref Vector3[] waterNormals)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x26FC740", Offset = "0x26FAD40", VA = "0x1826FC740", Slot = "12")]
		public virtual void OnDisable()
		{
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001A")]
		[Address(RVA = "0x26FC740", Offset = "0x26FAD40", VA = "0x1826FC740", Slot = "13")]
		public virtual void OnDestroy()
		{
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001B")]
		[Address(RVA = "0x26FC760", Offset = "0x26FAD60", VA = "0x1826FC760", Slot = "14")]
		public virtual void Deallocate()
		{
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001C")]
		[Address(RVA = "0x26FC840", Offset = "0x26FAE40", VA = "0x1826FC840")]
		public RaycastWaterDataProvider()
		{
		}

		// Token: 0x0400000E RID: 14
		[Token(Token = "0x400000E")]
		[FieldOffset(Offset = "0x38")]
		public int waterLayer;

		// Token: 0x0400000F RID: 15
		[Token(Token = "0x400000F")]
		[FieldOffset(Offset = "0x3C")]
		public int objectLayer;

		// Token: 0x04000010 RID: 16
		[Token(Token = "0x4000010")]
		[FieldOffset(Offset = "0x40")]
		public float raycastDistance;

		// Token: 0x04000011 RID: 17
		[Token(Token = "0x4000011")]
		[FieldOffset(Offset = "0x44")]
		public int commandsPerJob;

		// Token: 0x04000012 RID: 18
		[Token(Token = "0x4000012")]
		[FieldOffset(Offset = "0x48")]
		protected Vector3[] _normals;

		// Token: 0x04000013 RID: 19
		[Token(Token = "0x4000013")]
		[FieldOffset(Offset = "0x50")]
		protected Vector3 _flow;

		// Token: 0x04000014 RID: 20
		[Token(Token = "0x4000014")]
		[FieldOffset(Offset = "0x5C")]
		protected LayerMask _layerMask;

		// Token: 0x04000015 RID: 21
		[Token(Token = "0x4000015")]
		[FieldOffset(Offset = "0x60")]
		protected int _prevDataSize;

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x64")]
		protected Vector3 _rayDirection;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x70")]
		protected Vector3 _rayStartOffset;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x7C")]
		protected Ray _ray;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x94")]
		protected RaycastHit _hit;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0xC0")]
		protected Mesh _mesh;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0xC8")]
		protected Vector2 _uv4;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0xD0")]
		protected int _vertIndex;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0xD4")]
		protected Vector3 _vertDir;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0xE0")]
		protected Vector3 _tmp;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0xF0")]
		protected NativeArray<RaycastCommand> _raycastCommands;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x100")]
		protected NativeArray<RaycastHit> _raycastHits;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x110")]
		protected RaycastCommand _tmpCommand;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x140")]
		protected JobHandle _raycastJobHandle;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x150")]
		protected Vector3 _zeroVector;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x15C")]
		protected Vector3 _upVector;
	}
}
