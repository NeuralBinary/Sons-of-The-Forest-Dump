using System;
using Crest;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterData
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	public class CrestWaterDataProvider : WaterDataProvider
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000005")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		public override bool SupportsWaterHeightQueries()
		{
			return default(bool);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002080 File Offset: 0x00000280
		[Token(Token = "0x6000006")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "6")]
		public override bool SupportsWaterNormalQueries()
		{
			return default(bool);
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002098 File Offset: 0x00000298
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public override bool SupportsWaterFlowQueries()
		{
			return default(bool);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x26FB4C0", Offset = "0x26F9AC0", VA = "0x1826FB4C0", Slot = "4")]
		public override void Awake()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x26FB6E0", Offset = "0x26F9CE0", VA = "0x1826FB6E0", Slot = "8")]
		public override void GetWaterHeights(ref Vector3[] points, ref float[] waterHeights)
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x26FB970", Offset = "0x26F9F70", VA = "0x1826FB970", Slot = "10")]
		public override void GetWaterNormals(ref Vector3[] points, ref Vector3[] waterNormals)
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x26FB9D0", Offset = "0x26F9FD0", VA = "0x1826FB9D0", Slot = "9")]
		public override void GetWaterFlows(ref Vector3[] points, ref Vector3[] waterFlows)
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000020B0 File Offset: 0x000002B0
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x26FBA50", Offset = "0x26FA050", VA = "0x1826FBA50", Slot = "11")]
		public override float GetWaterHeightSingle(Vector3 point)
		{
			return 0f;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x26FBB30", Offset = "0x26FA130", VA = "0x1826FBB30")]
		public CrestWaterDataProvider()
		{
		}

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x38")]
		private OceanRenderer _oceanRenderer;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x40")]
		private ICollProvider _collProvider;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x48")]
		private IFlowProvider _flowProvider;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x50")]
		private int _prevArraySize;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x58")]
		private Vector3[] _crestQueryHashArray;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x60")]
		private Vector3[] _normals;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x68")]
		private int _hash;
	}
}
