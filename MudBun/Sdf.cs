using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;

namespace MudBun
{
	// Token: 0x020000B4 RID: 180
	[Token(Token = "0x20000B4")]
	[BurstCompile]
	public static class Sdf
	{
		// Token: 0x060004BE RID: 1214 RVA: 0x00004980 File Offset: 0x00002B80
		[Token(Token = "0x60004BE")]
		[Address(RVA = "0x24118D0", Offset = "0x240FED0", VA = "0x1824118D0")]
		[BurstCompile]
		public unsafe static float DummyEvaluateSdf(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004BF")]
		[Address(RVA = "0x2411950", Offset = "0x240FF50", VA = "0x182411950")]
		public static void InitEvalMap()
		{
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C0")]
		[Address(RVA = "0x2412320", Offset = "0x2410920", VA = "0x182412320")]
		public static void DisposeEvalMap()
		{
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004C1")]
		[Address(RVA = "0x2412430", Offset = "0x2410A30", VA = "0x182412430")]
		public static void RegisterSdfBrushEvalFunc(int brushType, Sdf.SdfBrushEvalFunc func)
		{
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x00004998 File Offset: 0x00002B98
		[Token(Token = "0x60004C2")]
		[Address(RVA = "0x24128C0", Offset = "0x2410EC0", VA = "0x1824128C0")]
		[BurstCompile]
		public static float DistBlendWeight(float distA, float distB, float strength)
		{
			return 0f;
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x000049B0 File Offset: 0x00002BB0
		[Token(Token = "0x60004C3")]
		[Address(RVA = "0x2412940", Offset = "0x2410F40", VA = "0x182412940")]
		[BurstCompile]
		public static float UniSmooth(float a, float b, float k)
		{
			return 0f;
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x000049C8 File Offset: 0x00002BC8
		[Token(Token = "0x60004C4")]
		[Address(RVA = "0x24129C0", Offset = "0x2410FC0", VA = "0x1824129C0")]
		[BurstCompile]
		public static float SubSmooth(float a, float b, float k)
		{
			return 0f;
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x000049E0 File Offset: 0x00002BE0
		[Token(Token = "0x60004C5")]
		[Address(RVA = "0x2412A40", Offset = "0x2411040", VA = "0x182412A40")]
		[BurstCompile]
		public static float IntSmooth(float a, float b, float k)
		{
			return 0f;
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x000049F8 File Offset: 0x00002BF8
		[Token(Token = "0x60004C6")]
		[Address(RVA = "0x2412AC0", Offset = "0x24110C0", VA = "0x182412AC0")]
		[BurstCompile]
		public static float Sphere(in float3 p, float r)
		{
			return 0f;
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x00004A10 File Offset: 0x00002C10
		[Token(Token = "0x60004C7")]
		[Address(RVA = "0x2412B20", Offset = "0x2411120", VA = "0x182412B20")]
		[BurstCompile]
		public static float Ellipsoid(in float3 p, in float3 h)
		{
			return 0f;
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x00004A28 File Offset: 0x00002C28
		[Token(Token = "0x60004C8")]
		[Address(RVA = "0x2412B80", Offset = "0x2411180", VA = "0x182412B80")]
		[BurstCompile]
		public static float Box(in float3 p, in float3 h, float r = 0f)
		{
			return 0f;
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x00004A40 File Offset: 0x00002C40
		[Token(Token = "0x60004C9")]
		[Address(RVA = "0x2412BF0", Offset = "0x24111F0", VA = "0x182412BF0")]
		[BurstCompile]
		public static float Capsule(in float3 p, in float3 a, in float3 b, float r)
		{
			return 0f;
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x00004A58 File Offset: 0x00002C58
		[Token(Token = "0x60004CA")]
		[Address(RVA = "0x2412C70", Offset = "0x2411270", VA = "0x182412C70")]
		[BurstCompile]
		public static float CappedCone(in float3 p, float h, float r1, float r2, float r = 0f)
		{
			return 0f;
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x00004A70 File Offset: 0x00002C70
		[Token(Token = "0x60004CB")]
		[Address(RVA = "0x2412D00", Offset = "0x2411300", VA = "0x182412D00")]
		[BurstCompile]
		public static float RoundCone(in float3 p, in float3 a, in float3 b, float r1, float r2)
		{
			return 0f;
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x00004A88 File Offset: 0x00002C88
		[Token(Token = "0x60004CC")]
		[Address(RVA = "0x2412D80", Offset = "0x2411380", VA = "0x182412D80")]
		[BurstCompile]
		public static float Cylinder(in float3 p, float h, float r, float rr = 0f)
		{
			return 0f;
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x00004AA0 File Offset: 0x00002CA0
		[Token(Token = "0x60004CD")]
		[Address(RVA = "0x2412E10", Offset = "0x2411410", VA = "0x182412E10")]
		[BurstCompile]
		public static float Torus(in float3 p, float h, float r1, float r2)
		{
			return 0f;
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x00004AB8 File Offset: 0x00002CB8
		[Token(Token = "0x60004CE")]
		[Address(RVA = "0x2412EA0", Offset = "0x24114A0", VA = "0x182412EA0")]
		[BurstCompile]
		public static float SolidAngle(in float3 p, in float2 c, float r, float rr = 0f)
		{
			return 0f;
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004CF")]
		[Address(RVA = "0x2412F30", Offset = "0x2411530", VA = "0x182412F30")]
		[BurstCompile]
		public static void Segment(in float3 p, in float3 a, in float3 b, out float2 ret)
		{
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D0")]
		[Address(RVA = "0x2412FB0", Offset = "0x24115B0", VA = "0x182412FB0")]
		[BurstCompile]
		public static void Bezier(in float3 pos, in float3 A, in float3 B, in float3 C, out float2 ret)
		{
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x00004AD0 File Offset: 0x00002CD0
		[Token(Token = "0x60004D1")]
		[Address(RVA = "0x2413030", Offset = "0x2411630", VA = "0x182413030")]
		[BurstCompile]
		public static float Noise(int type, in float3 p, in float3 boundsMin, in float3 boundsMax, in float3 offset, in float3 size, float threshold, int numOctaves, float octaveOffsetFactor, in float3 period)
		{
			return 0f;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x00004AE8 File Offset: 0x00002CE8
		[Token(Token = "0x60004D2")]
		[Address(RVA = "0x24130C0", Offset = "0x24116C0", VA = "0x1824130C0")]
		[BurstCompile]
		public static float Rand(float s)
		{
			return 0f;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x00004B00 File Offset: 0x00002D00
		[Token(Token = "0x60004D3")]
		[Address(RVA = "0x2413110", Offset = "0x2411710", VA = "0x182413110")]
		[BurstCompile]
		public static float Rand(in float2 s)
		{
			return 0f;
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x00004B18 File Offset: 0x00002D18
		[Token(Token = "0x60004D4")]
		[Address(RVA = "0x2413160", Offset = "0x2411760", VA = "0x182413160")]
		[BurstCompile]
		public static float Rand(in float3 s)
		{
			return 0f;
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D5")]
		[Address(RVA = "0x24131B0", Offset = "0x24117B0", VA = "0x1824131B0")]
		[BurstCompile]
		public static void Mod(float x, float y, out float ret)
		{
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D6")]
		[Address(RVA = "0x2413220", Offset = "0x2411820", VA = "0x182413220")]
		[BurstCompile]
		public static void Mod(in float2 x, in float2 y, out float2 ret)
		{
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D7")]
		[Address(RVA = "0x2413290", Offset = "0x2411890", VA = "0x182413290")]
		[BurstCompile]
		public static void Mod(in float3 x, in float3 y, out float3 ret)
		{
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D8")]
		[Address(RVA = "0x2413300", Offset = "0x2411900", VA = "0x182413300")]
		[BurstCompile]
		public static void Mod(in float4 x, in float4 y, out float4 ret)
		{
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004D9")]
		[Address(RVA = "0x2413370", Offset = "0x2411970", VA = "0x182413370")]
		[BurstCompile]
		public static void Mod289(in float2 x, out float2 ret)
		{
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DA")]
		[Address(RVA = "0x24133D0", Offset = "0x24119D0", VA = "0x1824133D0")]
		[BurstCompile]
		public static void Mod289(in float3 x, out float3 ret)
		{
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DB")]
		[Address(RVA = "0x2413430", Offset = "0x2411A30", VA = "0x182413430")]
		[BurstCompile]
		public static void Mod289(in float4 x, out float4 ret)
		{
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DC")]
		[Address(RVA = "0x2413490", Offset = "0x2411A90", VA = "0x182413490")]
		[BurstCompile]
		public static void Permute(in float3 x, out float3 ret)
		{
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DD")]
		[Address(RVA = "0x24134F0", Offset = "0x2411AF0", VA = "0x1824134F0")]
		[BurstCompile]
		public static void Permute(in float4 x, out float4 ret)
		{
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DE")]
		[Address(RVA = "0x2413550", Offset = "0x2411B50", VA = "0x182413550")]
		[BurstCompile]
		public static void TaylorInvSqrt(in float3 r, out float3 ret)
		{
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004DF")]
		[Address(RVA = "0x24135B0", Offset = "0x2411BB0", VA = "0x1824135B0")]
		[BurstCompile]
		public static void TaylorInvSqrt(in float4 r, out float4 ret)
		{
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E0")]
		[Address(RVA = "0x2413610", Offset = "0x2411C10", VA = "0x182413610")]
		[BurstCompile]
		public static void Fade(in float2 t, out float2 ret)
		{
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E1")]
		[Address(RVA = "0x2413670", Offset = "0x2411C70", VA = "0x182413670")]
		[BurstCompile]
		public static void Fade(in float3 t, out float3 ret)
		{
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x00004B30 File Offset: 0x00002D30
		[Token(Token = "0x60004E2")]
		[Address(RVA = "0x24136D0", Offset = "0x2411CD0", VA = "0x1824136D0")]
		[BurstCompile]
		public static int Index(in int3 id, in int3 dimension)
		{
			return 0;
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004E3")]
		[Address(RVA = "0x2413730", Offset = "0x2411D30", VA = "0x182413730")]
		[BurstCompile]
		public static void UnitTriWave(in float3 x, out float3 ret)
		{
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x00004B48 File Offset: 0x00002D48
		[Token(Token = "0x60004E4")]
		[Address(RVA = "0x2413790", Offset = "0x2411D90", VA = "0x182413790")]
		[BurstCompile]
		public static float PNoise(in float3 P, in float3 rep)
		{
			return 0f;
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x00004B60 File Offset: 0x00002D60
		[Token(Token = "0x60004E5")]
		[Address(RVA = "0x24137F0", Offset = "0x2411DF0", VA = "0x1824137F0")]
		[BurstCompile]
		public static float PNoise(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor, in float3 period)
		{
			return 0f;
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x00004B78 File Offset: 0x00002D78
		[Token(Token = "0x60004E6")]
		[Address(RVA = "0x2413870", Offset = "0x2411E70", VA = "0x182413870")]
		[BurstCompile]
		public static float CachedNoise(in float3 s)
		{
			return 0f;
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x00004B90 File Offset: 0x00002D90
		[Token(Token = "0x60004E7")]
		[Address(RVA = "0x24138C0", Offset = "0x2411EC0", VA = "0x1824138C0")]
		[BurstCompile]
		public static float CachedNoise(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor)
		{
			return 0f;
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x00004BA8 File Offset: 0x00002DA8
		[Token(Token = "0x60004E8")]
		[Address(RVA = "0x2413940", Offset = "0x2411F40", VA = "0x182413940")]
		[BurstCompile]
		public static float TriangleNoise(in float3 p)
		{
			return 0f;
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x00004BC0 File Offset: 0x00002DC0
		[Token(Token = "0x60004E9")]
		[Address(RVA = "0x2413990", Offset = "0x2411F90", VA = "0x182413990")]
		[BurstCompile]
		public static float TriangleNoise(in float3 s, in float3 offset, int numOctaves, in float octaveOffsetFactor)
		{
			return 0f;
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EA")]
		[Address(RVA = "0x2413A10", Offset = "0x2412010", VA = "0x182413A10")]
		internal static void InitAsyncJobData()
		{
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60004EB")]
		[Address(RVA = "0x2413E10", Offset = "0x2412410", VA = "0x182413E10")]
		internal static void DisposeAsyncJobData()
		{
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x00004BD8 File Offset: 0x00002DD8
		[Token(Token = "0x60004EC")]
		[Address(RVA = "0x2413F60", Offset = "0x2412560", VA = "0x182413F60")]
		private static int GetJobBatchSize(int numJobs)
		{
			return 0;
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x00004BF0 File Offset: 0x00002DF0
		[Token(Token = "0x60004ED")]
		[Address(RVA = "0x2413FD0", Offset = "0x24125D0", VA = "0x182413FD0")]
		public static Sdf.EvalJobHandle EvaluateSdf(bool async, MudRendererBase renderer, NativeArray<Vector3> samples, NativeArray<Sdf.Result> results, NativeArray<SdfBrush> aBrush, int numBrushes, NativeArray<SdfBrushMaterial> aMaterial, NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, float maxDistance, bool computeMaterials, float surfaceShift)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x00004C08 File Offset: 0x00002E08
		[Token(Token = "0x60004EE")]
		[Address(RVA = "0x2414630", Offset = "0x2412C30", VA = "0x182414630")]
		public static Sdf.EvalJobHandle EvaluateNormal(bool async, MudRendererBase renderer, NativeArray<Vector3> samples, NativeArray<Sdf.Result> results, NativeArray<SdfBrush> aBrush, int numBrushes, NativeArray<SdfBrushMaterial> aMaterial, NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, float maxDistance, float surfaceShift, float h)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x00004C20 File Offset: 0x00002E20
		[Token(Token = "0x60004EF")]
		[Address(RVA = "0x2414C90", Offset = "0x2413290", VA = "0x182414C90")]
		public static Sdf.EvalJobHandle EvaluateSdfAndNormal(bool async, MudRendererBase renderer, NativeArray<Vector3> samples, NativeArray<Sdf.Result> sdfResults, NativeArray<SdfBrush> aBrush, int numBrushes, NativeArray<SdfBrushMaterial> aMaterial, NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, float maxDistance, bool computeMaterials, float surfaceShift, float h)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x00004C38 File Offset: 0x00002E38
		[Token(Token = "0x60004F0")]
		[Address(RVA = "0x24152F0", Offset = "0x24138F0", VA = "0x1824152F0")]
		public static Sdf.EvalJobHandle EvaluateRaycast(bool async, MudRendererBase renderer, NativeArray<Sdf.Ray> casts, NativeArray<Sdf.Contact> results, float castMargin, NativeArray<SdfBrush> aBrush, int numBrushes, NativeArray<SdfBrushMaterial> aMaterial, NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, bool computeMaterials, int maxSteps, float surfaceShift, bool forceZeroBlendUnion)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x00004C50 File Offset: 0x00002E50
		[Token(Token = "0x60004F1")]
		[Address(RVA = "0x2415970", Offset = "0x2413F70", VA = "0x182415970")]
		public static Sdf.EvalJobHandle EvaluateRaycastChain(bool async, MudRendererBase renderer, NativeArray<Vector3> castChain, NativeArray<Sdf.Contact> contact, float castMargin, NativeArray<SdfBrush> aBrush, int numBrushes, NativeArray<SdfBrushMaterial> aMaterial, NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, bool computeMaterials, int maxSteps, float surfaceShift)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x00004C68 File Offset: 0x00002E68
		[Token(Token = "0x60004F2")]
		[Address(RVA = "0x2415FC0", Offset = "0x24145C0", VA = "0x182415FC0")]
		public static Sdf.EvalJobHandle EvaluateSnapToSurface(bool async, MudRendererBase renderer, NativeArray<Vector3> samples, NativeArray<Sdf.Contact> results, float castMargin, NativeArray<SdfBrush> aBrush, int numBrushes, NativeArray<SdfBrushMaterial> aMaterial, NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, bool computeMaterials, float maxSurfaceDistance, int maxSteps, float surfaceShift)
		{
			return default(Sdf.EvalJobHandle);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00004C80 File Offset: 0x00002E80
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x24166C0", Offset = "0x2414CC0", VA = "0x1824166C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe static float DummyEvaluateSdf$BurstManaged(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
		{
			return 0f;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00004C98 File Offset: 0x00002E98
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x24166D0", Offset = "0x2414CD0", VA = "0x1824166D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DistBlendWeight$BurstManaged(float distA, float distB, float strength)
		{
			return 0f;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00004CB0 File Offset: 0x00002EB0
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x24167E0", Offset = "0x2414DE0", VA = "0x1824167E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float UniSmooth$BurstManaged(float a, float b, float k)
		{
			return 0f;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00004CC8 File Offset: 0x00002EC8
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2416910", Offset = "0x2414F10", VA = "0x182416910")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SubSmooth$BurstManaged(float a, float b, float k)
		{
			return 0f;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00004CE0 File Offset: 0x00002EE0
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2416A40", Offset = "0x2415040", VA = "0x182416A40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float IntSmooth$BurstManaged(float a, float b, float k)
		{
			return 0f;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00004CF8 File Offset: 0x00002EF8
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2416B70", Offset = "0x2415170", VA = "0x182416B70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Sphere$BurstManaged(in float3 p, float r)
		{
			return 0f;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x00004D10 File Offset: 0x00002F10
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2416BD0", Offset = "0x24151D0", VA = "0x182416BD0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Ellipsoid$BurstManaged(in float3 p, in float3 h)
		{
			return 0f;
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x00004D28 File Offset: 0x00002F28
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2416D80", Offset = "0x2415380", VA = "0x182416D80")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Box$BurstManaged(in float3 p, in float3 h, float r = 0f)
		{
			return 0f;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x00004D40 File Offset: 0x00002F40
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2417030", Offset = "0x2415630", VA = "0x182417030")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Capsule$BurstManaged(in float3 p, in float3 a, in float3 b, float r)
		{
			return 0f;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x00004D58 File Offset: 0x00002F58
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2417200", Offset = "0x2415800", VA = "0x182417200")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CappedCone$BurstManaged(in float3 p, float h, float r1, float r2, float r = 0f)
		{
			return 0f;
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x00004D70 File Offset: 0x00002F70
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2417410", Offset = "0x2415A10", VA = "0x182417410")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float RoundCone$BurstManaged(in float3 p, in float3 a, in float3 b, float r1, float r2)
		{
			return 0f;
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00004D88 File Offset: 0x00002F88
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x24176D0", Offset = "0x2415CD0", VA = "0x1824176D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Cylinder$BurstManaged(in float3 p, float h, float r, float rr = 0f)
		{
			return 0f;
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x00004DA0 File Offset: 0x00002FA0
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x2417830", Offset = "0x2415E30", VA = "0x182417830")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Torus$BurstManaged(in float3 p, float h, float r1, float r2)
		{
			return 0f;
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x00004DB8 File Offset: 0x00002FB8
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x24178E0", Offset = "0x2415EE0", VA = "0x1824178E0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float SolidAngle$BurstManaged(in float3 p, in float2 c, float r, float rr = 0f)
		{
			return 0f;
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x2417AA0", Offset = "0x24160A0", VA = "0x182417AA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Segment$BurstManaged(in float3 p, in float3 a, in float3 b, out float2 ret)
		{
		}

		// Token: 0x06000503 RID: 1283 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000503")]
		[Address(RVA = "0x2417C30", Offset = "0x2416230", VA = "0x182417C30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Bezier$BurstManaged(in float3 pos, in float3 A, in float3 B, in float3 C, out float2 ret)
		{
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x24182B0", Offset = "0x24168B0", VA = "0x1824182B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Noise$BurstManaged(int type, in float3 p, in float3 boundsMin, in float3 boundsMax, in float3 offset, in float3 size, float threshold, int numOctaves, float octaveOffsetFactor, in float3 period)
		{
			return 0f;
		}

		// Token: 0x06000505 RID: 1285 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x24185F0", Offset = "0x2416BF0", VA = "0x1824185F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Rand$BurstManaged(float s)
		{
			return 0f;
		}

		// Token: 0x06000506 RID: 1286 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x24186B0", Offset = "0x2416CB0", VA = "0x1824186B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Rand$BurstManaged(in float2 s)
		{
			return 0f;
		}

		// Token: 0x06000507 RID: 1287 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x24187B0", Offset = "0x2416DB0", VA = "0x1824187B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Rand$BurstManaged(in float3 s)
		{
			return 0f;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x24188C0", Offset = "0x2416EC0", VA = "0x1824188C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod$BurstManaged(float x, float y, out float ret)
		{
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2418900", Offset = "0x2416F00", VA = "0x182418900")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod$BurstManaged(in float2 x, in float2 y, out float2 ret)
		{
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x24189B0", Offset = "0x2416FB0", VA = "0x1824189B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod$BurstManaged(in float3 x, in float3 y, out float3 ret)
		{
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2418AC0", Offset = "0x24170C0", VA = "0x182418AC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod$BurstManaged(in float4 x, in float4 y, out float4 ret)
		{
		}

		// Token: 0x0600050C RID: 1292 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x2418C10", Offset = "0x2417210", VA = "0x182418C10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod289$BurstManaged(in float2 x, out float2 ret)
		{
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2418CB0", Offset = "0x24172B0", VA = "0x182418CB0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod289$BurstManaged(in float3 x, out float3 ret)
		{
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2418DA0", Offset = "0x24173A0", VA = "0x182418DA0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Mod289$BurstManaged(in float4 x, out float4 ret)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2418ED0", Offset = "0x24174D0", VA = "0x182418ED0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Permute$BurstManaged(in float3 x, out float3 ret)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2418FE0", Offset = "0x24175E0", VA = "0x182418FE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Permute$BurstManaged(in float4 x, out float4 ret)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2419100", Offset = "0x2417700", VA = "0x182419100")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TaylorInvSqrt$BurstManaged(in float3 r, out float3 ret)
		{
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000512")]
		[Address(RVA = "0x2419170", Offset = "0x2417770", VA = "0x182419170")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void TaylorInvSqrt$BurstManaged(in float4 r, out float4 ret)
		{
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000513")]
		[Address(RVA = "0x2419200", Offset = "0x2417800", VA = "0x182419200")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Fade$BurstManaged(in float2 t, out float2 ret)
		{
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000514")]
		[Address(RVA = "0x24192B0", Offset = "0x24178B0", VA = "0x1824192B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void Fade$BurstManaged(in float3 t, out float3 ret)
		{
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000515")]
		[Address(RVA = "0x24193D0", Offset = "0x24179D0", VA = "0x1824193D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Index$BurstManaged(in int3 id, in int3 dimension)
		{
			return 0;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000516")]
		[Address(RVA = "0x24193F0", Offset = "0x24179F0", VA = "0x1824193F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnitTriWave$BurstManaged(in float3 x, out float3 ret)
		{
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000517")]
		[Address(RVA = "0x2419540", Offset = "0x2417B40", VA = "0x182419540")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PNoise$BurstManaged(in float3 P, in float3 rep)
		{
			return 0f;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000518")]
		[Address(RVA = "0x241AB30", Offset = "0x2419130", VA = "0x18241AB30")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PNoise$BurstManaged(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor, in float3 period)
		{
			return 0f;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000519")]
		[Address(RVA = "0x241ADE0", Offset = "0x24193E0", VA = "0x18241ADE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CachedNoise$BurstManaged(in float3 s)
		{
			return 0f;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00004E90 File Offset: 0x00003090
		[Token(Token = "0x600051A")]
		[Address(RVA = "0x241AEF0", Offset = "0x24194F0", VA = "0x18241AEF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CachedNoise$BurstManaged(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor)
		{
			return 0f;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00004EA8 File Offset: 0x000030A8
		[Token(Token = "0x600051B")]
		[Address(RVA = "0x241B150", Offset = "0x2419750", VA = "0x18241B150")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TriangleNoise$BurstManaged(in float3 p)
		{
			return 0f;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00004EC0 File Offset: 0x000030C0
		[Token(Token = "0x600051C")]
		[Address(RVA = "0x241B360", Offset = "0x2419960", VA = "0x18241B360")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float TriangleNoise$BurstManaged(in float3 s, in float3 offset, int numOctaves, in float octaveOffsetFactor)
		{
			return 0f;
		}

		// Token: 0x040003AB RID: 939
		[Token(Token = "0x40003AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly int MaxAabbTreeStackSize;

		// Token: 0x040003AC RID: 940
		[Token(Token = "0x40003AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		private static readonly int MaxBrushGroupDepth;

		// Token: 0x040003AD RID: 941
		[Token(Token = "0x40003AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static readonly int DenseSdfEvalMapSize;

		// Token: 0x040003AE RID: 942
		[Token(Token = "0x40003AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static NativeArray<FunctionPointer<Sdf.SdfBrushEvalFunc>> s_sdfEvalFuncMapDense;

		// Token: 0x040003AF RID: 943
		[Token(Token = "0x40003AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static NativeArray<Sdf.SdfBrushEvalFuncMapEntry> s_sdfEvalFuncMapSparse;

		// Token: 0x040003B0 RID: 944
		[Token(Token = "0x40003B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static readonly int MaxBrushMaskInts;

		// Token: 0x040003B1 RID: 945
		[Token(Token = "0x40003B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private static readonly int BitsPerInt;

		// Token: 0x040003B2 RID: 946
		[Token(Token = "0x40003B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static NativeArray<Vector3> s_sampleDummy;

		// Token: 0x040003B3 RID: 947
		[Token(Token = "0x40003B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static NativeArray<Sdf.Ray> s_castDummy;

		// Token: 0x040003B4 RID: 948
		[Token(Token = "0x40003B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static NativeArray<Vector3> s_castChainDummy;

		// Token: 0x040003B5 RID: 949
		[Token(Token = "0x40003B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static NativeArray<Vector3> s_normalDummy;

		// Token: 0x040003B6 RID: 950
		[Token(Token = "0x40003B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static NativeArray<Sdf.Contact> s_contactDummy;

		// Token: 0x040003B7 RID: 951
		[Token(Token = "0x40003B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static NativeArray<SdfBrushMaterial> s_materialDummy;

		// Token: 0x040003B8 RID: 952
		[Token(Token = "0x40003B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static NativeArray<Sdf.Result> s_resultDummy;

		// Token: 0x020000B5 RID: 181
		[Token(Token = "0x20000B5")]
		public struct Result
		{
			// Token: 0x0600051D RID: 1309 RVA: 0x00004ED8 File Offset: 0x000030D8
			[Token(Token = "0x600051D")]
			[Address(RVA = "0x241D7D0", Offset = "0x241BDD0", VA = "0x18241D7D0")]
			public static Sdf.Result New(float value, in SdfBrushMaterial material, Vector3 normal)
			{
				return default(Sdf.Result);
			}

			// Token: 0x170000DD RID: 221
			// (get) Token: 0x0600051E RID: 1310 RVA: 0x00004EF0 File Offset: 0x000030F0
			[Token(Token = "0x170000DD")]
			public float Value
			{
				[Token(Token = "0x600051E")]
				[Address(RVA = "0xFA0940", Offset = "0xF9EF40", VA = "0x180FA0940")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x170000DE RID: 222
			// (get) Token: 0x0600051F RID: 1311 RVA: 0x00004F08 File Offset: 0x00003108
			[Token(Token = "0x170000DE")]
			public SdfBrushMaterial Material
			{
				[Token(Token = "0x600051F")]
				[Address(RVA = "0x241D820", Offset = "0x241BE20", VA = "0x18241D820")]
				get
				{
					return default(SdfBrushMaterial);
				}
			}

			// Token: 0x170000DF RID: 223
			// (get) Token: 0x06000520 RID: 1312 RVA: 0x00004F20 File Offset: 0x00003120
			[Token(Token = "0x170000DF")]
			public Vector3 Normal
			{
				[Token(Token = "0x6000520")]
				[Address(RVA = "0x23C2570", Offset = "0x23C0B70", VA = "0x1823C2570")]
				get
				{
					return default(Vector3);
				}
			}

			// Token: 0x040003B9 RID: 953
			[Token(Token = "0x40003B9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private float m_value;

			// Token: 0x040003BA RID: 954
			[Token(Token = "0x40003BA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			private SdfBrushMaterial m_material;

			// Token: 0x040003BB RID: 955
			[Token(Token = "0x40003BB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
			private Vector3 m_normal;
		}

		// Token: 0x020000B6 RID: 182
		// (Invoke) Token: 0x06000522 RID: 1314
		[Token(Token = "0x20000B6")]
		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		public unsafe delegate float SdfBrushEvalFunc(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x020000B7 RID: 183
		[Token(Token = "0x20000B7")]
		public struct SdfBrushEvalFuncMapEntry
		{
			// Token: 0x040003BC RID: 956
			[Token(Token = "0x40003BC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int BrushType;

			// Token: 0x040003BD RID: 957
			[Token(Token = "0x40003BD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FunctionPointer<Sdf.SdfBrushEvalFunc> Func;
		}

		// Token: 0x020000B8 RID: 184
		[Token(Token = "0x20000B8")]
		[BurstCompile]
		private struct BrushMask
		{
			// Token: 0x06000525 RID: 1317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000525")]
			[Address(RVA = "0x241D970", Offset = "0x241BF70", VA = "0x18241D970")]
			public void Init()
			{
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000526")]
			[Address(RVA = "0x241DA60", Offset = "0x241C060", VA = "0x18241DA60")]
			public void Dispose()
			{
			}

			// Token: 0x06000527 RID: 1319 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000527")]
			[Address(RVA = "0x241DAC0", Offset = "0x241C0C0", VA = "0x18241DAC0")]
			public void SetBit(int bit)
			{
			}

			// Token: 0x06000528 RID: 1320 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000528")]
			[Address(RVA = "0x241DB40", Offset = "0x241C140", VA = "0x18241DB40")]
			public void ClearBit(int bit)
			{
			}

			// Token: 0x06000529 RID: 1321 RVA: 0x00004F38 File Offset: 0x00003138
			[Token(Token = "0x6000529")]
			[Address(RVA = "0x241DBC0", Offset = "0x241C1C0", VA = "0x18241DBC0")]
			public bool IsBitSet(int bit)
			{
				return default(bool);
			}

			// Token: 0x0600052A RID: 1322 RVA: 0x00004F50 File Offset: 0x00003150
			[Token(Token = "0x600052A")]
			[Address(RVA = "0x241DC40", Offset = "0x241C240", VA = "0x18241DC40")]
			public Sdf.BrushMask.BrushMaskIterator GetIterator()
			{
				return default(Sdf.BrushMask.BrushMaskIterator);
			}

			// Token: 0x040003BE RID: 958
			[Token(Token = "0x40003BE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public NativeArray<uint> m_ints;

			// Token: 0x020000B9 RID: 185
			[Token(Token = "0x20000B9")]
			public struct BrushMaskIterator
			{
				// Token: 0x0600052B RID: 1323 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600052B")]
				[Address(RVA = "0x241DC60", Offset = "0x241C260", VA = "0x18241DC60")]
				public void Init(Sdf.BrushMask mask)
				{
				}

				// Token: 0x0600052C RID: 1324 RVA: 0x00004F68 File Offset: 0x00003168
				[Token(Token = "0x600052C")]
				[Address(RVA = "0x241DC70", Offset = "0x241C270", VA = "0x18241DC70")]
				public int First()
				{
					return 0;
				}

				// Token: 0x0600052D RID: 1325 RVA: 0x00004F80 File Offset: 0x00003180
				[Token(Token = "0x600052D")]
				[Address(RVA = "0x241DC90", Offset = "0x241C290", VA = "0x18241DC90")]
				public int Next()
				{
					return 0;
				}

				// Token: 0x040003BF RID: 959
				[Token(Token = "0x40003BF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				private Sdf.BrushMask m_mask;

				// Token: 0x040003C0 RID: 960
				[Token(Token = "0x40003C0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				private uint m_curInt;

				// Token: 0x040003C1 RID: 961
				[Token(Token = "0x40003C1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
				private int m_numInts;

				// Token: 0x040003C2 RID: 962
				[Token(Token = "0x40003C2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				private int m_iInt;

				// Token: 0x040003C3 RID: 963
				[Token(Token = "0x40003C3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				private int m_iBrushBase;
			}
		}

		// Token: 0x020000BA RID: 186
		[Token(Token = "0x20000BA")]
		public struct Ray
		{
			// Token: 0x040003C4 RID: 964
			[Token(Token = "0x40003C4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Vector3 From;

			// Token: 0x040003C5 RID: 965
			[Token(Token = "0x40003C5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
			public Vector3 Direction;

			// Token: 0x040003C6 RID: 966
			[Token(Token = "0x40003C6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public float MaxDistance;
		}

		// Token: 0x020000BB RID: 187
		[Token(Token = "0x20000BB")]
		public struct Contact
		{
			// Token: 0x170000E0 RID: 224
			// (get) Token: 0x0600052E RID: 1326 RVA: 0x00004F98 File Offset: 0x00003198
			[Token(Token = "0x170000E0")]
			public static Sdf.Contact New
			{
				[Token(Token = "0x600052E")]
				[Address(RVA = "0x241DD70", Offset = "0x241C370", VA = "0x18241DD70")]
				get
				{
					return default(Sdf.Contact);
				}
			}

			// Token: 0x040003C7 RID: 967
			[Token(Token = "0x40003C7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public bool Hit;

			// Token: 0x040003C8 RID: 968
			[Token(Token = "0x40003C8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
			public bool MaxStepsReached;

			// Token: 0x040003C9 RID: 969
			[Token(Token = "0x40003C9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Vector3 Position;

			// Token: 0x040003CA RID: 970
			[Token(Token = "0x40003CA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Vector3 Normal;

			// Token: 0x040003CB RID: 971
			[Token(Token = "0x40003CB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
			public float LocalT;

			// Token: 0x040003CC RID: 972
			[Token(Token = "0x40003CC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public float GlobalT;

			// Token: 0x040003CD RID: 973
			[Token(Token = "0x40003CD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
			public SdfBrushMaterial Material;
		}

		// Token: 0x020000BC RID: 188
		[Token(Token = "0x20000BC")]
		public struct EvalJobHandle
		{
			// Token: 0x170000E1 RID: 225
			// (get) Token: 0x0600052F RID: 1327 RVA: 0x00004FB0 File Offset: 0x000031B0
			[Token(Token = "0x170000E1")]
			public bool Valid
			{
				[Token(Token = "0x600052F")]
				[Address(RVA = "0x241DE90", Offset = "0x241C490", VA = "0x18241DE90")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170000E2 RID: 226
			// (get) Token: 0x06000530 RID: 1328 RVA: 0x00004FC8 File Offset: 0x000031C8
			[Token(Token = "0x170000E2")]
			public bool Completed
			{
				[Token(Token = "0x6000530")]
				[Address(RVA = "0x241DEA0", Offset = "0x241C4A0", VA = "0x18241DEA0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000531")]
			[Address(RVA = "0x241DEB0", Offset = "0x241C4B0", VA = "0x18241DEB0")]
			public void Invalidate()
			{
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x00004FE0 File Offset: 0x000031E0
			[Token(Token = "0x6000532")]
			[Address(RVA = "0x241DF10", Offset = "0x241C510", VA = "0x18241DF10")]
			public static Sdf.EvalJobHandle New(Sdf.EvalJob job, MudRendererBase renderer)
			{
				return default(Sdf.EvalJobHandle);
			}

			// Token: 0x170000E3 RID: 227
			// (get) Token: 0x06000533 RID: 1331 RVA: 0x00004FF8 File Offset: 0x000031F8
			[Token(Token = "0x170000E3")]
			public static Sdf.EvalJobHandle Empty
			{
				[Token(Token = "0x6000533")]
				[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0")]
				get
				{
					return default(Sdf.EvalJobHandle);
				}
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000534")]
			[Address(RVA = "0x241E0A0", Offset = "0x241C6A0", VA = "0x18241E0A0")]
			internal void Schedule(bool byRenderer)
			{
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000535")]
			[Address(RVA = "0x241E4B0", Offset = "0x241CAB0", VA = "0x18241E4B0")]
			public void Complete()
			{
			}

			// Token: 0x040003CE RID: 974
			[Token(Token = "0x40003CE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private Sdf.EvalJobHandle.Shared m_shared;

			// Token: 0x020000BD RID: 189
			[Token(Token = "0x20000BD")]
			private class Shared
			{
				// Token: 0x06000536 RID: 1334 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6000536")]
				[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
				public Shared()
				{
				}

				// Token: 0x040003CF RID: 975
				[Token(Token = "0x40003CF")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
				public bool m_valid;

				// Token: 0x040003D0 RID: 976
				[Token(Token = "0x40003D0")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
				public bool m_scheduled;

				// Token: 0x040003D1 RID: 977
				[Token(Token = "0x40003D1")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x12")]
				public bool m_completed;

				// Token: 0x040003D2 RID: 978
				[Token(Token = "0x40003D2")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public Sdf.EvalJob m_job;

				// Token: 0x040003D3 RID: 979
				[Token(Token = "0x40003D3")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
				public JobHandle m_hJob;

				// Token: 0x040003D4 RID: 980
				[Token(Token = "0x40003D4")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
				public MudRendererBase m_renderer;
			}
		}

		// Token: 0x020000BE RID: 190
		[Token(Token = "0x20000BE")]
		[BurstCompile]
		public struct EvalJob : IJobParallelFor
		{
			// Token: 0x06000537 RID: 1335 RVA: 0x00005010 File Offset: 0x00003210
			[Token(Token = "0x6000537")]
			[Address(RVA = "0x241E510", Offset = "0x241CB10", VA = "0x18241E510")]
			private bool LookUpBrushFunc(int brushType, out FunctionPointer<Sdf.SdfBrushEvalFunc> pFunc)
			{
				return default(bool);
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x00005028 File Offset: 0x00003228
			[Token(Token = "0x6000538")]
			[Address(RVA = "0x241E620", Offset = "0x241CC20", VA = "0x18241E620")]
			private float ApplyBrush(float res, float groupRes, in SdfBrushMaterial groupMat, ref float3 p, NativeArray<SdfBrush> aBrush, int iBrush, in SdfBrush b, NativeArray<SdfBrushMaterial> aMaterial, ref SdfBrushMaterial oMat, bool outputMat, float surfaceShift)
			{
				return 0f;
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x00005040 File Offset: 0x00003240
			[Token(Token = "0x6000539")]
			[Address(RVA = "0x241EBD0", Offset = "0x241D1D0", VA = "0x18241EBD0")]
			private float EvalBrush(float res, ref float3 p, NativeArray<SdfBrush> aBrush, int iBrush, in SdfBrush b)
			{
				return 0f;
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x00005058 File Offset: 0x00003258
			[Token(Token = "0x600053A")]
			[Address(RVA = "0x241EF10", Offset = "0x241D510", VA = "0x18241EF10")]
			private float EvalSdf(Vector3 p, Sdf.BrushMask mask, ref SdfBrushMaterial materialOut, bool computeMaterials, float castRadius = 0f)
			{
				return 0f;
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600053B")]
			[Address(RVA = "0x241FA00", Offset = "0x241E000", VA = "0x18241FA00")]
			private void BuildBrushMask(NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, Aabb query, out Sdf.BrushMask ret)
			{
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600053C")]
			[Address(RVA = "0x24200B0", Offset = "0x241E6B0", VA = "0x1824200B0")]
			private void BuildBrushMask(NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, in Sdf.Ray query, float margin, out Sdf.BrushMask ret, out float tMin)
			{
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600053D")]
			[Address(RVA = "0x2420830", Offset = "0x241EE30", VA = "0x182420830")]
			private void BuildBrushMask(NativeArray<AabbTree<MudBrushBase>.NodePod> tree, int iRoot, in Vector3 query, out Sdf.BrushMask ret)
			{
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x00005070 File Offset: 0x00003270
			[Token(Token = "0x600053E")]
			[Address(RVA = "0x2420A50", Offset = "0x241F050", VA = "0x182420A50")]
			private float EvalSdf(Vector3 p, ref SdfBrushMaterial materialOut, bool computeMaterials, float castRadius = 0f)
			{
				return 0f;
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x00005088 File Offset: 0x00003288
			[Token(Token = "0x600053F")]
			[Address(RVA = "0x2420D20", Offset = "0x241F320", VA = "0x182420D20")]
			private Vector3 EvalNormal(Vector3 p, Sdf.BrushMask mask)
			{
				return default(Vector3);
			}

			// Token: 0x06000540 RID: 1344 RVA: 0x000050A0 File Offset: 0x000032A0
			[Token(Token = "0x6000540")]
			[Address(RVA = "0x2421200", Offset = "0x241F800", VA = "0x182421200")]
			private Vector3 EvalNormal(Vector3 p)
			{
				return default(Vector3);
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x000050B8 File Offset: 0x000032B8
			[Token(Token = "0x6000541")]
			[Address(RVA = "0x24214C0", Offset = "0x241FAC0", VA = "0x1824214C0")]
			private Sdf.Contact EvalRaycast(Sdf.Ray ray, ref SdfBrushMaterial materialOut)
			{
				return default(Sdf.Contact);
			}

			// Token: 0x06000542 RID: 1346 RVA: 0x000050D0 File Offset: 0x000032D0
			[Token(Token = "0x6000542")]
			[Address(RVA = "0x2421AA0", Offset = "0x24200A0", VA = "0x182421AA0")]
			private Sdf.Contact EvalRaycastChain(NativeArray<Vector3> castChain, ref SdfBrushMaterial materialOut)
			{
				return default(Sdf.Contact);
			}

			// Token: 0x06000543 RID: 1347 RVA: 0x000050E8 File Offset: 0x000032E8
			[Token(Token = "0x6000543")]
			[Address(RVA = "0x24223F0", Offset = "0x24209F0", VA = "0x1824223F0")]
			private Sdf.Contact EvalSnapToSurface(Vector3 p, ref SdfBrushMaterial materialOut)
			{
				return default(Sdf.Contact);
			}

			// Token: 0x06000544 RID: 1348 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000544")]
			[Address(RVA = "0x24227D0", Offset = "0x2420DD0", VA = "0x1824227D0", Slot = "4")]
			public void Execute(int index)
			{
			}

			// Token: 0x06000545 RID: 1349 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000545")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public void Dispose()
			{
			}

			// Token: 0x040003D5 RID: 981
			[Token(Token = "0x40003D5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public Sdf.EvalJob.TypeEnum Type;

			// Token: 0x040003D6 RID: 982
			[Token(Token = "0x40003D6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
			public Matrix4x4 WorldToLocal;

			// Token: 0x040003D7 RID: 983
			[Token(Token = "0x40003D7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x44")]
			public Matrix4x4 LocalToWorld;

			// Token: 0x040003D8 RID: 984
			[Token(Token = "0x40003D8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
			public Matrix4x4 LocalToWorldIt;

			// Token: 0x040003D9 RID: 985
			[Token(Token = "0x40003D9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
			[ReadOnly]
			public NativeArray<FunctionPointer<Sdf.SdfBrushEvalFunc>> SdfEvalFuncMapDense;

			// Token: 0x040003DA RID: 986
			[Token(Token = "0x40003DA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
			[ReadOnly]
			public NativeArray<Sdf.SdfBrushEvalFuncMapEntry> SdfEvalFuncMapSprase;

			// Token: 0x040003DB RID: 987
			[Token(Token = "0x40003DB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
			[ReadOnly]
			public NativeArray<Vector3> Samples;

			// Token: 0x040003DC RID: 988
			[Token(Token = "0x40003DC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
			[ReadOnly]
			public NativeArray<SdfBrush> Brushes;

			// Token: 0x040003DD RID: 989
			[Token(Token = "0x40003DD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
			[ReadOnly]
			public NativeArray<SdfBrushMaterial> MaterialsIn;

			// Token: 0x040003DE RID: 990
			[Token(Token = "0x40003DE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
			[ReadOnly]
			public NativeArray<AabbTree<MudBrushBase>.NodePod> Tree;

			// Token: 0x040003DF RID: 991
			[Token(Token = "0x40003DF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
			public int NumBrushes;

			// Token: 0x040003E0 RID: 992
			[Token(Token = "0x40003E0")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x12C")]
			public int RootIndex;

			// Token: 0x040003E1 RID: 993
			[Token(Token = "0x40003E1")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
			public float MaxSurfaceDistance;

			// Token: 0x040003E2 RID: 994
			[Token(Token = "0x40003E2")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x134")]
			public bool ComputeMaterials;

			// Token: 0x040003E3 RID: 995
			[Token(Token = "0x40003E3")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
			public float SurfaceShift;

			// Token: 0x040003E4 RID: 996
			[Token(Token = "0x40003E4")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
			[ReadOnly]
			public NativeArray<Sdf.Ray> Casts;

			// Token: 0x040003E5 RID: 997
			[Token(Token = "0x40003E5")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
			[ReadOnly]
			public NativeArray<Vector3> CastChain;

			// Token: 0x040003E6 RID: 998
			[Token(Token = "0x40003E6")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
			public int MaxSteps;

			// Token: 0x040003E7 RID: 999
			[Token(Token = "0x40003E7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x164")]
			public float CastMargin;

			// Token: 0x040003E8 RID: 1000
			[Token(Token = "0x40003E8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
			public bool ForceZeroBlendUnion;

			// Token: 0x040003E9 RID: 1001
			[Token(Token = "0x40003E9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
			[WriteOnly]
			public NativeArray<Sdf.Result> SdfResults;

			// Token: 0x040003EA RID: 1002
			[Token(Token = "0x40003EA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
			[WriteOnly]
			public NativeArray<Sdf.Contact> Contacts;

			// Token: 0x040003EB RID: 1003
			[Token(Token = "0x40003EB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static readonly float RayStepRatio;

			// Token: 0x020000BF RID: 191
			[Token(Token = "0x20000BF")]
			public enum TypeEnum
			{
				// Token: 0x040003ED RID: 1005
				[Token(Token = "0x40003ED")]
				Invalid = -1,
				// Token: 0x040003EE RID: 1006
				[Token(Token = "0x40003EE")]
				Sdf,
				// Token: 0x040003EF RID: 1007
				[Token(Token = "0x40003EF")]
				Normal,
				// Token: 0x040003F0 RID: 1008
				[Token(Token = "0x40003F0")]
				SdfAndNormal,
				// Token: 0x040003F1 RID: 1009
				[Token(Token = "0x40003F1")]
				Raycast,
				// Token: 0x040003F2 RID: 1010
				[Token(Token = "0x40003F2")]
				RaycastChain,
				// Token: 0x040003F3 RID: 1011
				[Token(Token = "0x40003F3")]
				SnapToSurface
			}
		}

		// Token: 0x020000C1 RID: 193
		// (Invoke) Token: 0x0600054C RID: 1356
		[Token(Token = "0x20000C1")]
		public unsafe delegate float DummyEvaluateSdf_000002FD$PostfixBurstDelegate(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush);

		// Token: 0x020000C2 RID: 194
		[Token(Token = "0x20000C2")]
		internal static class DummyEvaluateSdf_000002FD$BurstDirectCall
		{
			// Token: 0x0600054F RID: 1359 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600054F")]
			[Address(RVA = "0x2424080", Offset = "0x2422680", VA = "0x182424080")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x00005130 File Offset: 0x00003330
			[Token(Token = "0x6000550")]
			[Address(RVA = "0x24241B0", Offset = "0x24227B0", VA = "0x1824241B0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000551")]
			[Address(RVA = "0x2424310", Offset = "0x2422910", VA = "0x182424310")]
			public static void Constructor()
			{
			}

			// Token: 0x06000552 RID: 1362 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000552")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000554 RID: 1364 RVA: 0x00005148 File Offset: 0x00003348
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x24243C0", Offset = "0x24229C0", VA = "0x1824243C0")]
			public unsafe static float Invoke(float res, ref float3 p, in float3 pRel, SdfBrush* aBrush, int iBrush)
			{
				return 0f;
			}

			// Token: 0x040003F7 RID: 1015
			[Token(Token = "0x40003F7")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040003F8 RID: 1016
			[Token(Token = "0x40003F8")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000C3 RID: 195
		// (Invoke) Token: 0x06000556 RID: 1366
		[Token(Token = "0x20000C3")]
		public delegate float DistBlendWeight_00000301$PostfixBurstDelegate(float distA, float distB, float strength);

		// Token: 0x020000C4 RID: 196
		[Token(Token = "0x20000C4")]
		internal static class DistBlendWeight_00000301$BurstDirectCall
		{
			// Token: 0x06000559 RID: 1369 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2424680", Offset = "0x2422C80", VA = "0x182424680")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x00005160 File Offset: 0x00003360
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x24247B0", Offset = "0x2422DB0", VA = "0x1824247B0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600055B RID: 1371 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600055B")]
			[Address(RVA = "0x2424910", Offset = "0x2422F10", VA = "0x182424910")]
			public static void Constructor()
			{
			}

			// Token: 0x0600055C RID: 1372 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600055C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600055E RID: 1374 RVA: 0x00005178 File Offset: 0x00003378
			[Token(Token = "0x600055E")]
			[Address(RVA = "0x24249C0", Offset = "0x2422FC0", VA = "0x1824249C0")]
			public static float Invoke(float distA, float distB, float strength)
			{
				return 0f;
			}

			// Token: 0x040003F9 RID: 1017
			[Token(Token = "0x40003F9")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040003FA RID: 1018
			[Token(Token = "0x40003FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000C5 RID: 197
		// (Invoke) Token: 0x06000560 RID: 1376
		[Token(Token = "0x20000C5")]
		public delegate float UniSmooth_00000302$PostfixBurstDelegate(float a, float b, float k);

		// Token: 0x020000C6 RID: 198
		[Token(Token = "0x20000C6")]
		internal static class UniSmooth_00000302$BurstDirectCall
		{
			// Token: 0x06000563 RID: 1379 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000563")]
			[Address(RVA = "0x2424D60", Offset = "0x2423360", VA = "0x182424D60")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000564 RID: 1380 RVA: 0x00005190 File Offset: 0x00003390
			[Token(Token = "0x6000564")]
			[Address(RVA = "0x2424E90", Offset = "0x2423490", VA = "0x182424E90")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000565 RID: 1381 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000565")]
			[Address(RVA = "0x2424FF0", Offset = "0x24235F0", VA = "0x182424FF0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000566 RID: 1382 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000566")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000568 RID: 1384 RVA: 0x000051A8 File Offset: 0x000033A8
			[Token(Token = "0x6000568")]
			[Address(RVA = "0x24250A0", Offset = "0x24236A0", VA = "0x1824250A0")]
			public static float Invoke(float a, float b, float k)
			{
				return 0f;
			}

			// Token: 0x040003FB RID: 1019
			[Token(Token = "0x40003FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040003FC RID: 1020
			[Token(Token = "0x40003FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000C7 RID: 199
		// (Invoke) Token: 0x0600056A RID: 1386
		[Token(Token = "0x20000C7")]
		public delegate float SubSmooth_00000303$PostfixBurstDelegate(float a, float b, float k);

		// Token: 0x020000C8 RID: 200
		[Token(Token = "0x20000C8")]
		internal static class SubSmooth_00000303$BurstDirectCall
		{
			// Token: 0x0600056D RID: 1389 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600056D")]
			[Address(RVA = "0x2425460", Offset = "0x2423A60", VA = "0x182425460")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600056E RID: 1390 RVA: 0x000051C0 File Offset: 0x000033C0
			[Token(Token = "0x600056E")]
			[Address(RVA = "0x2425590", Offset = "0x2423B90", VA = "0x182425590")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600056F RID: 1391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600056F")]
			[Address(RVA = "0x24256F0", Offset = "0x2423CF0", VA = "0x1824256F0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000570 RID: 1392 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000570")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000572 RID: 1394 RVA: 0x000051D8 File Offset: 0x000033D8
			[Token(Token = "0x6000572")]
			[Address(RVA = "0x24257A0", Offset = "0x2423DA0", VA = "0x1824257A0")]
			public static float Invoke(float a, float b, float k)
			{
				return 0f;
			}

			// Token: 0x040003FD RID: 1021
			[Token(Token = "0x40003FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x040003FE RID: 1022
			[Token(Token = "0x40003FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000C9 RID: 201
		// (Invoke) Token: 0x06000574 RID: 1396
		[Token(Token = "0x20000C9")]
		public delegate float IntSmooth_00000304$PostfixBurstDelegate(float a, float b, float k);

		// Token: 0x020000CA RID: 202
		[Token(Token = "0x20000CA")]
		internal static class IntSmooth_00000304$BurstDirectCall
		{
			// Token: 0x06000577 RID: 1399 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000577")]
			[Address(RVA = "0x2425B60", Offset = "0x2424160", VA = "0x182425B60")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000578 RID: 1400 RVA: 0x000051F0 File Offset: 0x000033F0
			[Token(Token = "0x6000578")]
			[Address(RVA = "0x2425C90", Offset = "0x2424290", VA = "0x182425C90")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000579 RID: 1401 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000579")]
			[Address(RVA = "0x2425DF0", Offset = "0x24243F0", VA = "0x182425DF0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600057A RID: 1402 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600057A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600057C RID: 1404 RVA: 0x00005208 File Offset: 0x00003408
			[Token(Token = "0x600057C")]
			[Address(RVA = "0x2425EA0", Offset = "0x24244A0", VA = "0x182425EA0")]
			public static float Invoke(float a, float b, float k)
			{
				return 0f;
			}

			// Token: 0x040003FF RID: 1023
			[Token(Token = "0x40003FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000400 RID: 1024
			[Token(Token = "0x4000400")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000CB RID: 203
		// (Invoke) Token: 0x0600057E RID: 1406
		[Token(Token = "0x20000CB")]
		public delegate float Sphere_00000305$PostfixBurstDelegate(in float3 p, float r);

		// Token: 0x020000CC RID: 204
		[Token(Token = "0x20000CC")]
		internal static class Sphere_00000305$BurstDirectCall
		{
			// Token: 0x06000581 RID: 1409 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000581")]
			[Address(RVA = "0x2426340", Offset = "0x2424940", VA = "0x182426340")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000582 RID: 1410 RVA: 0x00005220 File Offset: 0x00003420
			[Token(Token = "0x6000582")]
			[Address(RVA = "0x2426470", Offset = "0x2424A70", VA = "0x182426470")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000583 RID: 1411 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000583")]
			[Address(RVA = "0x24265D0", Offset = "0x2424BD0", VA = "0x1824265D0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000584 RID: 1412 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000584")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000586 RID: 1414 RVA: 0x00005238 File Offset: 0x00003438
			[Token(Token = "0x6000586")]
			[Address(RVA = "0x2426680", Offset = "0x2424C80", VA = "0x182426680")]
			public static float Invoke(in float3 p, float r)
			{
				return 0f;
			}

			// Token: 0x04000401 RID: 1025
			[Token(Token = "0x4000401")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000402 RID: 1026
			[Token(Token = "0x4000402")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000CD RID: 205
		// (Invoke) Token: 0x06000588 RID: 1416
		[Token(Token = "0x20000CD")]
		public delegate float Ellipsoid_00000306$PostfixBurstDelegate(in float3 p, in float3 h);

		// Token: 0x020000CE RID: 206
		[Token(Token = "0x20000CE")]
		internal static class Ellipsoid_00000306$BurstDirectCall
		{
			// Token: 0x0600058B RID: 1419 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600058B")]
			[Address(RVA = "0x2426A40", Offset = "0x2425040", VA = "0x182426A40")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600058C RID: 1420 RVA: 0x00005250 File Offset: 0x00003450
			[Token(Token = "0x600058C")]
			[Address(RVA = "0x2426B70", Offset = "0x2425170", VA = "0x182426B70")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600058D RID: 1421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600058D")]
			[Address(RVA = "0x2426CD0", Offset = "0x24252D0", VA = "0x182426CD0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600058E RID: 1422 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600058E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000590 RID: 1424 RVA: 0x00005268 File Offset: 0x00003468
			[Token(Token = "0x6000590")]
			[Address(RVA = "0x2426D80", Offset = "0x2425380", VA = "0x182426D80")]
			public static float Invoke(in float3 p, in float3 h)
			{
				return 0f;
			}

			// Token: 0x04000403 RID: 1027
			[Token(Token = "0x4000403")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000404 RID: 1028
			[Token(Token = "0x4000404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000CF RID: 207
		// (Invoke) Token: 0x06000592 RID: 1426
		[Token(Token = "0x20000CF")]
		public delegate float Box_00000307$PostfixBurstDelegate(in float3 p, in float3 h, float r = 0f);

		// Token: 0x020000D0 RID: 208
		[Token(Token = "0x20000D0")]
		internal static class Box_00000307$BurstDirectCall
		{
			// Token: 0x06000595 RID: 1429 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000595")]
			[Address(RVA = "0x2427130", Offset = "0x2425730", VA = "0x182427130")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000596 RID: 1430 RVA: 0x00005280 File Offset: 0x00003480
			[Token(Token = "0x6000596")]
			[Address(RVA = "0x2427260", Offset = "0x2425860", VA = "0x182427260")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000597 RID: 1431 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000597")]
			[Address(RVA = "0x24273C0", Offset = "0x24259C0", VA = "0x1824273C0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000598 RID: 1432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000598")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600059A RID: 1434 RVA: 0x00005298 File Offset: 0x00003498
			[Token(Token = "0x600059A")]
			[Address(RVA = "0x2427470", Offset = "0x2425A70", VA = "0x182427470")]
			public static float Invoke(in float3 p, in float3 h, float r = 0f)
			{
				return 0f;
			}

			// Token: 0x04000405 RID: 1029
			[Token(Token = "0x4000405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000406 RID: 1030
			[Token(Token = "0x4000406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000D1 RID: 209
		// (Invoke) Token: 0x0600059C RID: 1436
		[Token(Token = "0x20000D1")]
		public delegate float Capsule_00000308$PostfixBurstDelegate(in float3 p, in float3 a, in float3 b, float r);

		// Token: 0x020000D2 RID: 210
		[Token(Token = "0x20000D2")]
		internal static class Capsule_00000308$BurstDirectCall
		{
			// Token: 0x0600059F RID: 1439 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600059F")]
			[Address(RVA = "0x2427860", Offset = "0x2425E60", VA = "0x182427860")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005A0 RID: 1440 RVA: 0x000052B0 File Offset: 0x000034B0
			[Token(Token = "0x60005A0")]
			[Address(RVA = "0x2427990", Offset = "0x2425F90", VA = "0x182427990")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005A1 RID: 1441 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005A1")]
			[Address(RVA = "0x2427AF0", Offset = "0x24260F0", VA = "0x182427AF0")]
			public static void Constructor()
			{
			}

			// Token: 0x060005A2 RID: 1442 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005A2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005A4 RID: 1444 RVA: 0x000052C8 File Offset: 0x000034C8
			[Token(Token = "0x60005A4")]
			[Address(RVA = "0x2427BA0", Offset = "0x24261A0", VA = "0x182427BA0")]
			public static float Invoke(in float3 p, in float3 a, in float3 b, float r)
			{
				return 0f;
			}

			// Token: 0x04000407 RID: 1031
			[Token(Token = "0x4000407")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000408 RID: 1032
			[Token(Token = "0x4000408")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000D3 RID: 211
		// (Invoke) Token: 0x060005A6 RID: 1446
		[Token(Token = "0x20000D3")]
		public delegate float CappedCone_00000309$PostfixBurstDelegate(in float3 p, float h, float r1, float r2, float r = 0f);

		// Token: 0x020000D4 RID: 212
		[Token(Token = "0x20000D4")]
		internal static class CappedCone_00000309$BurstDirectCall
		{
			// Token: 0x060005A9 RID: 1449 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005A9")]
			[Address(RVA = "0x2427FC0", Offset = "0x24265C0", VA = "0x182427FC0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005AA RID: 1450 RVA: 0x000052E0 File Offset: 0x000034E0
			[Token(Token = "0x60005AA")]
			[Address(RVA = "0x24280F0", Offset = "0x24266F0", VA = "0x1824280F0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005AB RID: 1451 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005AB")]
			[Address(RVA = "0x2428250", Offset = "0x2426850", VA = "0x182428250")]
			public static void Constructor()
			{
			}

			// Token: 0x060005AC RID: 1452 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005AC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005AE RID: 1454 RVA: 0x000052F8 File Offset: 0x000034F8
			[Token(Token = "0x60005AE")]
			[Address(RVA = "0x2428300", Offset = "0x2426900", VA = "0x182428300")]
			public static float Invoke(in float3 p, float h, float r1, float r2, float r = 0f)
			{
				return 0f;
			}

			// Token: 0x04000409 RID: 1033
			[Token(Token = "0x4000409")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400040A RID: 1034
			[Token(Token = "0x400040A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000D5 RID: 213
		// (Invoke) Token: 0x060005B0 RID: 1456
		[Token(Token = "0x20000D5")]
		public delegate float RoundCone_0000030A$PostfixBurstDelegate(in float3 p, in float3 a, in float3 b, float r1, float r2);

		// Token: 0x020000D6 RID: 214
		[Token(Token = "0x20000D6")]
		internal static class RoundCone_0000030A$BurstDirectCall
		{
			// Token: 0x060005B3 RID: 1459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005B3")]
			[Address(RVA = "0x2428730", Offset = "0x2426D30", VA = "0x182428730")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005B4 RID: 1460 RVA: 0x00005310 File Offset: 0x00003510
			[Token(Token = "0x60005B4")]
			[Address(RVA = "0x2428860", Offset = "0x2426E60", VA = "0x182428860")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005B5 RID: 1461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005B5")]
			[Address(RVA = "0x24289C0", Offset = "0x2426FC0", VA = "0x1824289C0")]
			public static void Constructor()
			{
			}

			// Token: 0x060005B6 RID: 1462 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005B6")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005B8 RID: 1464 RVA: 0x00005328 File Offset: 0x00003528
			[Token(Token = "0x60005B8")]
			[Address(RVA = "0x2428A70", Offset = "0x2427070", VA = "0x182428A70")]
			public static float Invoke(in float3 p, in float3 a, in float3 b, float r1, float r2)
			{
				return 0f;
			}

			// Token: 0x0400040B RID: 1035
			[Token(Token = "0x400040B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400040C RID: 1036
			[Token(Token = "0x400040C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000D7 RID: 215
		// (Invoke) Token: 0x060005BA RID: 1466
		[Token(Token = "0x20000D7")]
		public delegate float Cylinder_0000030B$PostfixBurstDelegate(in float3 p, float h, float r, float rr = 0f);

		// Token: 0x020000D8 RID: 216
		[Token(Token = "0x20000D8")]
		internal static class Cylinder_0000030B$BurstDirectCall
		{
			// Token: 0x060005BD RID: 1469 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005BD")]
			[Address(RVA = "0x2428E70", Offset = "0x2427470", VA = "0x182428E70")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005BE RID: 1470 RVA: 0x00005340 File Offset: 0x00003540
			[Token(Token = "0x60005BE")]
			[Address(RVA = "0x2428FA0", Offset = "0x24275A0", VA = "0x182428FA0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005BF RID: 1471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005BF")]
			[Address(RVA = "0x2429100", Offset = "0x2427700", VA = "0x182429100")]
			public static void Constructor()
			{
			}

			// Token: 0x060005C0 RID: 1472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005C0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005C2 RID: 1474 RVA: 0x00005358 File Offset: 0x00003558
			[Token(Token = "0x60005C2")]
			[Address(RVA = "0x24291B0", Offset = "0x24277B0", VA = "0x1824291B0")]
			public static float Invoke(in float3 p, float h, float r, float rr = 0f)
			{
				return 0f;
			}

			// Token: 0x0400040D RID: 1037
			[Token(Token = "0x400040D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400040E RID: 1038
			[Token(Token = "0x400040E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000D9 RID: 217
		// (Invoke) Token: 0x060005C4 RID: 1476
		[Token(Token = "0x20000D9")]
		public delegate float Torus_0000030C$PostfixBurstDelegate(in float3 p, float h, float r1, float r2);

		// Token: 0x020000DA RID: 218
		[Token(Token = "0x20000DA")]
		internal static class Torus_0000030C$BurstDirectCall
		{
			// Token: 0x060005C7 RID: 1479 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005C7")]
			[Address(RVA = "0x24295D0", Offset = "0x2427BD0", VA = "0x1824295D0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005C8 RID: 1480 RVA: 0x00005370 File Offset: 0x00003570
			[Token(Token = "0x60005C8")]
			[Address(RVA = "0x2429700", Offset = "0x2427D00", VA = "0x182429700")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005C9 RID: 1481 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005C9")]
			[Address(RVA = "0x2429860", Offset = "0x2427E60", VA = "0x182429860")]
			public static void Constructor()
			{
			}

			// Token: 0x060005CA RID: 1482 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005CA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005CC RID: 1484 RVA: 0x00005388 File Offset: 0x00003588
			[Token(Token = "0x60005CC")]
			[Address(RVA = "0x2429910", Offset = "0x2427F10", VA = "0x182429910")]
			public static float Invoke(in float3 p, float h, float r1, float r2)
			{
				return 0f;
			}

			// Token: 0x0400040F RID: 1039
			[Token(Token = "0x400040F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000410 RID: 1040
			[Token(Token = "0x4000410")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000DB RID: 219
		// (Invoke) Token: 0x060005CE RID: 1486
		[Token(Token = "0x20000DB")]
		public delegate float SolidAngle_0000030D$PostfixBurstDelegate(in float3 p, in float2 c, float r, float rr = 0f);

		// Token: 0x020000DC RID: 220
		[Token(Token = "0x20000DC")]
		internal static class SolidAngle_0000030D$BurstDirectCall
		{
			// Token: 0x060005D1 RID: 1489 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D1")]
			[Address(RVA = "0x2429D70", Offset = "0x2428370", VA = "0x182429D70")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005D2 RID: 1490 RVA: 0x000053A0 File Offset: 0x000035A0
			[Token(Token = "0x60005D2")]
			[Address(RVA = "0x2429EA0", Offset = "0x24284A0", VA = "0x182429EA0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005D3 RID: 1491 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D3")]
			[Address(RVA = "0x242A000", Offset = "0x2428600", VA = "0x18242A000")]
			public static void Constructor()
			{
			}

			// Token: 0x060005D4 RID: 1492 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005D4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005D6 RID: 1494 RVA: 0x000053B8 File Offset: 0x000035B8
			[Token(Token = "0x60005D6")]
			[Address(RVA = "0x242A0B0", Offset = "0x24286B0", VA = "0x18242A0B0")]
			public static float Invoke(in float3 p, in float2 c, float r, float rr = 0f)
			{
				return 0f;
			}

			// Token: 0x04000411 RID: 1041
			[Token(Token = "0x4000411")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000412 RID: 1042
			[Token(Token = "0x4000412")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000DD RID: 221
		// (Invoke) Token: 0x060005D8 RID: 1496
		[Token(Token = "0x20000DD")]
		public delegate void Segment_0000030E$PostfixBurstDelegate(in float3 p, in float3 a, in float3 b, out float2 ret);

		// Token: 0x020000DE RID: 222
		[Token(Token = "0x20000DE")]
		internal static class Segment_0000030E$BurstDirectCall
		{
			// Token: 0x060005DB RID: 1499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005DB")]
			[Address(RVA = "0x242A4A0", Offset = "0x2428AA0", VA = "0x18242A4A0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005DC RID: 1500 RVA: 0x000053D0 File Offset: 0x000035D0
			[Token(Token = "0x60005DC")]
			[Address(RVA = "0x242A5D0", Offset = "0x2428BD0", VA = "0x18242A5D0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005DD RID: 1501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005DD")]
			[Address(RVA = "0x242A730", Offset = "0x2428D30", VA = "0x18242A730")]
			public static void Constructor()
			{
			}

			// Token: 0x060005DE RID: 1502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005DE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005E0 RID: 1504 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005E0")]
			[Address(RVA = "0x242A7E0", Offset = "0x2428DE0", VA = "0x18242A7E0")]
			public static void Invoke(in float3 p, in float3 a, in float3 b, out float2 ret)
			{
			}

			// Token: 0x04000413 RID: 1043
			[Token(Token = "0x4000413")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000414 RID: 1044
			[Token(Token = "0x4000414")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000DF RID: 223
		// (Invoke) Token: 0x060005E2 RID: 1506
		[Token(Token = "0x20000DF")]
		public delegate void Bezier_0000030F$PostfixBurstDelegate(in float3 pos, in float3 A, in float3 B, in float3 C, out float2 ret);

		// Token: 0x020000E0 RID: 224
		[Token(Token = "0x20000E0")]
		internal static class Bezier_0000030F$BurstDirectCall
		{
			// Token: 0x060005E5 RID: 1509 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005E5")]
			[Address(RVA = "0x242ABF0", Offset = "0x24291F0", VA = "0x18242ABF0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005E6 RID: 1510 RVA: 0x000053E8 File Offset: 0x000035E8
			[Token(Token = "0x60005E6")]
			[Address(RVA = "0x242AD20", Offset = "0x2429320", VA = "0x18242AD20")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005E7 RID: 1511 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005E7")]
			[Address(RVA = "0x242AE80", Offset = "0x2429480", VA = "0x18242AE80")]
			public static void Constructor()
			{
			}

			// Token: 0x060005E8 RID: 1512 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005E8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005EA RID: 1514 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005EA")]
			[Address(RVA = "0x242AF30", Offset = "0x2429530", VA = "0x18242AF30")]
			public static void Invoke(in float3 pos, in float3 A, in float3 B, in float3 C, out float2 ret)
			{
			}

			// Token: 0x04000415 RID: 1045
			[Token(Token = "0x4000415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000416 RID: 1046
			[Token(Token = "0x4000416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000E1 RID: 225
		// (Invoke) Token: 0x060005EC RID: 1516
		[Token(Token = "0x20000E1")]
		public delegate float Noise_00000310$PostfixBurstDelegate(int type, in float3 p, in float3 boundsMin, in float3 boundsMax, in float3 offset, in float3 size, float threshold, int numOctaves, float octaveOffsetFactor, in float3 period);

		// Token: 0x020000E2 RID: 226
		[Token(Token = "0x20000E2")]
		internal static class Noise_00000310$BurstDirectCall
		{
			// Token: 0x060005EF RID: 1519 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005EF")]
			[Address(RVA = "0x242B3D0", Offset = "0x24299D0", VA = "0x18242B3D0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005F0 RID: 1520 RVA: 0x00005400 File Offset: 0x00003600
			[Token(Token = "0x60005F0")]
			[Address(RVA = "0x242B500", Offset = "0x2429B00", VA = "0x18242B500")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005F1 RID: 1521 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005F1")]
			[Address(RVA = "0x242B660", Offset = "0x2429C60", VA = "0x18242B660")]
			public static void Constructor()
			{
			}

			// Token: 0x060005F2 RID: 1522 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005F2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005F4 RID: 1524 RVA: 0x00005418 File Offset: 0x00003618
			[Token(Token = "0x60005F4")]
			[Address(RVA = "0x242B710", Offset = "0x2429D10", VA = "0x18242B710")]
			public static float Invoke(int type, in float3 p, in float3 boundsMin, in float3 boundsMax, in float3 offset, in float3 size, float threshold, int numOctaves, float octaveOffsetFactor, in float3 period)
			{
				return 0f;
			}

			// Token: 0x04000417 RID: 1047
			[Token(Token = "0x4000417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000418 RID: 1048
			[Token(Token = "0x4000418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000E3 RID: 227
		// (Invoke) Token: 0x060005F6 RID: 1526
		[Token(Token = "0x20000E3")]
		public delegate float Rand_00000311$PostfixBurstDelegate(float s);

		// Token: 0x020000E4 RID: 228
		[Token(Token = "0x20000E4")]
		internal static class Rand_00000311$BurstDirectCall
		{
			// Token: 0x060005F9 RID: 1529 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005F9")]
			[Address(RVA = "0x242B9D0", Offset = "0x2429FD0", VA = "0x18242B9D0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060005FA RID: 1530 RVA: 0x00005430 File Offset: 0x00003630
			[Token(Token = "0x60005FA")]
			[Address(RVA = "0x242BB00", Offset = "0x242A100", VA = "0x18242BB00")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060005FB RID: 1531 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005FB")]
			[Address(RVA = "0x242BC60", Offset = "0x242A260", VA = "0x18242BC60")]
			public static void Constructor()
			{
			}

			// Token: 0x060005FC RID: 1532 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60005FC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060005FE RID: 1534 RVA: 0x00005448 File Offset: 0x00003648
			[Token(Token = "0x60005FE")]
			[Address(RVA = "0x242BD10", Offset = "0x242A310", VA = "0x18242BD10")]
			public static float Invoke(float s)
			{
				return 0f;
			}

			// Token: 0x04000419 RID: 1049
			[Token(Token = "0x4000419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400041A RID: 1050
			[Token(Token = "0x400041A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000E5 RID: 229
		// (Invoke) Token: 0x06000600 RID: 1536
		[Token(Token = "0x20000E5")]
		public delegate float Rand_00000312$PostfixBurstDelegate(in float2 s);

		// Token: 0x020000E6 RID: 230
		[Token(Token = "0x20000E6")]
		internal static class Rand_00000312$BurstDirectCall
		{
			// Token: 0x06000603 RID: 1539 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000603")]
			[Address(RVA = "0x242C040", Offset = "0x242A640", VA = "0x18242C040")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000604 RID: 1540 RVA: 0x00005460 File Offset: 0x00003660
			[Token(Token = "0x6000604")]
			[Address(RVA = "0x242C170", Offset = "0x242A770", VA = "0x18242C170")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000605 RID: 1541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000605")]
			[Address(RVA = "0x242C2D0", Offset = "0x242A8D0", VA = "0x18242C2D0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000606 RID: 1542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000606")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000608 RID: 1544 RVA: 0x00005478 File Offset: 0x00003678
			[Token(Token = "0x6000608")]
			[Address(RVA = "0x242C380", Offset = "0x242A980", VA = "0x18242C380")]
			public static float Invoke(in float2 s)
			{
				return 0f;
			}

			// Token: 0x0400041B RID: 1051
			[Token(Token = "0x400041B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400041C RID: 1052
			[Token(Token = "0x400041C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000E7 RID: 231
		// (Invoke) Token: 0x0600060A RID: 1546
		[Token(Token = "0x20000E7")]
		public delegate float Rand_00000313$PostfixBurstDelegate(in float3 s);

		// Token: 0x020000E8 RID: 232
		[Token(Token = "0x20000E8")]
		internal static class Rand_00000313$BurstDirectCall
		{
			// Token: 0x0600060D RID: 1549 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600060D")]
			[Address(RVA = "0x242C6E0", Offset = "0x242ACE0", VA = "0x18242C6E0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600060E RID: 1550 RVA: 0x00005490 File Offset: 0x00003690
			[Token(Token = "0x600060E")]
			[Address(RVA = "0x242C810", Offset = "0x242AE10", VA = "0x18242C810")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600060F RID: 1551 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600060F")]
			[Address(RVA = "0x242C970", Offset = "0x242AF70", VA = "0x18242C970")]
			public static void Constructor()
			{
			}

			// Token: 0x06000610 RID: 1552 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000610")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000612 RID: 1554 RVA: 0x000054A8 File Offset: 0x000036A8
			[Token(Token = "0x6000612")]
			[Address(RVA = "0x242CA20", Offset = "0x242B020", VA = "0x18242CA20")]
			public static float Invoke(in float3 s)
			{
				return 0f;
			}

			// Token: 0x0400041D RID: 1053
			[Token(Token = "0x400041D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400041E RID: 1054
			[Token(Token = "0x400041E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000E9 RID: 233
		// (Invoke) Token: 0x06000614 RID: 1556
		[Token(Token = "0x20000E9")]
		public delegate void Mod_00000314$PostfixBurstDelegate(float x, float y, out float ret);

		// Token: 0x020000EA RID: 234
		[Token(Token = "0x20000EA")]
		internal static class Mod_00000314$BurstDirectCall
		{
			// Token: 0x06000617 RID: 1559 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000617")]
			[Address(RVA = "0x242CEB0", Offset = "0x242B4B0", VA = "0x18242CEB0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000618 RID: 1560 RVA: 0x000054C0 File Offset: 0x000036C0
			[Token(Token = "0x6000618")]
			[Address(RVA = "0x242CFE0", Offset = "0x242B5E0", VA = "0x18242CFE0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000619 RID: 1561 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000619")]
			[Address(RVA = "0x242D140", Offset = "0x242B740", VA = "0x18242D140")]
			public static void Constructor()
			{
			}

			// Token: 0x0600061A RID: 1562 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600061A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600061C RID: 1564 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600061C")]
			[Address(RVA = "0x242D1F0", Offset = "0x242B7F0", VA = "0x18242D1F0")]
			public static void Invoke(float x, float y, out float ret)
			{
			}

			// Token: 0x0400041F RID: 1055
			[Token(Token = "0x400041F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000420 RID: 1056
			[Token(Token = "0x4000420")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000EB RID: 235
		// (Invoke) Token: 0x0600061E RID: 1566
		[Token(Token = "0x20000EB")]
		public delegate void Mod_00000315$PostfixBurstDelegate(in float2 x, in float2 y, out float2 ret);

		// Token: 0x020000EC RID: 236
		[Token(Token = "0x20000EC")]
		internal static class Mod_00000315$BurstDirectCall
		{
			// Token: 0x06000621 RID: 1569 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000621")]
			[Address(RVA = "0x242D5B0", Offset = "0x242BBB0", VA = "0x18242D5B0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000622 RID: 1570 RVA: 0x000054D8 File Offset: 0x000036D8
			[Token(Token = "0x6000622")]
			[Address(RVA = "0x242D6E0", Offset = "0x242BCE0", VA = "0x18242D6E0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000623 RID: 1571 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000623")]
			[Address(RVA = "0x242D840", Offset = "0x242BE40", VA = "0x18242D840")]
			public static void Constructor()
			{
			}

			// Token: 0x06000624 RID: 1572 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000624")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000626 RID: 1574 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000626")]
			[Address(RVA = "0x242D8F0", Offset = "0x242BEF0", VA = "0x18242D8F0")]
			public static void Invoke(in float2 x, in float2 y, out float2 ret)
			{
			}

			// Token: 0x04000421 RID: 1057
			[Token(Token = "0x4000421")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000422 RID: 1058
			[Token(Token = "0x4000422")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000ED RID: 237
		// (Invoke) Token: 0x06000628 RID: 1576
		[Token(Token = "0x20000ED")]
		public delegate void Mod_00000316$PostfixBurstDelegate(in float3 x, in float3 y, out float3 ret);

		// Token: 0x020000EE RID: 238
		[Token(Token = "0x20000EE")]
		internal static class Mod_00000316$BurstDirectCall
		{
			// Token: 0x0600062B RID: 1579 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600062B")]
			[Address(RVA = "0x242DC60", Offset = "0x242C260", VA = "0x18242DC60")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600062C RID: 1580 RVA: 0x000054F0 File Offset: 0x000036F0
			[Token(Token = "0x600062C")]
			[Address(RVA = "0x242DD90", Offset = "0x242C390", VA = "0x18242DD90")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600062D RID: 1581 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600062D")]
			[Address(RVA = "0x242DEF0", Offset = "0x242C4F0", VA = "0x18242DEF0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600062E RID: 1582 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600062E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000630 RID: 1584 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000630")]
			[Address(RVA = "0x242DFA0", Offset = "0x242C5A0", VA = "0x18242DFA0")]
			public static void Invoke(in float3 x, in float3 y, out float3 ret)
			{
			}

			// Token: 0x04000423 RID: 1059
			[Token(Token = "0x4000423")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000424 RID: 1060
			[Token(Token = "0x4000424")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000EF RID: 239
		// (Invoke) Token: 0x06000632 RID: 1586
		[Token(Token = "0x20000EF")]
		public delegate void Mod_00000317$PostfixBurstDelegate(in float4 x, in float4 y, out float4 ret);

		// Token: 0x020000F0 RID: 240
		[Token(Token = "0x20000F0")]
		internal static class Mod_00000317$BurstDirectCall
		{
			// Token: 0x06000635 RID: 1589 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000635")]
			[Address(RVA = "0x242E380", Offset = "0x242C980", VA = "0x18242E380")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000636 RID: 1590 RVA: 0x00005508 File Offset: 0x00003708
			[Token(Token = "0x6000636")]
			[Address(RVA = "0x242E4B0", Offset = "0x242CAB0", VA = "0x18242E4B0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000637 RID: 1591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000637")]
			[Address(RVA = "0x242E610", Offset = "0x242CC10", VA = "0x18242E610")]
			public static void Constructor()
			{
			}

			// Token: 0x06000638 RID: 1592 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000638")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600063A RID: 1594 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600063A")]
			[Address(RVA = "0x242E6C0", Offset = "0x242CCC0", VA = "0x18242E6C0")]
			public static void Invoke(in float4 x, in float4 y, out float4 ret)
			{
			}

			// Token: 0x04000425 RID: 1061
			[Token(Token = "0x4000425")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000426 RID: 1062
			[Token(Token = "0x4000426")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000F1 RID: 241
		// (Invoke) Token: 0x0600063C RID: 1596
		[Token(Token = "0x20000F1")]
		public delegate void Mod289_00000318$PostfixBurstDelegate(in float2 x, out float2 ret);

		// Token: 0x020000F2 RID: 242
		[Token(Token = "0x20000F2")]
		internal static class Mod289_00000318$BurstDirectCall
		{
			// Token: 0x0600063F RID: 1599 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600063F")]
			[Address(RVA = "0x242EAC0", Offset = "0x242D0C0", VA = "0x18242EAC0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000640 RID: 1600 RVA: 0x00005520 File Offset: 0x00003720
			[Token(Token = "0x6000640")]
			[Address(RVA = "0x242EBF0", Offset = "0x242D1F0", VA = "0x18242EBF0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000641 RID: 1601 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000641")]
			[Address(RVA = "0x242ED50", Offset = "0x242D350", VA = "0x18242ED50")]
			public static void Constructor()
			{
			}

			// Token: 0x06000642 RID: 1602 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000642")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000644 RID: 1604 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000644")]
			[Address(RVA = "0x242EE00", Offset = "0x242D400", VA = "0x18242EE00")]
			public static void Invoke(in float2 x, out float2 ret)
			{
			}

			// Token: 0x04000427 RID: 1063
			[Token(Token = "0x4000427")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000428 RID: 1064
			[Token(Token = "0x4000428")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000F3 RID: 243
		// (Invoke) Token: 0x06000646 RID: 1606
		[Token(Token = "0x20000F3")]
		public delegate void Mod289_00000319$PostfixBurstDelegate(in float3 x, out float3 ret);

		// Token: 0x020000F4 RID: 244
		[Token(Token = "0x20000F4")]
		internal static class Mod289_00000319$BurstDirectCall
		{
			// Token: 0x06000649 RID: 1609 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000649")]
			[Address(RVA = "0x242F150", Offset = "0x242D750", VA = "0x18242F150")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600064A RID: 1610 RVA: 0x00005538 File Offset: 0x00003738
			[Token(Token = "0x600064A")]
			[Address(RVA = "0x242F280", Offset = "0x242D880", VA = "0x18242F280")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600064B RID: 1611 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600064B")]
			[Address(RVA = "0x242F3E0", Offset = "0x242D9E0", VA = "0x18242F3E0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600064C RID: 1612 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600064C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600064E RID: 1614 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600064E")]
			[Address(RVA = "0x242F490", Offset = "0x242DA90", VA = "0x18242F490")]
			public static void Invoke(in float3 x, out float3 ret)
			{
			}

			// Token: 0x04000429 RID: 1065
			[Token(Token = "0x4000429")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400042A RID: 1066
			[Token(Token = "0x400042A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000F5 RID: 245
		// (Invoke) Token: 0x06000650 RID: 1616
		[Token(Token = "0x20000F5")]
		public delegate void Mod289_0000031A$PostfixBurstDelegate(in float4 x, out float4 ret);

		// Token: 0x020000F6 RID: 246
		[Token(Token = "0x20000F6")]
		internal static class Mod289_0000031A$BurstDirectCall
		{
			// Token: 0x06000653 RID: 1619 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000653")]
			[Address(RVA = "0x242F830", Offset = "0x242DE30", VA = "0x18242F830")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000654 RID: 1620 RVA: 0x00005550 File Offset: 0x00003750
			[Token(Token = "0x6000654")]
			[Address(RVA = "0x242F960", Offset = "0x242DF60", VA = "0x18242F960")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000655 RID: 1621 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000655")]
			[Address(RVA = "0x242FAC0", Offset = "0x242E0C0", VA = "0x18242FAC0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000656 RID: 1622 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000656")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000658 RID: 1624 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000658")]
			[Address(RVA = "0x242FB70", Offset = "0x242E170", VA = "0x18242FB70")]
			public static void Invoke(in float4 x, out float4 ret)
			{
			}

			// Token: 0x0400042B RID: 1067
			[Token(Token = "0x400042B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400042C RID: 1068
			[Token(Token = "0x400042C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000F7 RID: 247
		// (Invoke) Token: 0x0600065A RID: 1626
		[Token(Token = "0x20000F7")]
		public delegate void Permute_0000031B$PostfixBurstDelegate(in float3 x, out float3 ret);

		// Token: 0x020000F8 RID: 248
		[Token(Token = "0x20000F8")]
		internal static class Permute_0000031B$BurstDirectCall
		{
			// Token: 0x0600065D RID: 1629 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600065D")]
			[Address(RVA = "0x242FF50", Offset = "0x242E550", VA = "0x18242FF50")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600065E RID: 1630 RVA: 0x00005568 File Offset: 0x00003768
			[Token(Token = "0x600065E")]
			[Address(RVA = "0x2430080", Offset = "0x242E680", VA = "0x182430080")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600065F RID: 1631 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600065F")]
			[Address(RVA = "0x24301E0", Offset = "0x242E7E0", VA = "0x1824301E0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000660 RID: 1632 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000660")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000662 RID: 1634 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000662")]
			[Address(RVA = "0x2430290", Offset = "0x242E890", VA = "0x182430290")]
			public static void Invoke(in float3 x, out float3 ret)
			{
			}

			// Token: 0x0400042D RID: 1069
			[Token(Token = "0x400042D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400042E RID: 1070
			[Token(Token = "0x400042E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000F9 RID: 249
		// (Invoke) Token: 0x06000664 RID: 1636
		[Token(Token = "0x20000F9")]
		public delegate void Permute_0000031C$PostfixBurstDelegate(in float4 x, out float4 ret);

		// Token: 0x020000FA RID: 250
		[Token(Token = "0x20000FA")]
		internal static class Permute_0000031C$BurstDirectCall
		{
			// Token: 0x06000667 RID: 1639 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000667")]
			[Address(RVA = "0x2430620", Offset = "0x242EC20", VA = "0x182430620")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000668 RID: 1640 RVA: 0x00005580 File Offset: 0x00003780
			[Token(Token = "0x6000668")]
			[Address(RVA = "0x2430750", Offset = "0x242ED50", VA = "0x182430750")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000669 RID: 1641 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000669")]
			[Address(RVA = "0x24308B0", Offset = "0x242EEB0", VA = "0x1824308B0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600066A RID: 1642 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600066A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600066C RID: 1644 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x2430960", Offset = "0x242EF60", VA = "0x182430960")]
			public static void Invoke(in float4 x, out float4 ret)
			{
			}

			// Token: 0x0400042F RID: 1071
			[Token(Token = "0x400042F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000430 RID: 1072
			[Token(Token = "0x4000430")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000FB RID: 251
		// (Invoke) Token: 0x0600066E RID: 1646
		[Token(Token = "0x20000FB")]
		public delegate void TaylorInvSqrt_0000031D$PostfixBurstDelegate(in float3 r, out float3 ret);

		// Token: 0x020000FC RID: 252
		[Token(Token = "0x20000FC")]
		internal static class TaylorInvSqrt_0000031D$BurstDirectCall
		{
			// Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000671")]
			[Address(RVA = "0x2430D10", Offset = "0x242F310", VA = "0x182430D10")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000672 RID: 1650 RVA: 0x00005598 File Offset: 0x00003798
			[Token(Token = "0x6000672")]
			[Address(RVA = "0x2430E40", Offset = "0x242F440", VA = "0x182430E40")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000673 RID: 1651 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000673")]
			[Address(RVA = "0x2430FA0", Offset = "0x242F5A0", VA = "0x182430FA0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000674 RID: 1652 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000676 RID: 1654 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000676")]
			[Address(RVA = "0x2431050", Offset = "0x242F650", VA = "0x182431050")]
			public static void Invoke(in float3 r, out float3 ret)
			{
			}

			// Token: 0x04000431 RID: 1073
			[Token(Token = "0x4000431")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000432 RID: 1074
			[Token(Token = "0x4000432")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000FD RID: 253
		// (Invoke) Token: 0x06000678 RID: 1656
		[Token(Token = "0x20000FD")]
		public delegate void TaylorInvSqrt_0000031E$PostfixBurstDelegate(in float4 r, out float4 ret);

		// Token: 0x020000FE RID: 254
		[Token(Token = "0x20000FE")]
		internal static class TaylorInvSqrt_0000031E$BurstDirectCall
		{
			// Token: 0x0600067B RID: 1659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600067B")]
			[Address(RVA = "0x2431350", Offset = "0x242F950", VA = "0x182431350")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600067C RID: 1660 RVA: 0x000055B0 File Offset: 0x000037B0
			[Token(Token = "0x600067C")]
			[Address(RVA = "0x2431480", Offset = "0x242FA80", VA = "0x182431480")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600067D RID: 1661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600067D")]
			[Address(RVA = "0x24315E0", Offset = "0x242FBE0", VA = "0x1824315E0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600067E RID: 1662 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600067E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000680 RID: 1664 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000680")]
			[Address(RVA = "0x2431690", Offset = "0x242FC90", VA = "0x182431690")]
			public static void Invoke(in float4 r, out float4 ret)
			{
			}

			// Token: 0x04000433 RID: 1075
			[Token(Token = "0x4000433")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000434 RID: 1076
			[Token(Token = "0x4000434")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x020000FF RID: 255
		// (Invoke) Token: 0x06000682 RID: 1666
		[Token(Token = "0x20000FF")]
		public delegate void Fade_0000031F$PostfixBurstDelegate(in float2 t, out float2 ret);

		// Token: 0x02000100 RID: 256
		[Token(Token = "0x2000100")]
		internal static class Fade_0000031F$BurstDirectCall
		{
			// Token: 0x06000685 RID: 1669 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000685")]
			[Address(RVA = "0x24319B0", Offset = "0x242FFB0", VA = "0x1824319B0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000686 RID: 1670 RVA: 0x000055C8 File Offset: 0x000037C8
			[Token(Token = "0x6000686")]
			[Address(RVA = "0x2431AE0", Offset = "0x24300E0", VA = "0x182431AE0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000687 RID: 1671 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000687")]
			[Address(RVA = "0x2431C40", Offset = "0x2430240", VA = "0x182431C40")]
			public static void Constructor()
			{
			}

			// Token: 0x06000688 RID: 1672 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000688")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600068A RID: 1674 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600068A")]
			[Address(RVA = "0x2431CF0", Offset = "0x24302F0", VA = "0x182431CF0")]
			public static void Invoke(in float2 t, out float2 ret)
			{
			}

			// Token: 0x04000435 RID: 1077
			[Token(Token = "0x4000435")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000436 RID: 1078
			[Token(Token = "0x4000436")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000101 RID: 257
		// (Invoke) Token: 0x0600068C RID: 1676
		[Token(Token = "0x2000101")]
		public delegate void Fade_00000320$PostfixBurstDelegate(in float3 t, out float3 ret);

		// Token: 0x02000102 RID: 258
		[Token(Token = "0x2000102")]
		internal static class Fade_00000320$BurstDirectCall
		{
			// Token: 0x0600068F RID: 1679 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600068F")]
			[Address(RVA = "0x2432010", Offset = "0x2430610", VA = "0x182432010")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000690 RID: 1680 RVA: 0x000055E0 File Offset: 0x000037E0
			[Token(Token = "0x6000690")]
			[Address(RVA = "0x2432140", Offset = "0x2430740", VA = "0x182432140")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000691 RID: 1681 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000691")]
			[Address(RVA = "0x24322A0", Offset = "0x24308A0", VA = "0x1824322A0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000692 RID: 1682 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000692")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000694 RID: 1684 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000694")]
			[Address(RVA = "0x2432350", Offset = "0x2430950", VA = "0x182432350")]
			public static void Invoke(in float3 t, out float3 ret)
			{
			}

			// Token: 0x04000437 RID: 1079
			[Token(Token = "0x4000437")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000438 RID: 1080
			[Token(Token = "0x4000438")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000103 RID: 259
		// (Invoke) Token: 0x06000696 RID: 1686
		[Token(Token = "0x2000103")]
		public delegate int Index_00000321$PostfixBurstDelegate(in int3 id, in int3 dimension);

		// Token: 0x02000104 RID: 260
		[Token(Token = "0x2000104")]
		internal static class Index_00000321$BurstDirectCall
		{
			// Token: 0x06000699 RID: 1689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000699")]
			[Address(RVA = "0x2432710", Offset = "0x2430D10", VA = "0x182432710")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600069A RID: 1690 RVA: 0x000055F8 File Offset: 0x000037F8
			[Token(Token = "0x600069A")]
			[Address(RVA = "0x2432840", Offset = "0x2430E40", VA = "0x182432840")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600069B RID: 1691 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600069B")]
			[Address(RVA = "0x24329A0", Offset = "0x2430FA0", VA = "0x1824329A0")]
			public static void Constructor()
			{
			}

			// Token: 0x0600069C RID: 1692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600069C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600069E RID: 1694 RVA: 0x00005610 File Offset: 0x00003810
			[Token(Token = "0x600069E")]
			[Address(RVA = "0x2432A50", Offset = "0x2431050", VA = "0x182432A50")]
			public static int Invoke(in int3 id, in int3 dimension)
			{
				return 0;
			}

			// Token: 0x04000439 RID: 1081
			[Token(Token = "0x4000439")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400043A RID: 1082
			[Token(Token = "0x400043A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000105 RID: 261
		// (Invoke) Token: 0x060006A0 RID: 1696
		[Token(Token = "0x2000105")]
		public delegate void UnitTriWave_00000322$PostfixBurstDelegate(in float3 x, out float3 ret);

		// Token: 0x02000106 RID: 262
		[Token(Token = "0x2000106")]
		internal static class UnitTriWave_00000322$BurstDirectCall
		{
			// Token: 0x060006A3 RID: 1699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006A3")]
			[Address(RVA = "0x2432D00", Offset = "0x2431300", VA = "0x182432D00")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006A4 RID: 1700 RVA: 0x00005628 File Offset: 0x00003828
			[Token(Token = "0x60006A4")]
			[Address(RVA = "0x2432E30", Offset = "0x2431430", VA = "0x182432E30")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006A5 RID: 1701 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006A5")]
			[Address(RVA = "0x2432F90", Offset = "0x2431590", VA = "0x182432F90")]
			public static void Constructor()
			{
			}

			// Token: 0x060006A6 RID: 1702 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006A6")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006A8 RID: 1704 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006A8")]
			[Address(RVA = "0x2433040", Offset = "0x2431640", VA = "0x182433040")]
			public static void Invoke(in float3 x, out float3 ret)
			{
			}

			// Token: 0x0400043B RID: 1083
			[Token(Token = "0x400043B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400043C RID: 1084
			[Token(Token = "0x400043C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000107 RID: 263
		// (Invoke) Token: 0x060006AA RID: 1706
		[Token(Token = "0x2000107")]
		public delegate float PNoise_00000323$PostfixBurstDelegate(in float3 P, in float3 rep);

		// Token: 0x02000108 RID: 264
		[Token(Token = "0x2000108")]
		internal static class PNoise_00000323$BurstDirectCall
		{
			// Token: 0x060006AD RID: 1709 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006AD")]
			[Address(RVA = "0x2433410", Offset = "0x2431A10", VA = "0x182433410")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006AE RID: 1710 RVA: 0x00005640 File Offset: 0x00003840
			[Token(Token = "0x60006AE")]
			[Address(RVA = "0x2433540", Offset = "0x2431B40", VA = "0x182433540")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006AF RID: 1711 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006AF")]
			[Address(RVA = "0x24336A0", Offset = "0x2431CA0", VA = "0x1824336A0")]
			public static void Constructor()
			{
			}

			// Token: 0x060006B0 RID: 1712 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006B0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006B2 RID: 1714 RVA: 0x00005658 File Offset: 0x00003858
			[Token(Token = "0x60006B2")]
			[Address(RVA = "0x2433750", Offset = "0x2431D50", VA = "0x182433750")]
			public static float Invoke(in float3 P, in float3 rep)
			{
				return 0f;
			}

			// Token: 0x0400043D RID: 1085
			[Token(Token = "0x400043D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400043E RID: 1086
			[Token(Token = "0x400043E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000109 RID: 265
		// (Invoke) Token: 0x060006B4 RID: 1716
		[Token(Token = "0x2000109")]
		public delegate float PNoise_00000324$PostfixBurstDelegate(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor, in float3 period);

		// Token: 0x0200010A RID: 266
		[Token(Token = "0x200010A")]
		internal static class PNoise_00000324$BurstDirectCall
		{
			// Token: 0x060006B7 RID: 1719 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006B7")]
			[Address(RVA = "0x2433B40", Offset = "0x2432140", VA = "0x182433B40")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006B8 RID: 1720 RVA: 0x00005670 File Offset: 0x00003870
			[Token(Token = "0x60006B8")]
			[Address(RVA = "0x2433C70", Offset = "0x2432270", VA = "0x182433C70")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006B9 RID: 1721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006B9")]
			[Address(RVA = "0x2433DD0", Offset = "0x24323D0", VA = "0x182433DD0")]
			public static void Constructor()
			{
			}

			// Token: 0x060006BA RID: 1722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006BA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006BC RID: 1724 RVA: 0x00005688 File Offset: 0x00003888
			[Token(Token = "0x60006BC")]
			[Address(RVA = "0x2433E80", Offset = "0x2432480", VA = "0x182433E80")]
			public static float Invoke(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor, in float3 period)
			{
				return 0f;
			}

			// Token: 0x0400043F RID: 1087
			[Token(Token = "0x400043F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000440 RID: 1088
			[Token(Token = "0x4000440")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200010B RID: 267
		// (Invoke) Token: 0x060006BE RID: 1726
		[Token(Token = "0x200010B")]
		public delegate float CachedNoise_00000325$PostfixBurstDelegate(in float3 s);

		// Token: 0x0200010C RID: 268
		[Token(Token = "0x200010C")]
		internal static class CachedNoise_00000325$BurstDirectCall
		{
			// Token: 0x060006C1 RID: 1729 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006C1")]
			[Address(RVA = "0x24343F0", Offset = "0x24329F0", VA = "0x1824343F0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006C2 RID: 1730 RVA: 0x000056A0 File Offset: 0x000038A0
			[Token(Token = "0x60006C2")]
			[Address(RVA = "0x2434520", Offset = "0x2432B20", VA = "0x182434520")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006C3 RID: 1731 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006C3")]
			[Address(RVA = "0x2434680", Offset = "0x2432C80", VA = "0x182434680")]
			public static void Constructor()
			{
			}

			// Token: 0x060006C4 RID: 1732 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006C4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006C6 RID: 1734 RVA: 0x000056B8 File Offset: 0x000038B8
			[Token(Token = "0x60006C6")]
			[Address(RVA = "0x2434730", Offset = "0x2432D30", VA = "0x182434730")]
			public static float Invoke(in float3 s)
			{
				return 0f;
			}

			// Token: 0x04000441 RID: 1089
			[Token(Token = "0x4000441")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000442 RID: 1090
			[Token(Token = "0x4000442")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200010D RID: 269
		// (Invoke) Token: 0x060006C8 RID: 1736
		[Token(Token = "0x200010D")]
		public delegate float CachedNoise_00000326$PostfixBurstDelegate(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor);

		// Token: 0x0200010E RID: 270
		[Token(Token = "0x200010E")]
		internal static class CachedNoise_00000326$BurstDirectCall
		{
			// Token: 0x060006CB RID: 1739 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006CB")]
			[Address(RVA = "0x2434BD0", Offset = "0x24331D0", VA = "0x182434BD0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x000056D0 File Offset: 0x000038D0
			[Token(Token = "0x60006CC")]
			[Address(RVA = "0x2434D00", Offset = "0x2433300", VA = "0x182434D00")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006CD RID: 1741 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006CD")]
			[Address(RVA = "0x2434E60", Offset = "0x2433460", VA = "0x182434E60")]
			public static void Constructor()
			{
			}

			// Token: 0x060006CE RID: 1742 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006CE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006D0 RID: 1744 RVA: 0x000056E8 File Offset: 0x000038E8
			[Token(Token = "0x60006D0")]
			[Address(RVA = "0x2434F10", Offset = "0x2433510", VA = "0x182434F10")]
			public static float Invoke(in float3 s, in float3 offset, int numOctaves, float octaveOffsetFactor)
			{
				return 0f;
			}

			// Token: 0x04000443 RID: 1091
			[Token(Token = "0x4000443")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000444 RID: 1092
			[Token(Token = "0x4000444")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200010F RID: 271
		// (Invoke) Token: 0x060006D2 RID: 1746
		[Token(Token = "0x200010F")]
		public delegate float TriangleNoise_00000327$PostfixBurstDelegate(in float3 p);

		// Token: 0x02000110 RID: 272
		[Token(Token = "0x2000110")]
		internal static class TriangleNoise_00000327$BurstDirectCall
		{
			// Token: 0x060006D5 RID: 1749 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006D5")]
			[Address(RVA = "0x2435420", Offset = "0x2433A20", VA = "0x182435420")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00005700 File Offset: 0x00003900
			[Token(Token = "0x60006D6")]
			[Address(RVA = "0x2435550", Offset = "0x2433B50", VA = "0x182435550")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006D7 RID: 1751 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006D7")]
			[Address(RVA = "0x24356B0", Offset = "0x2433CB0", VA = "0x1824356B0")]
			public static void Constructor()
			{
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006D8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00005718 File Offset: 0x00003918
			[Token(Token = "0x60006DA")]
			[Address(RVA = "0x2435760", Offset = "0x2433D60", VA = "0x182435760")]
			public static float Invoke(in float3 p)
			{
				return 0f;
			}

			// Token: 0x04000445 RID: 1093
			[Token(Token = "0x4000445")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000446 RID: 1094
			[Token(Token = "0x4000446")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000111 RID: 273
		// (Invoke) Token: 0x060006DC RID: 1756
		[Token(Token = "0x2000111")]
		public delegate float TriangleNoise_00000328$PostfixBurstDelegate(in float3 s, in float3 offset, int numOctaves, in float octaveOffsetFactor);

		// Token: 0x02000112 RID: 274
		[Token(Token = "0x2000112")]
		internal static class TriangleNoise_00000328$BurstDirectCall
		{
			// Token: 0x060006DF RID: 1759 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006DF")]
			[Address(RVA = "0x2435A30", Offset = "0x2434030", VA = "0x182435A30")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00005730 File Offset: 0x00003930
			[Token(Token = "0x60006E0")]
			[Address(RVA = "0x2435B60", Offset = "0x2434160", VA = "0x182435B60")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060006E1 RID: 1761 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006E1")]
			[Address(RVA = "0x2435CC0", Offset = "0x24342C0", VA = "0x182435CC0")]
			public static void Constructor()
			{
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60006E2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060006E4 RID: 1764 RVA: 0x00005748 File Offset: 0x00003948
			[Token(Token = "0x60006E4")]
			[Address(RVA = "0x2435D70", Offset = "0x2434370", VA = "0x182435D70")]
			public static float Invoke(in float3 s, in float3 offset, int numOctaves, in float octaveOffsetFactor)
			{
				return 0f;
			}

			// Token: 0x04000447 RID: 1095
			[Token(Token = "0x4000447")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000448 RID: 1096
			[Token(Token = "0x4000448")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
