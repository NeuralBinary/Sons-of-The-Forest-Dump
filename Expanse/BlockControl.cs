using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Expanse
{
	// Token: 0x02000027 RID: 39
	[Token(Token = "0x2000027")]
	[ExecuteInEditMode]
	public class BlockControl : MonoBehaviour
	{
		// Token: 0x06000261 RID: 609 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xAC2380", Offset = "0xAC0980", VA = "0x180AC2380")]
		public static int registerCloudLayer()
		{
			return 0;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00004E48 File Offset: 0x00003048
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xAC2440", Offset = "0xAC0A40", VA = "0x180AC2440")]
		public static int registerAtmosphereLayer()
		{
			return 0;
		}

		// Token: 0x06000263 RID: 611 RVA: 0x00004E60 File Offset: 0x00003060
		[Token(Token = "0x6000263")]
		[Address(RVA = "0xAC2500", Offset = "0xAC0B00", VA = "0x180AC2500")]
		public static int registerCelestialBody()
		{
			return 0;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000264")]
		[Address(RVA = "0xAC25C0", Offset = "0xAC0BC0", VA = "0x180AC25C0")]
		public static void deregisterCloudLayer(int index)
		{
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xAC2640", Offset = "0xAC0C40", VA = "0x180AC2640")]
		public static void deregisterAtmosphereLayer(int index)
		{
		}

		// Token: 0x06000266 RID: 614 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000266")]
		[Address(RVA = "0xAC26C0", Offset = "0xAC0CC0", VA = "0x180AC26C0")]
		public static void deregisterCelestialBody(int index)
		{
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00004E78 File Offset: 0x00003078
		[Token(Token = "0x6000267")]
		[Address(RVA = "0xAC2740", Offset = "0xAC0D40", VA = "0x180AC2740")]
		private static int registerIndex(bool[] layerIndices, [Optional] HashSet<int> reserved)
		{
			return 0;
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000268")]
		[Address(RVA = "0xAC2800", Offset = "0xAC0E00", VA = "0x180AC2800")]
		private static void deregisterIndex(int i, bool[] layerIndices)
		{
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000269")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BlockControl()
		{
		}

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static bool[] m_cloudIndices;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static bool[] m_atmosphereIndices;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static bool[] m_celestialBodyIndices;
	}
}
