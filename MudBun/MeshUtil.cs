using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000133 RID: 307
	[Token(Token = "0x2000133")]
	[BurstCompile]
	public static class MeshUtil
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000799")]
		[Address(RVA = "0x24459E0", Offset = "0x2443FE0", VA = "0x1824459E0")]
		[BurstCompile]
		public static void Quantize(ref float2 v, float step, out float2 quantized)
		{
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079A")]
		[Address(RVA = "0x2445A50", Offset = "0x2444050", VA = "0x182445A50")]
		[BurstCompile]
		public static void Quantize(ref float3 v, float step, out float3 quantized)
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079B")]
		[Address(RVA = "0x2445AC0", Offset = "0x24440C0", VA = "0x182445AC0")]
		public static void Weld(Mesh mesh, int textureUvIndex = -1)
		{
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079C")]
		[Address(RVA = "0x2446980", Offset = "0x2444F80", VA = "0x182446980")]
		public static void UpdateRenderBoxProxy(ref Mesh mesh, Aabb bounds)
		{
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x0600079D RID: 1949 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170000E7")]
		public static Mesh InvertedUnitBox
		{
			[Token(Token = "0x600079D")]
			[Address(RVA = "0x2446FB0", Offset = "0x24455B0", VA = "0x182446FB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600079F RID: 1951 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600079F")]
		[Address(RVA = "0x2447840", Offset = "0x2445E40", VA = "0x182447840")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quantize$BurstManaged(ref float2 v, float step, out float2 quantized)
		{
		}

		// Token: 0x060007A0 RID: 1952 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007A0")]
		[Address(RVA = "0x2447A40", Offset = "0x2446040", VA = "0x182447A40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Quantize$BurstManaged(ref float3 v, float step, out float3 quantized)
		{
		}

		// Token: 0x04000490 RID: 1168
		[Token(Token = "0x4000490")]
		[FieldOffset(Offset = "0x0")]
		public static int EmissionHashUvIndex;

		// Token: 0x04000491 RID: 1169
		[Token(Token = "0x4000491")]
		[FieldOffset(Offset = "0x4")]
		public static int MetallicSmoothnessUvIndex;

		// Token: 0x04000492 RID: 1170
		[Token(Token = "0x4000492")]
		[FieldOffset(Offset = "0x8")]
		public static readonly float PositionTolerance;

		// Token: 0x04000493 RID: 1171
		[Token(Token = "0x4000493")]
		[FieldOffset(Offset = "0xC")]
		public static readonly float NormalTolerance;

		// Token: 0x04000494 RID: 1172
		[Token(Token = "0x4000494")]
		[FieldOffset(Offset = "0x10")]
		public static readonly float UvTolerance;

		// Token: 0x04000495 RID: 1173
		[Token(Token = "0x4000495")]
		[FieldOffset(Offset = "0x14")]
		public static readonly float PositionToleranceSqr;

		// Token: 0x04000496 RID: 1174
		[Token(Token = "0x4000496")]
		[FieldOffset(Offset = "0x18")]
		public static readonly float NormalToleratnceSqr;

		// Token: 0x04000497 RID: 1175
		[Token(Token = "0x4000497")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly float UvToleratnceSqr;

		// Token: 0x04000498 RID: 1176
		[Token(Token = "0x4000498")]
		[FieldOffset(Offset = "0x20")]
		private static readonly Vector3[] s_aRenderBoxProxyVert;

		// Token: 0x04000499 RID: 1177
		[Token(Token = "0x4000499")]
		[FieldOffset(Offset = "0x28")]
		private static readonly int[] s_aRenderBoxProxyIndex;

		// Token: 0x0400049A RID: 1178
		[Token(Token = "0x400049A")]
		[FieldOffset(Offset = "0x30")]
		private static Vector3[] s_aRenderBoxProxyVertBuffer;

		// Token: 0x0400049B RID: 1179
		[Token(Token = "0x400049B")]
		[FieldOffset(Offset = "0x38")]
		private static Mesh s_invertedUnitBoxMesh;

		// Token: 0x02000134 RID: 308
		[Token(Token = "0x2000134")]
		public struct VertKey : IEquatable<MeshUtil.VertKey>
		{
			// Token: 0x060007A1 RID: 1953 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007A1")]
			[Address(RVA = "0x244A280", Offset = "0x2448880", VA = "0x18244A280")]
			public VertKey(Vector3 pos, Vector3 norm, Vector2 uv)
			{
			}

			// Token: 0x060007A2 RID: 1954 RVA: 0x00005A48 File Offset: 0x00003C48
			[Token(Token = "0x60007A2")]
			[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580", Slot = "2")]
			public override int GetHashCode()
			{
				return 0;
			}

			// Token: 0x060007A3 RID: 1955 RVA: 0x00005A60 File Offset: 0x00003C60
			[Token(Token = "0x60007A3")]
			[Address(RVA = "0x244A3E0", Offset = "0x24489E0", VA = "0x18244A3E0")]
			private int CalcHash()
			{
				return 0;
			}

			// Token: 0x060007A4 RID: 1956 RVA: 0x00005A78 File Offset: 0x00003C78
			[Token(Token = "0x60007A4")]
			[Address(RVA = "0x244A4F0", Offset = "0x2448AF0", VA = "0x18244A4F0", Slot = "0")]
			public override bool Equals(object obj)
			{
				return default(bool);
			}

			// Token: 0x060007A5 RID: 1957 RVA: 0x00005A90 File Offset: 0x00003C90
			[Token(Token = "0x60007A5")]
			[Address(RVA = "0x244A650", Offset = "0x2448C50", VA = "0x18244A650", Slot = "4")]
			public bool Equals(MeshUtil.VertKey other)
			{
				return default(bool);
			}

			// Token: 0x0400049C RID: 1180
			[Token(Token = "0x400049C")]
			[FieldOffset(Offset = "0x0")]
			public Vector3 Pos;

			// Token: 0x0400049D RID: 1181
			[Token(Token = "0x400049D")]
			[FieldOffset(Offset = "0xC")]
			public Vector3 Norm;

			// Token: 0x0400049E RID: 1182
			[Token(Token = "0x400049E")]
			[FieldOffset(Offset = "0x18")]
			public Vector2 Uv;

			// Token: 0x0400049F RID: 1183
			[Token(Token = "0x400049F")]
			[FieldOffset(Offset = "0x20")]
			private readonly int hashCode;
		}

		// Token: 0x02000135 RID: 309
		// (Invoke) Token: 0x060007A7 RID: 1959
		[Token(Token = "0x2000135")]
		public delegate void Quantize_00000363$PostfixBurstDelegate(ref float2 v, float step, out float2 quantized);

		// Token: 0x02000136 RID: 310
		[Token(Token = "0x2000136")]
		internal static class Quantize_00000363$BurstDirectCall
		{
			// Token: 0x060007AA RID: 1962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007AA")]
			[Address(RVA = "0x244A910", Offset = "0x2448F10", VA = "0x18244A910")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060007AB RID: 1963 RVA: 0x00005AA8 File Offset: 0x00003CA8
			[Token(Token = "0x60007AB")]
			[Address(RVA = "0x244AA40", Offset = "0x2449040", VA = "0x18244AA40")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060007AC RID: 1964 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007AC")]
			[Address(RVA = "0x244ABA0", Offset = "0x24491A0", VA = "0x18244ABA0")]
			public static void Constructor()
			{
			}

			// Token: 0x060007AD RID: 1965 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007AD")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060007AF RID: 1967 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007AF")]
			[Address(RVA = "0x244AC50", Offset = "0x2449250", VA = "0x18244AC50")]
			public static void Invoke(ref float2 v, float step, out float2 quantized)
			{
			}

			// Token: 0x040004A0 RID: 1184
			[Token(Token = "0x40004A0")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040004A1 RID: 1185
			[Token(Token = "0x40004A1")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000137 RID: 311
		// (Invoke) Token: 0x060007B1 RID: 1969
		[Token(Token = "0x2000137")]
		public delegate void Quantize_00000364$PostfixBurstDelegate(ref float3 v, float step, out float3 quantized);

		// Token: 0x02000138 RID: 312
		[Token(Token = "0x2000138")]
		internal static class Quantize_00000364$BurstDirectCall
		{
			// Token: 0x060007B4 RID: 1972 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B4")]
			[Address(RVA = "0x244AF30", Offset = "0x2449530", VA = "0x18244AF30")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060007B5 RID: 1973 RVA: 0x00005AC0 File Offset: 0x00003CC0
			[Token(Token = "0x60007B5")]
			[Address(RVA = "0x244B060", Offset = "0x2449660", VA = "0x18244B060")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060007B6 RID: 1974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B6")]
			[Address(RVA = "0x244B1C0", Offset = "0x24497C0", VA = "0x18244B1C0")]
			public static void Constructor()
			{
			}

			// Token: 0x060007B7 RID: 1975 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B7")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060007B9 RID: 1977 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60007B9")]
			[Address(RVA = "0x244B270", Offset = "0x2449870", VA = "0x18244B270")]
			public static void Invoke(ref float3 v, float step, out float3 quantized)
			{
			}

			// Token: 0x040004A2 RID: 1186
			[Token(Token = "0x40004A2")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040004A3 RID: 1187
			[Token(Token = "0x40004A3")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
