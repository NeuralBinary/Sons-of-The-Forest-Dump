using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;

namespace MudBun
{
	// Token: 0x0200011A RID: 282
	[Token(Token = "0x200011A")]
	[BurstCompile]
	public class MathUtil
	{
		// Token: 0x06000707 RID: 1799 RVA: 0x00005778 File Offset: 0x00003978
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x243F260", Offset = "0x243D860", VA = "0x18243F260")]
		[BurstCompile]
		public static float AsinSafe(float x)
		{
			return 0f;
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x00005790 File Offset: 0x00003990
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x243F2B0", Offset = "0x243D8B0", VA = "0x18243F2B0")]
		[BurstCompile]
		public static float AcosSafe(float x)
		{
			return 0f;
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x000057A8 File Offset: 0x000039A8
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x243F300", Offset = "0x243D900", VA = "0x18243F300")]
		[BurstCompile]
		public static float InvSafe(float x)
		{
			return 0f;
		}

		// Token: 0x0600070A RID: 1802 RVA: 0x000057C0 File Offset: 0x000039C0
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x243F350", Offset = "0x243D950", VA = "0x18243F350")]
		[BurstCompile]
		public static float BezierQuad(float a, float b, float controlPoint, float t)
		{
			return 0f;
		}

		// Token: 0x0600070B RID: 1803 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x243F3F0", Offset = "0x243D9F0", VA = "0x18243F3F0")]
		[BurstCompile]
		public static void BezierQuad(in float2 a, in float2 b, in float2 controlPoint, float t, out float2 ret)
		{
		}

		// Token: 0x0600070C RID: 1804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070C")]
		[Address(RVA = "0x243F470", Offset = "0x243DA70", VA = "0x18243F470")]
		[BurstCompile]
		public static void BezierQuad(in float3 a, in float3 b, in float3 controlPoint, float t, out float3 ret)
		{
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070D")]
		[Address(RVA = "0x243F4F0", Offset = "0x243DAF0", VA = "0x18243F4F0")]
		[BurstCompile]
		public static void BezierQuad(in float4 a, in float4 b, in float4 controlPoint, float t, out float4 ret)
		{
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x000057D8 File Offset: 0x000039D8
		[Token(Token = "0x600070E")]
		[Address(RVA = "0x243F570", Offset = "0x243DB70", VA = "0x18243F570")]
		[BurstCompile]
		public static float CatmullRom(float p0, float p1, float p2, float p3, float t)
		{
			return 0f;
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600070F")]
		[Address(RVA = "0x243F610", Offset = "0x243DC10", VA = "0x18243F610")]
		[BurstCompile]
		public static void CatmullRom(in float2 p0, in float2 p1, in float2 p2, in float2 p3, float t, out float2 ret)
		{
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x243F6A0", Offset = "0x243DCA0", VA = "0x18243F6A0")]
		[BurstCompile]
		public static void CatmullRom(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 ret)
		{
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x243F730", Offset = "0x243DD30", VA = "0x18243F730")]
		[BurstCompile]
		public static void CatmullRom(in float4 p0, in float4 p1, in float4 p2, in float4 p3, float t, out float4 ret)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x000057F0 File Offset: 0x000039F0
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x243F7C0", Offset = "0x243DDC0", VA = "0x18243F7C0")]
		[BurstCompile]
		public static float Saturate(float x)
		{
			return 0f;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public MathUtil()
		{
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x00005808 File Offset: 0x00003A08
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x243FA10", Offset = "0x243E010", VA = "0x18243FA10")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AsinSafe$BurstManaged(float x)
		{
			return 0f;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x00005820 File Offset: 0x00003A20
		[Token(Token = "0x6000716")]
		[Address(RVA = "0x243FA40", Offset = "0x243E040", VA = "0x18243FA40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float AcosSafe$BurstManaged(float x)
		{
			return 0f;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x00005838 File Offset: 0x00003A38
		[Token(Token = "0x6000717")]
		[Address(RVA = "0x243FA70", Offset = "0x243E070", VA = "0x18243FA70")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float InvSafe$BurstManaged(float x)
		{
			return 0f;
		}

		// Token: 0x06000718 RID: 1816 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x6000718")]
		[Address(RVA = "0x243FAE0", Offset = "0x243E0E0", VA = "0x18243FAE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float BezierQuad$BurstManaged(float a, float b, float controlPoint, float t)
		{
			return 0f;
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000719")]
		[Address(RVA = "0x243FB40", Offset = "0x243E140", VA = "0x18243FB40")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BezierQuad$BurstManaged(in float2 a, in float2 b, in float2 controlPoint, float t, out float2 ret)
		{
		}

		// Token: 0x0600071A RID: 1818 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071A")]
		[Address(RVA = "0x243FBF0", Offset = "0x243E1F0", VA = "0x18243FBF0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BezierQuad$BurstManaged(in float3 a, in float3 b, in float3 controlPoint, float t, out float3 ret)
		{
		}

		// Token: 0x0600071B RID: 1819 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071B")]
		[Address(RVA = "0x243FD50", Offset = "0x243E350", VA = "0x18243FD50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void BezierQuad$BurstManaged(in float4 a, in float4 b, in float4 controlPoint, float t, out float4 ret)
		{
		}

		// Token: 0x0600071C RID: 1820 RVA: 0x00005868 File Offset: 0x00003A68
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x243FF00", Offset = "0x243E500", VA = "0x18243FF00")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float CatmullRom$BurstManaged(float p0, float p1, float p2, float p3, float t)
		{
			return 0f;
		}

		// Token: 0x0600071D RID: 1821 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071D")]
		[Address(RVA = "0x243FFE0", Offset = "0x243E5E0", VA = "0x18243FFE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CatmullRom$BurstManaged(in float2 p0, in float2 p1, in float2 p2, in float2 p3, float t, out float2 ret)
		{
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071E")]
		[Address(RVA = "0x24401C0", Offset = "0x243E7C0", VA = "0x1824401C0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CatmullRom$BurstManaged(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 ret)
		{
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600071F")]
		[Address(RVA = "0x24404B0", Offset = "0x243EAB0", VA = "0x1824404B0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void CatmullRom$BurstManaged(in float4 p0, in float4 p1, in float4 p2, in float4 p3, float t, out float4 ret)
		{
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x00005880 File Offset: 0x00003A80
		[Token(Token = "0x6000720")]
		[Address(RVA = "0x2440890", Offset = "0x243EE90", VA = "0x182440890")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float Saturate$BurstManaged(float x)
		{
			return 0f;
		}

		// Token: 0x04000466 RID: 1126
		[Token(Token = "0x4000466")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float Pi;

		// Token: 0x04000467 RID: 1127
		[Token(Token = "0x4000467")]
		[FieldOffset(Offset = "0x4")]
		public static readonly float TwoPi;

		// Token: 0x04000468 RID: 1128
		[Token(Token = "0x4000468")]
		[FieldOffset(Offset = "0x8")]
		public static readonly float HalfPi;

		// Token: 0x04000469 RID: 1129
		[Token(Token = "0x4000469")]
		[FieldOffset(Offset = "0xC")]
		public static readonly float ThirdPi;

		// Token: 0x0400046A RID: 1130
		[Token(Token = "0x400046A")]
		[FieldOffset(Offset = "0x10")]
		public static readonly float QuarterPi;

		// Token: 0x0400046B RID: 1131
		[Token(Token = "0x400046B")]
		[FieldOffset(Offset = "0x14")]
		public static readonly float FifthPi;

		// Token: 0x0400046C RID: 1132
		[Token(Token = "0x400046C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly float SixthPi;

		// Token: 0x0400046D RID: 1133
		[Token(Token = "0x400046D")]
		[FieldOffset(Offset = "0x1C")]
		public static readonly float Sqrt2;

		// Token: 0x0400046E RID: 1134
		[Token(Token = "0x400046E")]
		[FieldOffset(Offset = "0x20")]
		public static readonly float Sqrt2Inv;

		// Token: 0x0400046F RID: 1135
		[Token(Token = "0x400046F")]
		[FieldOffset(Offset = "0x24")]
		public static readonly float Sqrt3;

		// Token: 0x04000470 RID: 1136
		[Token(Token = "0x4000470")]
		[FieldOffset(Offset = "0x28")]
		public static readonly float Sqrt3Inv;

		// Token: 0x04000471 RID: 1137
		[Token(Token = "0x4000471")]
		[FieldOffset(Offset = "0x2C")]
		public static readonly float Epsilon;

		// Token: 0x04000472 RID: 1138
		[Token(Token = "0x4000472")]
		[FieldOffset(Offset = "0x30")]
		public static readonly float EpsilonComp;

		// Token: 0x04000473 RID: 1139
		[Token(Token = "0x4000473")]
		[FieldOffset(Offset = "0x34")]
		public static readonly float Rad2Deg;

		// Token: 0x04000474 RID: 1140
		[Token(Token = "0x4000474")]
		[FieldOffset(Offset = "0x38")]
		public static readonly float Deg2Rad;

		// Token: 0x04000475 RID: 1141
		[Token(Token = "0x4000475")]
		[FieldOffset(Offset = "0x3C")]
		public static readonly int CartesianNoisePeriod;

		// Token: 0x04000476 RID: 1142
		[Token(Token = "0x4000476")]
		[FieldOffset(Offset = "0x40")]
		public static readonly int SphericalNoisePeriod;

		// Token: 0x04000477 RID: 1143
		[Token(Token = "0x4000477")]
		[FieldOffset(Offset = "0x44")]
		public static readonly int CachedNoiseDensity;

		// Token: 0x0200011B RID: 283
		// (Invoke) Token: 0x06000722 RID: 1826
		[Token(Token = "0x200011B")]
		public delegate float AsinSafe_00000355$PostfixBurstDelegate(float x);

		// Token: 0x0200011C RID: 284
		[Token(Token = "0x200011C")]
		internal static class AsinSafe_00000355$BurstDirectCall
		{
			// Token: 0x06000725 RID: 1829 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000725")]
			[Address(RVA = "0x2440930", Offset = "0x243EF30", VA = "0x182440930")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000726 RID: 1830 RVA: 0x00005898 File Offset: 0x00003A98
			[Token(Token = "0x6000726")]
			[Address(RVA = "0x2440A60", Offset = "0x243F060", VA = "0x182440A60")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000727")]
			[Address(RVA = "0x2440BC0", Offset = "0x243F1C0", VA = "0x182440BC0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000728")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600072A RID: 1834 RVA: 0x000058B0 File Offset: 0x00003AB0
			[Token(Token = "0x600072A")]
			[Address(RVA = "0x2440C70", Offset = "0x243F270", VA = "0x182440C70")]
			public static float Invoke(float x)
			{
				return 0f;
			}

			// Token: 0x04000478 RID: 1144
			[Token(Token = "0x4000478")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000479 RID: 1145
			[Token(Token = "0x4000479")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200011D RID: 285
		// (Invoke) Token: 0x0600072C RID: 1836
		[Token(Token = "0x200011D")]
		public delegate float AcosSafe_00000356$PostfixBurstDelegate(float x);

		// Token: 0x0200011E RID: 286
		[Token(Token = "0x200011E")]
		internal static class AcosSafe_00000356$BurstDirectCall
		{
			// Token: 0x0600072F RID: 1839 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600072F")]
			[Address(RVA = "0x2440F10", Offset = "0x243F510", VA = "0x182440F10")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000730 RID: 1840 RVA: 0x000058C8 File Offset: 0x00003AC8
			[Token(Token = "0x6000730")]
			[Address(RVA = "0x2441040", Offset = "0x243F640", VA = "0x182441040")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000731 RID: 1841 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000731")]
			[Address(RVA = "0x24411A0", Offset = "0x243F7A0", VA = "0x1824411A0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000732 RID: 1842 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000732")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000734 RID: 1844 RVA: 0x000058E0 File Offset: 0x00003AE0
			[Token(Token = "0x6000734")]
			[Address(RVA = "0x2441250", Offset = "0x243F850", VA = "0x182441250")]
			public static float Invoke(float x)
			{
				return 0f;
			}

			// Token: 0x0400047A RID: 1146
			[Token(Token = "0x400047A")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400047B RID: 1147
			[Token(Token = "0x400047B")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200011F RID: 287
		// (Invoke) Token: 0x06000736 RID: 1846
		[Token(Token = "0x200011F")]
		public delegate float InvSafe_00000357$PostfixBurstDelegate(float x);

		// Token: 0x02000120 RID: 288
		[Token(Token = "0x2000120")]
		internal static class InvSafe_00000357$BurstDirectCall
		{
			// Token: 0x06000739 RID: 1849 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000739")]
			[Address(RVA = "0x24414F0", Offset = "0x243FAF0", VA = "0x1824414F0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600073A RID: 1850 RVA: 0x000058F8 File Offset: 0x00003AF8
			[Token(Token = "0x600073A")]
			[Address(RVA = "0x2441620", Offset = "0x243FC20", VA = "0x182441620")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600073B RID: 1851 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600073B")]
			[Address(RVA = "0x2441780", Offset = "0x243FD80", VA = "0x182441780")]
			public static void Constructor()
			{
			}

			// Token: 0x0600073C RID: 1852 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600073C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600073E RID: 1854 RVA: 0x00005910 File Offset: 0x00003B10
			[Token(Token = "0x600073E")]
			[Address(RVA = "0x2441830", Offset = "0x243FE30", VA = "0x182441830")]
			public static float Invoke(float x)
			{
				return 0f;
			}

			// Token: 0x0400047C RID: 1148
			[Token(Token = "0x400047C")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400047D RID: 1149
			[Token(Token = "0x400047D")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000121 RID: 289
		// (Invoke) Token: 0x06000740 RID: 1856
		[Token(Token = "0x2000121")]
		public delegate float BezierQuad_00000358$PostfixBurstDelegate(float a, float b, float controlPoint, float t);

		// Token: 0x02000122 RID: 290
		[Token(Token = "0x2000122")]
		internal static class BezierQuad_00000358$BurstDirectCall
		{
			// Token: 0x06000743 RID: 1859 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000743")]
			[Address(RVA = "0x2441C30", Offset = "0x2440230", VA = "0x182441C30")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000744 RID: 1860 RVA: 0x00005928 File Offset: 0x00003B28
			[Token(Token = "0x6000744")]
			[Address(RVA = "0x2441D60", Offset = "0x2440360", VA = "0x182441D60")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000745 RID: 1861 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000745")]
			[Address(RVA = "0x2441EC0", Offset = "0x24404C0", VA = "0x182441EC0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000746 RID: 1862 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000746")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000748 RID: 1864 RVA: 0x00005940 File Offset: 0x00003B40
			[Token(Token = "0x6000748")]
			[Address(RVA = "0x2441F70", Offset = "0x2440570", VA = "0x182441F70")]
			public static float Invoke(float a, float b, float controlPoint, float t)
			{
				return 0f;
			}

			// Token: 0x0400047E RID: 1150
			[Token(Token = "0x400047E")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400047F RID: 1151
			[Token(Token = "0x400047F")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000123 RID: 291
		// (Invoke) Token: 0x0600074A RID: 1866
		[Token(Token = "0x2000123")]
		public delegate void BezierQuad_00000359$PostfixBurstDelegate(in float2 a, in float2 b, in float2 controlPoint, float t, out float2 ret);

		// Token: 0x02000124 RID: 292
		[Token(Token = "0x2000124")]
		internal static class BezierQuad_00000359$BurstDirectCall
		{
			// Token: 0x0600074D RID: 1869 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600074D")]
			[Address(RVA = "0x24423D0", Offset = "0x24409D0", VA = "0x1824423D0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600074E RID: 1870 RVA: 0x00005958 File Offset: 0x00003B58
			[Token(Token = "0x600074E")]
			[Address(RVA = "0x2442500", Offset = "0x2440B00", VA = "0x182442500")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600074F RID: 1871 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600074F")]
			[Address(RVA = "0x2442660", Offset = "0x2440C60", VA = "0x182442660")]
			public static void Constructor()
			{
			}

			// Token: 0x06000750 RID: 1872 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000750")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000752 RID: 1874 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000752")]
			[Address(RVA = "0x2442710", Offset = "0x2440D10", VA = "0x182442710")]
			public static void Invoke(in float2 a, in float2 b, in float2 controlPoint, float t, out float2 ret)
			{
			}

			// Token: 0x04000480 RID: 1152
			[Token(Token = "0x4000480")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000481 RID: 1153
			[Token(Token = "0x4000481")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000125 RID: 293
		// (Invoke) Token: 0x06000754 RID: 1876
		[Token(Token = "0x2000125")]
		public delegate void BezierQuad_0000035A$PostfixBurstDelegate(in float3 a, in float3 b, in float3 controlPoint, float t, out float3 ret);

		// Token: 0x02000126 RID: 294
		[Token(Token = "0x2000126")]
		internal static class BezierQuad_0000035A$BurstDirectCall
		{
			// Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x2442AB0", Offset = "0x24410B0", VA = "0x182442AB0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000758 RID: 1880 RVA: 0x00005970 File Offset: 0x00003B70
			[Token(Token = "0x6000758")]
			[Address(RVA = "0x2442BE0", Offset = "0x24411E0", VA = "0x182442BE0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000759")]
			[Address(RVA = "0x2442D40", Offset = "0x2441340", VA = "0x182442D40")]
			public static void Constructor()
			{
			}

			// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600075A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600075C RID: 1884 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600075C")]
			[Address(RVA = "0x2442DF0", Offset = "0x24413F0", VA = "0x182442DF0")]
			public static void Invoke(in float3 a, in float3 b, in float3 controlPoint, float t, out float3 ret)
			{
			}

			// Token: 0x04000482 RID: 1154
			[Token(Token = "0x4000482")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000483 RID: 1155
			[Token(Token = "0x4000483")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000127 RID: 295
		// (Invoke) Token: 0x0600075E RID: 1886
		[Token(Token = "0x2000127")]
		public delegate void BezierQuad_0000035B$PostfixBurstDelegate(in float4 a, in float4 b, in float4 controlPoint, float t, out float4 ret);

		// Token: 0x02000128 RID: 296
		[Token(Token = "0x2000128")]
		internal static class BezierQuad_0000035B$BurstDirectCall
		{
			// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000761")]
			[Address(RVA = "0x2443270", Offset = "0x2441870", VA = "0x182443270")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000762 RID: 1890 RVA: 0x00005988 File Offset: 0x00003B88
			[Token(Token = "0x6000762")]
			[Address(RVA = "0x24433A0", Offset = "0x24419A0", VA = "0x1824433A0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000763 RID: 1891 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000763")]
			[Address(RVA = "0x2443500", Offset = "0x2441B00", VA = "0x182443500")]
			public static void Constructor()
			{
			}

			// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000764")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000766 RID: 1894 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000766")]
			[Address(RVA = "0x24435B0", Offset = "0x2441BB0", VA = "0x1824435B0")]
			public static void Invoke(in float4 a, in float4 b, in float4 controlPoint, float t, out float4 ret)
			{
			}

			// Token: 0x04000484 RID: 1156
			[Token(Token = "0x4000484")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000485 RID: 1157
			[Token(Token = "0x4000485")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000129 RID: 297
		// (Invoke) Token: 0x06000768 RID: 1896
		[Token(Token = "0x2000129")]
		public delegate float CatmullRom_0000035C$PostfixBurstDelegate(float p0, float p1, float p2, float p3, float t);

		// Token: 0x0200012A RID: 298
		[Token(Token = "0x200012A")]
		internal static class CatmullRom_0000035C$BurstDirectCall
		{
			// Token: 0x0600076B RID: 1899 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x2443990", Offset = "0x2441F90", VA = "0x182443990")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600076C RID: 1900 RVA: 0x000059A0 File Offset: 0x00003BA0
			[Token(Token = "0x600076C")]
			[Address(RVA = "0x2443AC0", Offset = "0x24420C0", VA = "0x182443AC0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600076D RID: 1901 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600076D")]
			[Address(RVA = "0x2443C20", Offset = "0x2442220", VA = "0x182443C20")]
			public static void Constructor()
			{
			}

			// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600076E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000770 RID: 1904 RVA: 0x000059B8 File Offset: 0x00003BB8
			[Token(Token = "0x6000770")]
			[Address(RVA = "0x2443CD0", Offset = "0x24422D0", VA = "0x182443CD0")]
			public static float Invoke(float p0, float p1, float p2, float p3, float t)
			{
				return 0f;
			}

			// Token: 0x04000486 RID: 1158
			[Token(Token = "0x4000486")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000487 RID: 1159
			[Token(Token = "0x4000487")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200012B RID: 299
		// (Invoke) Token: 0x06000772 RID: 1906
		[Token(Token = "0x200012B")]
		public delegate void CatmullRom_0000035D$PostfixBurstDelegate(in float2 p0, in float2 p1, in float2 p2, in float2 p3, float t, out float2 ret);

		// Token: 0x0200012C RID: 300
		[Token(Token = "0x200012C")]
		internal static class CatmullRom_0000035D$BurstDirectCall
		{
			// Token: 0x06000775 RID: 1909 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000775")]
			[Address(RVA = "0x24441A0", Offset = "0x24427A0", VA = "0x1824441A0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000776 RID: 1910 RVA: 0x000059D0 File Offset: 0x00003BD0
			[Token(Token = "0x6000776")]
			[Address(RVA = "0x24442D0", Offset = "0x24428D0", VA = "0x1824442D0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000777 RID: 1911 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000777")]
			[Address(RVA = "0x2444430", Offset = "0x2442A30", VA = "0x182444430")]
			public static void Constructor()
			{
			}

			// Token: 0x06000778 RID: 1912 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000778")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600077A RID: 1914 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600077A")]
			[Address(RVA = "0x24444E0", Offset = "0x2442AE0", VA = "0x1824444E0")]
			public static void Invoke(in float2 p0, in float2 p1, in float2 p2, in float2 p3, float t, out float2 ret)
			{
			}

			// Token: 0x04000488 RID: 1160
			[Token(Token = "0x4000488")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000489 RID: 1161
			[Token(Token = "0x4000489")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200012D RID: 301
		// (Invoke) Token: 0x0600077C RID: 1916
		[Token(Token = "0x200012D")]
		public delegate void CatmullRom_0000035E$PostfixBurstDelegate(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 ret);

		// Token: 0x0200012E RID: 302
		[Token(Token = "0x200012E")]
		internal static class CatmullRom_0000035E$BurstDirectCall
		{
			// Token: 0x0600077F RID: 1919 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600077F")]
			[Address(RVA = "0x2444820", Offset = "0x2442E20", VA = "0x182444820")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000780 RID: 1920 RVA: 0x000059E8 File Offset: 0x00003BE8
			[Token(Token = "0x6000780")]
			[Address(RVA = "0x2444950", Offset = "0x2442F50", VA = "0x182444950")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000781 RID: 1921 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000781")]
			[Address(RVA = "0x2444AB0", Offset = "0x24430B0", VA = "0x182444AB0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000782 RID: 1922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000782")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000784 RID: 1924 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000784")]
			[Address(RVA = "0x2444B60", Offset = "0x2443160", VA = "0x182444B60")]
			public static void Invoke(in float3 p0, in float3 p1, in float3 p2, in float3 p3, float t, out float3 ret)
			{
			}

			// Token: 0x0400048A RID: 1162
			[Token(Token = "0x400048A")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400048B RID: 1163
			[Token(Token = "0x400048B")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200012F RID: 303
		// (Invoke) Token: 0x06000786 RID: 1926
		[Token(Token = "0x200012F")]
		public delegate void CatmullRom_0000035F$PostfixBurstDelegate(in float4 p0, in float4 p1, in float4 p2, in float4 p3, float t, out float4 ret);

		// Token: 0x02000130 RID: 304
		[Token(Token = "0x2000130")]
		internal static class CatmullRom_0000035F$BurstDirectCall
		{
			// Token: 0x06000789 RID: 1929 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000789")]
			[Address(RVA = "0x2444EA0", Offset = "0x24434A0", VA = "0x182444EA0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600078A RID: 1930 RVA: 0x00005A00 File Offset: 0x00003C00
			[Token(Token = "0x600078A")]
			[Address(RVA = "0x2444FD0", Offset = "0x24435D0", VA = "0x182444FD0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600078B RID: 1931 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600078B")]
			[Address(RVA = "0x2445130", Offset = "0x2443730", VA = "0x182445130")]
			public static void Constructor()
			{
			}

			// Token: 0x0600078C RID: 1932 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600078C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600078E RID: 1934 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x24451E0", Offset = "0x24437E0", VA = "0x1824451E0")]
			public static void Invoke(in float4 p0, in float4 p1, in float4 p2, in float4 p3, float t, out float4 ret)
			{
			}

			// Token: 0x0400048C RID: 1164
			[Token(Token = "0x400048C")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400048D RID: 1165
			[Token(Token = "0x400048D")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000131 RID: 305
		// (Invoke) Token: 0x06000790 RID: 1936
		[Token(Token = "0x2000131")]
		public delegate float Saturate_00000360$PostfixBurstDelegate(float x);

		// Token: 0x02000132 RID: 306
		[Token(Token = "0x2000132")]
		internal static class Saturate_00000360$BurstDirectCall
		{
			// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000793")]
			[Address(RVA = "0x2445490", Offset = "0x2443A90", VA = "0x182445490")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000794 RID: 1940 RVA: 0x00005A18 File Offset: 0x00003C18
			[Token(Token = "0x6000794")]
			[Address(RVA = "0x24455C0", Offset = "0x2443BC0", VA = "0x1824455C0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000795 RID: 1941 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000795")]
			[Address(RVA = "0x2445720", Offset = "0x2443D20", VA = "0x182445720")]
			public static void Constructor()
			{
			}

			// Token: 0x06000796 RID: 1942 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000796")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000798 RID: 1944 RVA: 0x00005A30 File Offset: 0x00003C30
			[Token(Token = "0x6000798")]
			[Address(RVA = "0x24457D0", Offset = "0x2443DD0", VA = "0x1824457D0")]
			public static float Invoke(float x)
			{
				return 0f;
			}

			// Token: 0x0400048E RID: 1166
			[Token(Token = "0x400048E")]
			[FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400048F RID: 1167
			[Token(Token = "0x400048F")]
			[FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
