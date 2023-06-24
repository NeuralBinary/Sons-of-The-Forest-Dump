using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.WaterData
{
	// Token: 0x02000008 RID: 8
	[Token(Token = "0x2000008")]
	public abstract class WaterDataProvider : MonoBehaviour
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600001D")]
		[Address(RVA = "0x26FC8A0", Offset = "0x26FAEA0", VA = "0x1826FC8A0", Slot = "4")]
		public virtual void Awake()
		{
		}

		// Token: 0x0600001E RID: 30
		[Token(Token = "0x600001E")]
		public abstract bool SupportsWaterHeightQueries();

		// Token: 0x0600001F RID: 31
		[Token(Token = "0x600001F")]
		public abstract bool SupportsWaterNormalQueries();

		// Token: 0x06000020 RID: 32
		[Token(Token = "0x6000020")]
		public abstract bool SupportsWaterFlowQueries();

		// Token: 0x06000021 RID: 33 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000021")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "8")]
		public virtual void GetWaterHeights(ref Vector3[] points, ref float[] waterHeights)
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000022")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "9")]
		public virtual void GetWaterFlows(ref Vector3[] points, ref Vector3[] waterFlows)
		{
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000023")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160", Slot = "10")]
		public virtual void GetWaterNormals(ref Vector3[] points, ref Vector3[] waterNormals)
		{
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000024")]
		[Address(RVA = "0x26FCA30", Offset = "0x26FB030", VA = "0x1826FCA30")]
		public void GetWaterHeightsFlowsNormals(ref Vector3[] points, ref float[] waterHeights, ref Vector3[] waterFlows, ref Vector3[] waterNormals)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002158 File Offset: 0x00000358
		[Token(Token = "0x6000025")]
		[Address(RVA = "0x26FCAE0", Offset = "0x26FB0E0", VA = "0x1826FCAE0", Slot = "11")]
		public virtual float GetWaterHeightSingle(Vector3 point)
		{
			return 0f;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002170 File Offset: 0x00000370
		[Token(Token = "0x6000026")]
		[Address(RVA = "0x26FCB60", Offset = "0x26FB160", VA = "0x1826FCB60")]
		public bool PointInWater(Vector3 worldPoint)
		{
			return default(bool);
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002188 File Offset: 0x00000388
		[Token(Token = "0x6000027")]
		[Address(RVA = "0x26FCBA0", Offset = "0x26FB1A0", VA = "0x1826FCBA0")]
		public float GetWaterHeight(Vector3 worldPoint)
		{
			return 0f;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000028")]
		[Address(RVA = "0xAA91A0", Offset = "0xAA77A0", VA = "0x180AA91A0")]
		protected WaterDataProvider()
		{
		}

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		public static WaterDataProvider Instance;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x20")]
		public bool useWaterNormals;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x21")]
		public bool useWaterFlow;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x28")]
		protected Vector3[] _singlePointArray;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x30")]
		protected float[] _singleHeightArray;
	}
}
