using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Burst;
using Unity.Mathematics;
using UnityEngine;

namespace MudBun
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	[BurstCompile]
	public class Codec
	{
		// Token: 0x0600008C RID: 140 RVA: 0x00002538 File Offset: 0x00000738
		[Token(Token = "0x600008C")]
		[Address(RVA = "0x23AB700", Offset = "0x23A9D00", VA = "0x1823AB700")]
		[BurstCompile]
		public static float PackSaturated(float a, float b)
		{
			return 0f;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x600008D")]
		[Address(RVA = "0x23AB770", Offset = "0x23A9D70", VA = "0x1823AB770")]
		[BurstCompile]
		public static float PackSaturated(ref Vector2 v)
		{
			return 0f;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x600008E")]
		[Address(RVA = "0x23AB7C0", Offset = "0x23A9DC0", VA = "0x1823AB7C0")]
		public static float Repeat(float t, float length)
		{
			return 0f;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600008F")]
		[Address(RVA = "0x23AB840", Offset = "0x23A9E40", VA = "0x1823AB840")]
		[BurstCompile]
		public static void UnpackSaturated(float f, out float2 unpacked)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000090")]
		[Address(RVA = "0x23AB8A0", Offset = "0x23A9EA0", VA = "0x1823AB8A0")]
		[BurstCompile]
		public static void UnpackNormal(float f, out Vector3 unpacked)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000091")]
		[Address(RVA = "0x23AB900", Offset = "0x23A9F00", VA = "0x1823AB900")]
		[BurstCompile]
		public static void UnpackRgba(uint i, out float4 unpackedColor)
		{
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00002580 File Offset: 0x00000780
		[Token(Token = "0x6000092")]
		[Address(RVA = "0x23AB960", Offset = "0x23A9F60", VA = "0x1823AB960")]
		[BurstDiscard]
		public static uint Pack8888(uint x, uint y, uint z, uint w)
		{
			return 0U;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000093")]
		[Address(RVA = "0x23AB980", Offset = "0x23A9F80", VA = "0x1823AB980")]
		[BurstDiscard]
		public static void Unpack8888(uint i, out uint x, out uint y, out uint z, out uint w)
		{
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002598 File Offset: 0x00000798
		[Token(Token = "0x6000094")]
		[Address(RVA = "0x2254190", Offset = "0x2252790", VA = "0x182254190")]
		private static int IntReinterpret(float f)
		{
			return 0;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x000025B0 File Offset: 0x000007B0
		[Token(Token = "0x6000095")]
		[Address(RVA = "0x23AB9B0", Offset = "0x23A9FB0", VA = "0x1823AB9B0")]
		[BurstCompile]
		public static int HashConcat(int hash, int i)
		{
			return 0;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x000025C8 File Offset: 0x000007C8
		[Token(Token = "0x6000096")]
		[Address(RVA = "0x23ABA10", Offset = "0x23AA010", VA = "0x1823ABA10")]
		[BurstCompile]
		public static int HashConcat(int hash, long i)
		{
			return 0;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x000025E0 File Offset: 0x000007E0
		[Token(Token = "0x6000097")]
		[Address(RVA = "0x23ABA70", Offset = "0x23AA070", VA = "0x1823ABA70")]
		[BurstCompile]
		public static int HashConcat(int hash, float f)
		{
			return 0;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x000025F8 File Offset: 0x000007F8
		[Token(Token = "0x6000098")]
		[Address(RVA = "0x23ABAD0", Offset = "0x23AA0D0", VA = "0x1823ABAD0")]
		[BurstCompile]
		public static int HashConcat(int hash, ref Vector2 v)
		{
			return 0;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002610 File Offset: 0x00000810
		[Token(Token = "0x6000099")]
		[Address(RVA = "0x23ABB30", Offset = "0x23AA130", VA = "0x1823ABB30")]
		[BurstCompile]
		public static int HashConcat(int hash, ref Vector3 v)
		{
			return 0;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002628 File Offset: 0x00000828
		[Token(Token = "0x600009A")]
		[Address(RVA = "0x23ABB90", Offset = "0x23AA190", VA = "0x1823ABB90")]
		[BurstCompile]
		public static int HashConcat(int hash, ref Vector4 v)
		{
			return 0;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00002640 File Offset: 0x00000840
		[Token(Token = "0x600009B")]
		[Address(RVA = "0x23ABBF0", Offset = "0x23AA1F0", VA = "0x1823ABBF0")]
		[BurstCompile]
		public static int HashConcat(int hash, in Color c)
		{
			return 0;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00002658 File Offset: 0x00000858
		[Token(Token = "0x600009C")]
		[Address(RVA = "0x23ABC50", Offset = "0x23AA250", VA = "0x1823ABC50")]
		public static int HashConcat(int hash, in MudMaterialBase m)
		{
			return 0;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002670 File Offset: 0x00000870
		[Token(Token = "0x600009D")]
		[Address(RVA = "0x23ABF30", Offset = "0x23AA530", VA = "0x1823ABF30")]
		public static int HashConcat(int hash, in MudSharedMaterialBase m)
		{
			return 0;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002688 File Offset: 0x00000888
		[Token(Token = "0x600009E")]
		[Address(RVA = "0x23AC1C0", Offset = "0x23AA7C0", VA = "0x1823AC1C0")]
		[BurstCompile]
		public static int HashConcat(int hash, in SdfBrushMaterial m)
		{
			return 0;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x000026A0 File Offset: 0x000008A0
		[Token(Token = "0x600009F")]
		[Address(RVA = "0x23AC220", Offset = "0x23AA820", VA = "0x1823AC220")]
		[BurstCompile]
		public static int Hash(int i)
		{
			return 0;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x000026B8 File Offset: 0x000008B8
		[Token(Token = "0x60000A0")]
		[Address(RVA = "0x23AC270", Offset = "0x23AA870", VA = "0x1823AC270")]
		[BurstCompile]
		public static int Hash(ref Vector3 v)
		{
			return 0;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x000026D0 File Offset: 0x000008D0
		[Token(Token = "0x60000A1")]
		[Address(RVA = "0x23AC2C0", Offset = "0x23AA8C0", VA = "0x1823AC2C0")]
		public static int Hash(in MudMaterialBase m)
		{
			return 0;
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x000026E8 File Offset: 0x000008E8
		[Token(Token = "0x60000A2")]
		[Address(RVA = "0x23AC320", Offset = "0x23AA920", VA = "0x1823AC320")]
		public static int Hash(in MudSharedMaterialBase m)
		{
			return 0;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x00002700 File Offset: 0x00000900
		[Token(Token = "0x60000A3")]
		[Address(RVA = "0x23AC380", Offset = "0x23AA980", VA = "0x1823AC380")]
		public static int HashConcat(in SdfBrushMaterial m)
		{
			return 0;
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A4")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public Codec()
		{
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00002718 File Offset: 0x00000918
		[Token(Token = "0x60000A6")]
		[Address(RVA = "0x23AC490", Offset = "0x23AAA90", VA = "0x1823AC490")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PackSaturated$BurstManaged(float a, float b)
		{
			return 0f;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00002730 File Offset: 0x00000930
		[Token(Token = "0x60000A7")]
		[Address(RVA = "0x23AC4F0", Offset = "0x23AAAF0", VA = "0x1823AC4F0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float PackSaturated$BurstManaged(ref Vector2 v)
		{
			return 0f;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A8")]
		[Address(RVA = "0x23AC590", Offset = "0x23AAB90", VA = "0x1823AC590")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnpackSaturated$BurstManaged(float f, out float2 unpacked)
		{
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000A9")]
		[Address(RVA = "0x23AC630", Offset = "0x23AAC30", VA = "0x1823AC630")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnpackNormal$BurstManaged(float f, out Vector3 unpacked)
		{
		}

		// Token: 0x060000AA RID: 170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000AA")]
		[Address(RVA = "0x23AC880", Offset = "0x23AAE80", VA = "0x1823AC880")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void UnpackRgba$BurstManaged(uint i, out float4 unpackedColor)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x00002748 File Offset: 0x00000948
		[Token(Token = "0x60000AB")]
		[Address(RVA = "0x23AC910", Offset = "0x23AAF10", VA = "0x1823AC910")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, int i)
		{
			return 0;
		}

		// Token: 0x060000AC RID: 172 RVA: 0x00002760 File Offset: 0x00000960
		[Token(Token = "0x60000AC")]
		[Address(RVA = "0x23AC980", Offset = "0x23AAF80", VA = "0x1823AC980")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, long i)
		{
			return 0;
		}

		// Token: 0x060000AD RID: 173 RVA: 0x00002778 File Offset: 0x00000978
		[Token(Token = "0x60000AD")]
		[Address(RVA = "0x23ACA50", Offset = "0x23AB050", VA = "0x1823ACA50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, float f)
		{
			return 0;
		}

		// Token: 0x060000AE RID: 174 RVA: 0x00002790 File Offset: 0x00000990
		[Token(Token = "0x60000AE")]
		[Address(RVA = "0x23ACAE0", Offset = "0x23AB0E0", VA = "0x1823ACAE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, ref Vector2 v)
		{
			return 0;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60000AF")]
		[Address(RVA = "0x23ACBC0", Offset = "0x23AB1C0", VA = "0x1823ACBC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, ref Vector3 v)
		{
			return 0;
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x000027C0 File Offset: 0x000009C0
		[Token(Token = "0x60000B0")]
		[Address(RVA = "0x23ACCE0", Offset = "0x23AB2E0", VA = "0x1823ACCE0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, ref Vector4 v)
		{
			return 0;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x000027D8 File Offset: 0x000009D8
		[Token(Token = "0x60000B1")]
		[Address(RVA = "0x23ACE50", Offset = "0x23AB450", VA = "0x1823ACE50")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, in Color c)
		{
			return 0;
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x000027F0 File Offset: 0x000009F0
		[Token(Token = "0x60000B2")]
		[Address(RVA = "0x23ACFC0", Offset = "0x23AB5C0", VA = "0x1823ACFC0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int HashConcat$BurstManaged(int hash, in SdfBrushMaterial m)
		{
			return 0;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002808 File Offset: 0x00000A08
		[Token(Token = "0x60000B3")]
		[Address(RVA = "0x23AD130", Offset = "0x23AB730", VA = "0x1823AD130")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Hash$BurstManaged(int i)
		{
			return 0;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00002820 File Offset: 0x00000A20
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x23AD1D0", Offset = "0x23AB7D0", VA = "0x1823AD1D0")]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int Hash$BurstManaged(ref Vector3 v)
		{
			return 0;
		}

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static readonly float2 float2One;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public static readonly int FnvDefaultBasis;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
		public static readonly int FnvPrime;

		// Token: 0x02000018 RID: 24
		[Token(Token = "0x2000018")]
		[StructLayout(2)]
		private struct IntFloat
		{
			// Token: 0x04000038 RID: 56
			[Token(Token = "0x4000038")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public int IntValue;

			// Token: 0x04000039 RID: 57
			[Token(Token = "0x4000039")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public float FloatValue;
		}

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x060000B6 RID: 182
		[Token(Token = "0x2000019")]
		public delegate float PackSaturated_0000006B$PostfixBurstDelegate(float a, float b);

		// Token: 0x0200001A RID: 26
		[Token(Token = "0x200001A")]
		internal static class PackSaturated_0000006B$BurstDirectCall
		{
			// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x23AD300", Offset = "0x23AB900", VA = "0x1823AD300")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000BA RID: 186 RVA: 0x00002838 File Offset: 0x00000A38
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x23AD430", Offset = "0x23ABA30", VA = "0x1823AD430")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x23AD590", Offset = "0x23ABB90", VA = "0x1823AD590")]
			public static void Constructor()
			{
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000BE RID: 190 RVA: 0x00002850 File Offset: 0x00000A50
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x23AD640", Offset = "0x23ABC40", VA = "0x1823AD640")]
			public static float Invoke(float a, float b)
			{
				return 0f;
			}

			// Token: 0x0400003A RID: 58
			[Token(Token = "0x400003A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400003B RID: 59
			[Token(Token = "0x400003B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000C0 RID: 192
		[Token(Token = "0x200001B")]
		public delegate float PackSaturated_0000006C$PostfixBurstDelegate(ref Vector2 v);

		// Token: 0x0200001C RID: 28
		[Token(Token = "0x200001C")]
		internal static class PackSaturated_0000006C$BurstDirectCall
		{
			// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000C3")]
			[Address(RVA = "0x23AD9E0", Offset = "0x23ABFE0", VA = "0x1823AD9E0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00002868 File Offset: 0x00000A68
			[Token(Token = "0x60000C4")]
			[Address(RVA = "0x23ADB10", Offset = "0x23AC110", VA = "0x1823ADB10")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000C5")]
			[Address(RVA = "0x23ADC70", Offset = "0x23AC270", VA = "0x1823ADC70")]
			public static void Constructor()
			{
			}

			// Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000C6")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000C8 RID: 200 RVA: 0x00002880 File Offset: 0x00000A80
			[Token(Token = "0x60000C8")]
			[Address(RVA = "0x23ADD20", Offset = "0x23AC320", VA = "0x1823ADD20")]
			public static float Invoke(ref Vector2 v)
			{
				return 0f;
			}

			// Token: 0x0400003C RID: 60
			[Token(Token = "0x400003C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400003D RID: 61
			[Token(Token = "0x400003D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x060000CA RID: 202
		[Token(Token = "0x200001D")]
		public delegate void UnpackSaturated_0000006E$PostfixBurstDelegate(float f, out float2 unpacked);

		// Token: 0x0200001E RID: 30
		[Token(Token = "0x200001E")]
		internal static class UnpackSaturated_0000006E$BurstDirectCall
		{
			// Token: 0x060000CD RID: 205 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000CD")]
			[Address(RVA = "0x23AE110", Offset = "0x23AC710", VA = "0x1823AE110")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000CE RID: 206 RVA: 0x00002898 File Offset: 0x00000A98
			[Token(Token = "0x60000CE")]
			[Address(RVA = "0x23AE240", Offset = "0x23AC840", VA = "0x1823AE240")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000CF")]
			[Address(RVA = "0x23AE3A0", Offset = "0x23AC9A0", VA = "0x1823AE3A0")]
			public static void Constructor()
			{
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D0")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D2")]
			[Address(RVA = "0x23AE450", Offset = "0x23ACA50", VA = "0x1823AE450")]
			public static void Invoke(float f, out float2 unpacked)
			{
			}

			// Token: 0x0400003E RID: 62
			[Token(Token = "0x400003E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400003F RID: 63
			[Token(Token = "0x400003F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x060000D4 RID: 212
		[Token(Token = "0x200001F")]
		public delegate void UnpackNormal_0000006F$PostfixBurstDelegate(float f, out Vector3 unpacked);

		// Token: 0x02000020 RID: 32
		[Token(Token = "0x2000020")]
		internal static class UnpackNormal_0000006F$BurstDirectCall
		{
			// Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x23AE770", Offset = "0x23ACD70", VA = "0x1823AE770")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x000028B0 File Offset: 0x00000AB0
			[Token(Token = "0x60000D8")]
			[Address(RVA = "0x23AE8A0", Offset = "0x23ACEA0", VA = "0x1823AE8A0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000D9")]
			[Address(RVA = "0x23AEA00", Offset = "0x23AD000", VA = "0x1823AEA00")]
			public static void Constructor()
			{
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000DA")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000DC")]
			[Address(RVA = "0x23AEAB0", Offset = "0x23AD0B0", VA = "0x1823AEAB0")]
			public static void Invoke(float f, out Vector3 unpacked)
			{
			}

			// Token: 0x04000040 RID: 64
			[Token(Token = "0x4000040")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000041 RID: 65
			[Token(Token = "0x4000041")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x060000DE RID: 222
		[Token(Token = "0x2000021")]
		public delegate void UnpackRgba_00000070$PostfixBurstDelegate(uint i, out float4 unpackedColor);

		// Token: 0x02000022 RID: 34
		[Token(Token = "0x2000022")]
		internal static class UnpackRgba_00000070$BurstDirectCall
		{
			// Token: 0x060000E1 RID: 225 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E1")]
			[Address(RVA = "0x23AED60", Offset = "0x23AD360", VA = "0x1823AED60")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x000028C8 File Offset: 0x00000AC8
			[Token(Token = "0x60000E2")]
			[Address(RVA = "0x23AEE90", Offset = "0x23AD490", VA = "0x1823AEE90")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E3")]
			[Address(RVA = "0x23AEFF0", Offset = "0x23AD5F0", VA = "0x1823AEFF0")]
			public static void Constructor()
			{
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E4")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000E6 RID: 230 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000E6")]
			[Address(RVA = "0x23AF0A0", Offset = "0x23AD6A0", VA = "0x1823AF0A0")]
			public static void Invoke(uint i, out float4 unpackedColor)
			{
			}

			// Token: 0x04000042 RID: 66
			[Token(Token = "0x4000042")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000043 RID: 67
			[Token(Token = "0x4000043")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x060000E8 RID: 232
		[Token(Token = "0x2000023")]
		public delegate int HashConcat_00000074$PostfixBurstDelegate(int hash, int i);

		// Token: 0x02000024 RID: 36
		[Token(Token = "0x2000024")]
		internal static class HashConcat_00000074$BurstDirectCall
		{
			// Token: 0x060000EB RID: 235 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EB")]
			[Address(RVA = "0x23AF3B0", Offset = "0x23AD9B0", VA = "0x1823AF3B0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000EC RID: 236 RVA: 0x000028E0 File Offset: 0x00000AE0
			[Token(Token = "0x60000EC")]
			[Address(RVA = "0x23AF4E0", Offset = "0x23ADAE0", VA = "0x1823AF4E0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000ED RID: 237 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000ED")]
			[Address(RVA = "0x23AF640", Offset = "0x23ADC40", VA = "0x1823AF640")]
			public static void Constructor()
			{
			}

			// Token: 0x060000EE RID: 238 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000EE")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000F0 RID: 240 RVA: 0x000028F8 File Offset: 0x00000AF8
			[Token(Token = "0x60000F0")]
			[Address(RVA = "0x23AF6F0", Offset = "0x23ADCF0", VA = "0x1823AF6F0")]
			public static int Invoke(int hash, int i)
			{
				return 0;
			}

			// Token: 0x04000044 RID: 68
			[Token(Token = "0x4000044")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000045 RID: 69
			[Token(Token = "0x4000045")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x060000F2 RID: 242
		[Token(Token = "0x2000025")]
		public delegate int HashConcat_00000075$PostfixBurstDelegate(int hash, long i);

		// Token: 0x02000026 RID: 38
		[Token(Token = "0x2000026")]
		internal static class HashConcat_00000075$BurstDirectCall
		{
			// Token: 0x060000F5 RID: 245 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F5")]
			[Address(RVA = "0x23AF9E0", Offset = "0x23ADFE0", VA = "0x1823AF9E0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00002910 File Offset: 0x00000B10
			[Token(Token = "0x60000F6")]
			[Address(RVA = "0x23AFB10", Offset = "0x23AE110", VA = "0x1823AFB10")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F7")]
			[Address(RVA = "0x23AFC70", Offset = "0x23AE270", VA = "0x1823AFC70")]
			public static void Constructor()
			{
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000F8")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00002928 File Offset: 0x00000B28
			[Token(Token = "0x60000FA")]
			[Address(RVA = "0x23AFD20", Offset = "0x23AE320", VA = "0x1823AFD20")]
			public static int Invoke(int hash, long i)
			{
				return 0;
			}

			// Token: 0x04000046 RID: 70
			[Token(Token = "0x4000046")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x060000FC RID: 252
		[Token(Token = "0x2000027")]
		public delegate int HashConcat_00000076$PostfixBurstDelegate(int hash, float f);

		// Token: 0x02000028 RID: 40
		[Token(Token = "0x2000028")]
		internal static class HashConcat_00000076$BurstDirectCall
		{
			// Token: 0x060000FF RID: 255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60000FF")]
			[Address(RVA = "0x23B0150", Offset = "0x23AE750", VA = "0x1823B0150")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00002940 File Offset: 0x00000B40
			[Token(Token = "0x6000100")]
			[Address(RVA = "0x23B0280", Offset = "0x23AE880", VA = "0x1823B0280")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000101 RID: 257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000101")]
			[Address(RVA = "0x23B03E0", Offset = "0x23AE9E0", VA = "0x1823B03E0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000102 RID: 258 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000102")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000104 RID: 260 RVA: 0x00002958 File Offset: 0x00000B58
			[Token(Token = "0x6000104")]
			[Address(RVA = "0x23B0490", Offset = "0x23AEA90", VA = "0x1823B0490")]
			public static int Invoke(int hash, float f)
			{
				return 0;
			}

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x06000106 RID: 262
		[Token(Token = "0x2000029")]
		public delegate int HashConcat_00000077$PostfixBurstDelegate(int hash, ref Vector2 v);

		// Token: 0x0200002A RID: 42
		[Token(Token = "0x200002A")]
		internal static class HashConcat_00000077$BurstDirectCall
		{
			// Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000109")]
			[Address(RVA = "0x23B07A0", Offset = "0x23AEDA0", VA = "0x1823B07A0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600010A RID: 266 RVA: 0x00002970 File Offset: 0x00000B70
			[Token(Token = "0x600010A")]
			[Address(RVA = "0x23B08D0", Offset = "0x23AEED0", VA = "0x1823B08D0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600010B RID: 267 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010B")]
			[Address(RVA = "0x23B0A30", Offset = "0x23AF030", VA = "0x1823B0A30")]
			public static void Constructor()
			{
			}

			// Token: 0x0600010C RID: 268 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600010C")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00002988 File Offset: 0x00000B88
			[Token(Token = "0x600010E")]
			[Address(RVA = "0x23B0AE0", Offset = "0x23AF0E0", VA = "0x1823B0AE0")]
			public static int Invoke(int hash, ref Vector2 v)
			{
				return 0;
			}

			// Token: 0x0400004A RID: 74
			[Token(Token = "0x400004A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400004B RID: 75
			[Token(Token = "0x400004B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000110 RID: 272
		[Token(Token = "0x200002B")]
		public delegate int HashConcat_00000078$PostfixBurstDelegate(int hash, ref Vector3 v);

		// Token: 0x0200002C RID: 44
		[Token(Token = "0x200002C")]
		internal static class HashConcat_00000078$BurstDirectCall
		{
			// Token: 0x06000113 RID: 275 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000113")]
			[Address(RVA = "0x23B0E50", Offset = "0x23AF450", VA = "0x1823B0E50")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000114 RID: 276 RVA: 0x000029A0 File Offset: 0x00000BA0
			[Token(Token = "0x6000114")]
			[Address(RVA = "0x23B0F80", Offset = "0x23AF580", VA = "0x1823B0F80")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000115 RID: 277 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000115")]
			[Address(RVA = "0x23B10E0", Offset = "0x23AF6E0", VA = "0x1823B10E0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000116 RID: 278 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000116")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000118 RID: 280 RVA: 0x000029B8 File Offset: 0x00000BB8
			[Token(Token = "0x6000118")]
			[Address(RVA = "0x23B1190", Offset = "0x23AF790", VA = "0x1823B1190")]
			public static int Invoke(int hash, ref Vector3 v)
			{
				return 0;
			}

			// Token: 0x0400004C RID: 76
			[Token(Token = "0x400004C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400004D RID: 77
			[Token(Token = "0x400004D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x0600011A RID: 282
		[Token(Token = "0x200002D")]
		public delegate int HashConcat_00000079$PostfixBurstDelegate(int hash, ref Vector4 v);

		// Token: 0x0200002E RID: 46
		[Token(Token = "0x200002E")]
		internal static class HashConcat_00000079$BurstDirectCall
		{
			// Token: 0x0600011D RID: 285 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011D")]
			[Address(RVA = "0x23B1540", Offset = "0x23AFB40", VA = "0x1823B1540")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600011E RID: 286 RVA: 0x000029D0 File Offset: 0x00000BD0
			[Token(Token = "0x600011E")]
			[Address(RVA = "0x23B1670", Offset = "0x23AFC70", VA = "0x1823B1670")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600011F RID: 287 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600011F")]
			[Address(RVA = "0x23B17D0", Offset = "0x23AFDD0", VA = "0x1823B17D0")]
			public static void Constructor()
			{
			}

			// Token: 0x06000120 RID: 288 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000120")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000122 RID: 290 RVA: 0x000029E8 File Offset: 0x00000BE8
			[Token(Token = "0x6000122")]
			[Address(RVA = "0x23B1880", Offset = "0x23AFE80", VA = "0x1823B1880")]
			public static int Invoke(int hash, ref Vector4 v)
			{
				return 0;
			}

			// Token: 0x0400004E RID: 78
			[Token(Token = "0x400004E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x0400004F RID: 79
			[Token(Token = "0x400004F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x0200002F RID: 47
		// (Invoke) Token: 0x06000124 RID: 292
		[Token(Token = "0x200002F")]
		public delegate int HashConcat_0000007A$PostfixBurstDelegate(int hash, in Color c);

		// Token: 0x02000030 RID: 48
		[Token(Token = "0x2000030")]
		internal static class HashConcat_0000007A$BurstDirectCall
		{
			// Token: 0x06000127 RID: 295 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000127")]
			[Address(RVA = "0x23B1C70", Offset = "0x23B0270", VA = "0x1823B1C70")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000128 RID: 296 RVA: 0x00002A00 File Offset: 0x00000C00
			[Token(Token = "0x6000128")]
			[Address(RVA = "0x23B1DA0", Offset = "0x23B03A0", VA = "0x1823B1DA0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000129 RID: 297 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000129")]
			[Address(RVA = "0x23B1F00", Offset = "0x23B0500", VA = "0x1823B1F00")]
			public static void Constructor()
			{
			}

			// Token: 0x0600012A RID: 298 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600012A")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600012C RID: 300 RVA: 0x00002A18 File Offset: 0x00000C18
			[Token(Token = "0x600012C")]
			[Address(RVA = "0x23B1FB0", Offset = "0x23B05B0", VA = "0x1823B1FB0")]
			public static int Invoke(int hash, in Color c)
			{
				return 0;
			}

			// Token: 0x04000050 RID: 80
			[Token(Token = "0x4000050")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000051 RID: 81
			[Token(Token = "0x4000051")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000031 RID: 49
		// (Invoke) Token: 0x0600012E RID: 302
		[Token(Token = "0x2000031")]
		public delegate int HashConcat_0000007D$PostfixBurstDelegate(int hash, in SdfBrushMaterial m);

		// Token: 0x02000032 RID: 50
		[Token(Token = "0x2000032")]
		internal static class HashConcat_0000007D$BurstDirectCall
		{
			// Token: 0x06000131 RID: 305 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000131")]
			[Address(RVA = "0x23B23A0", Offset = "0x23B09A0", VA = "0x1823B23A0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000132 RID: 306 RVA: 0x00002A30 File Offset: 0x00000C30
			[Token(Token = "0x6000132")]
			[Address(RVA = "0x23B24D0", Offset = "0x23B0AD0", VA = "0x1823B24D0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000133 RID: 307 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000133")]
			[Address(RVA = "0x23B2630", Offset = "0x23B0C30", VA = "0x1823B2630")]
			public static void Constructor()
			{
			}

			// Token: 0x06000134 RID: 308 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000134")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000136 RID: 310 RVA: 0x00002A48 File Offset: 0x00000C48
			[Token(Token = "0x6000136")]
			[Address(RVA = "0x23B26E0", Offset = "0x23B0CE0", VA = "0x1823B26E0")]
			public static int Invoke(int hash, in SdfBrushMaterial m)
			{
				return 0;
			}

			// Token: 0x04000052 RID: 82
			[Token(Token = "0x4000052")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000053 RID: 83
			[Token(Token = "0x4000053")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000033 RID: 51
		// (Invoke) Token: 0x06000138 RID: 312
		[Token(Token = "0x2000033")]
		public delegate int Hash_0000007E$PostfixBurstDelegate(int i);

		// Token: 0x02000034 RID: 52
		[Token(Token = "0x2000034")]
		internal static class Hash_0000007E$BurstDirectCall
		{
			// Token: 0x0600013B RID: 315 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013B")]
			[Address(RVA = "0x23B2AA0", Offset = "0x23B10A0", VA = "0x1823B2AA0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x0600013C RID: 316 RVA: 0x00002A60 File Offset: 0x00000C60
			[Token(Token = "0x600013C")]
			[Address(RVA = "0x23B2BD0", Offset = "0x23B11D0", VA = "0x1823B2BD0")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x0600013D RID: 317 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013D")]
			[Address(RVA = "0x23B2D30", Offset = "0x23B1330", VA = "0x1823B2D30")]
			public static void Constructor()
			{
			}

			// Token: 0x0600013E RID: 318 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600013E")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x06000140 RID: 320 RVA: 0x00002A78 File Offset: 0x00000C78
			[Token(Token = "0x6000140")]
			[Address(RVA = "0x23B2DE0", Offset = "0x23B13E0", VA = "0x1823B2DE0")]
			public static int Invoke(int i)
			{
				return 0;
			}

			// Token: 0x04000054 RID: 84
			[Token(Token = "0x4000054")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000055 RID: 85
			[Token(Token = "0x4000055")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x06000142 RID: 322
		[Token(Token = "0x2000035")]
		public delegate int Hash_0000007F$PostfixBurstDelegate(ref Vector3 v);

		// Token: 0x02000036 RID: 54
		[Token(Token = "0x2000036")]
		internal static class Hash_0000007F$BurstDirectCall
		{
			// Token: 0x06000145 RID: 325 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000145")]
			[Address(RVA = "0x23B30E0", Offset = "0x23B16E0", VA = "0x1823B30E0")]
			[BurstDiscard]
			private static void GetFunctionPointerDiscard(ref IntPtr A_0)
			{
			}

			// Token: 0x06000146 RID: 326 RVA: 0x00002A90 File Offset: 0x00000C90
			[Token(Token = "0x6000146")]
			[Address(RVA = "0x23B3210", Offset = "0x23B1810", VA = "0x1823B3210")]
			private static IntPtr GetFunctionPointer()
			{
				return 0;
			}

			// Token: 0x06000147 RID: 327 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000147")]
			[Address(RVA = "0x23B3370", Offset = "0x23B1970", VA = "0x1823B3370")]
			public static void Constructor()
			{
			}

			// Token: 0x06000148 RID: 328 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000148")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public static void Initialize()
			{
			}

			// Token: 0x0600014A RID: 330 RVA: 0x00002AA8 File Offset: 0x00000CA8
			[Token(Token = "0x600014A")]
			[Address(RVA = "0x23B3420", Offset = "0x23B1A20", VA = "0x1823B3420")]
			public static int Invoke(ref Vector3 v)
			{
				return 0;
			}

			// Token: 0x04000056 RID: 86
			[Token(Token = "0x4000056")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static IntPtr Pointer;

			// Token: 0x04000057 RID: 87
			[Token(Token = "0x4000057")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static IntPtr DeferredCompilation;
		}
	}
}
