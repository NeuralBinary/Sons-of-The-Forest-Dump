using System;
using Il2CppDummyDll;
using UnityEngine;

namespace MTAssets.UltimateLODSystem
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[AddComponentMenu("")]
	public class CurrentRenderPipeline : MonoBehaviour
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000119")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public CurrentRenderPipeline()
		{
		}

		// Token: 0x04000255 RID: 597
		[Token(Token = "0x4000255")]
		[FieldOffset(Offset = "0x0")]
		public static bool haveAnotherSrpPackages;

		// Token: 0x04000256 RID: 598
		[Token(Token = "0x4000256")]
		[FieldOffset(Offset = "0x8")]
		public static string packageDetected;
	}
}
