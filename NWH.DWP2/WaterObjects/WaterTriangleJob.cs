using System;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Jobs;
using UnityEngine;

namespace NWH.DWP2.WaterObjects
{
	// Token: 0x02000016 RID: 22
	[Token(Token = "0x2000016")]
	public struct WaterTriangleJob : IJobParallelFor
	{
		// Token: 0x060000BF RID: 191 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x27091F0", Offset = "0x27077F0", VA = "0x1827091F0", Slot = "4")]
		public void Execute(int i)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000257C File Offset: 0x0000077C
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2709A90", Offset = "0x2708090", VA = "0x182709A90")]
		private Vector3 CalculateForces(Vector3 p0, Vector3 p1, Vector3 p2, float dist0, float dist1, float dist2, int index, out Vector3 center, out float area, out float distanceToSurface)
		{
			return default(Vector3);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x270A860", Offset = "0x2708E60", VA = "0x18270A860")]
		private void ThreeUnderWater(Vector3 p0, Vector3 p1, Vector3 p2, float dist0, float dist1, float dist2, int i0, int i1, int i2, int index)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x270AB30", Offset = "0x2709130", VA = "0x18270AB30")]
		private void TwoUnderWater(Vector3 p0, Vector3 p1, Vector3 p2, float dist0, float dist1, float dist2, int i0, int i1, int i2, int index)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x270B010", Offset = "0x2709610", VA = "0x18270B010")]
		private void OneUnderWater(Vector3 p0, Vector3 p1, Vector3 p2, float dist0, float dist1, float dist2, int i0, int i1, int i2, int index)
		{
		}

		// Token: 0x040000A5 RID: 165
		[Token(Token = "0x40000A5")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public Vector3 ZeroVector;

		// Token: 0x040000A6 RID: 166
		[Token(Token = "0x40000A6")]
		[FieldOffset(Offset = "0xC")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public Vector3 GlobalUpVector;

		// Token: 0x040000A7 RID: 167
		[Token(Token = "0x40000A7")]
		[FieldOffset(Offset = "0x18")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public bool CalculateBuoyantForces;

		// Token: 0x040000A8 RID: 168
		[Token(Token = "0x40000A8")]
		[FieldOffset(Offset = "0x19")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public bool CalculateDynamicForces;

		// Token: 0x040000A9 RID: 169
		[Token(Token = "0x40000A9")]
		[FieldOffset(Offset = "0x1A")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public bool CalculateSkinDrag;

		// Token: 0x040000AA RID: 170
		[Token(Token = "0x40000AA")]
		[FieldOffset(Offset = "0x1B")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public bool SimulateWaterNormals;

		// Token: 0x040000AB RID: 171
		[Token(Token = "0x40000AB")]
		[FieldOffset(Offset = "0x1C")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public bool SimulateWaterFlow;

		// Token: 0x040000AC RID: 172
		[Token(Token = "0x40000AC")]
		[FieldOffset(Offset = "0x20")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public Vector3 Gravity;

		// Token: 0x040000AD RID: 173
		[Token(Token = "0x40000AD")]
		[FieldOffset(Offset = "0x2C")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public float FluidDensity;

		// Token: 0x040000AE RID: 174
		[Token(Token = "0x40000AE")]
		[FieldOffset(Offset = "0x30")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public float DynamicForceFactor;

		// Token: 0x040000AF RID: 175
		[Token(Token = "0x40000AF")]
		[FieldOffset(Offset = "0x34")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public float DynamicForcePower;

		// Token: 0x040000B0 RID: 176
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x38")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public float SkinDrag;

		// Token: 0x040000B1 RID: 177
		[Token(Token = "0x40000B1")]
		[FieldOffset(Offset = "0x3C")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public float VelocityDotPower;

		// Token: 0x040000B2 RID: 178
		[Token(Token = "0x40000B2")]
		[FieldOffset(Offset = "0x40")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<int> ObjectIndices;

		// Token: 0x040000B3 RID: 179
		[Token(Token = "0x40000B3")]
		[FieldOffset(Offset = "0x50")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<float> ObjDynamicForceCoeffs;

		// Token: 0x040000B4 RID: 180
		[Token(Token = "0x40000B4")]
		[FieldOffset(Offset = "0x60")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<float> ObjDynamicForcePowerCoeffs;

		// Token: 0x040000B5 RID: 181
		[Token(Token = "0x40000B5")]
		[FieldOffset(Offset = "0x70")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<float> ObjSkinFrictionDragCoeffs;

		// Token: 0x040000B6 RID: 182
		[Token(Token = "0x40000B6")]
		[FieldOffset(Offset = "0x80")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<float> WaterHeights;

		// Token: 0x040000B7 RID: 183
		[Token(Token = "0x40000B7")]
		[FieldOffset(Offset = "0x90")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<Vector3> WaterFlows;

		// Token: 0x040000B8 RID: 184
		[Token(Token = "0x40000B8")]
		[FieldOffset(Offset = "0xA0")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<Vector3> WaterNormals;

		// Token: 0x040000B9 RID: 185
		[Token(Token = "0x40000B9")]
		[FieldOffset(Offset = "0xB0")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<Vector3> WorldVertices;

		// Token: 0x040000BA RID: 186
		[Token(Token = "0x40000BA")]
		[FieldOffset(Offset = "0xC0")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<int> Triangles;

		// Token: 0x040000BB RID: 187
		[Token(Token = "0x40000BB")]
		[FieldOffset(Offset = "0xD0")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<Vector3> ObjRigidbodyCoMs;

		// Token: 0x040000BC RID: 188
		[Token(Token = "0x40000BC")]
		[FieldOffset(Offset = "0xE0")]
		[NativeDisableParallelForRestriction]
		[ReadOnly]
		public NativeArray<Vector3> ObjRigidbodyLinearVels;

		// Token: 0x040000BD RID: 189
		[Token(Token = "0x40000BD")]
		[FieldOffset(Offset = "0xF0")]
		[ReadOnly]
		[NativeDisableParallelForRestriction]
		public NativeArray<Vector3> ObjRigidbodyAngularVels;

		// Token: 0x040000BE RID: 190
		[Token(Token = "0x40000BE")]
		[FieldOffset(Offset = "0x100")]
		[NativeDisableParallelForRestriction]
		public NativeArray<Vector3> P0s;

		// Token: 0x040000BF RID: 191
		[Token(Token = "0x40000BF")]
		[FieldOffset(Offset = "0x110")]
		public NativeArray<byte> States;

		// Token: 0x040000C0 RID: 192
		[Token(Token = "0x40000C0")]
		[FieldOffset(Offset = "0x120")]
		public NativeArray<Vector3> ResultForces;

		// Token: 0x040000C1 RID: 193
		[Token(Token = "0x40000C1")]
		[FieldOffset(Offset = "0x130")]
		public NativeArray<Vector3> ResultPoints;

		// Token: 0x040000C2 RID: 194
		[Token(Token = "0x40000C2")]
		[FieldOffset(Offset = "0x140")]
		public NativeArray<float> Areas;

		// Token: 0x040000C3 RID: 195
		[Token(Token = "0x40000C3")]
		[FieldOffset(Offset = "0x150")]
		public NativeArray<Vector3> Normals;

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x160")]
		public NativeArray<Vector3> Velocities;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x170")]
		public NativeArray<float> Distances;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x180")]
		private int _vertIndex0;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x184")]
		private int _vertIndex1;

		// Token: 0x040000C8 RID: 200
		[Token(Token = "0x40000C8")]
		[FieldOffset(Offset = "0x188")]
		private int _vertIndex2;
	}
}
