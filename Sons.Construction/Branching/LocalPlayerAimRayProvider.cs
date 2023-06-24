using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.Branching
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public class LocalPlayerAimRayProvider : MonoBehaviour, IAimRayProvider
	{
		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000024EC File Offset: 0x000006EC
		[Token(Token = "0x17000034")]
		public Ray AimRay
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x2D5EDC0", Offset = "0x2D5D3C0", VA = "0x182D5EDC0", Slot = "4")]
			get
			{
				return default(Ray);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LocalPlayerAimRayProvider()
		{
		}
	}
}
