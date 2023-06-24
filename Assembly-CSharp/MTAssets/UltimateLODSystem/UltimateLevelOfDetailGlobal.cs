using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x0200005F RID: 95
	[Token(Token = "0x200005F")]
	[AddComponentMenu("")]
	public class UltimateLevelOfDetailGlobal : MonoBehaviour
	{
		// Token: 0x06000165 RID: 357 RVA: 0x00002550 File Offset: 0x00000750
		[Token(Token = "0x6000165")]
		[Address(RVA = "0x5F64D0", Offset = "0x5F4AD0", VA = "0x1805F64D0")]
		public static bool isGlobalULodSystemEnabled()
		{
			return default(bool);
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000166")]
		[Address(RVA = "0x5F6520", Offset = "0x5F4B20", VA = "0x1805F6520")]
		public static void EnableGlobalULodSystem(bool enable)
		{
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000167")]
		[Address(RVA = "0x5F6580", Offset = "0x5F4B80", VA = "0x1805F6580")]
		public static void SetGlobalLodDistanceMultiplier(float multiplier)
		{
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00002568 File Offset: 0x00000768
		[Token(Token = "0x6000168")]
		[Address(RVA = "0x5F65E0", Offset = "0x5F4BE0", VA = "0x1805F65E0")]
		public static float GetGlobalLodDistanceMultiplier()
		{
			return 0f;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x0000209A File Offset: 0x0000029A
		[Token(Token = "0x6000169")]
		[Address(RVA = "0x5F6630", Offset = "0x5F4C30", VA = "0x1805F6630")]
		public static Mesh GetSimplifiedVersionOfThisMesh(Mesh meshToSimplify, bool isSkinnedMesh, bool skinnedAnimsCompatibilityMode, bool simplificationDestroyerMode, bool preventArtifacts, float percentOfVerticesOfSimplifyiedVersion)
		{
			return null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600016A")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public UltimateLevelOfDetailGlobal()
		{
		}

		// Token: 0x040002B6 RID: 694
		[Token(Token = "0x40002B6")]
		[FieldOffset(Offset = "0x0")]
		private static bool enableGlobalUlodSystem;

		// Token: 0x040002B7 RID: 695
		[Token(Token = "0x40002B7")]
		[FieldOffset(Offset = "0x4")]
		private static float lodDistanceMultiplier;

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x8")]
		public static Camera currentCameraThatIsOnTopOfScreenInThisScene;
	}
}
