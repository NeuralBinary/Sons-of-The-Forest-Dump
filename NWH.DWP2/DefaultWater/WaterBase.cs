using System;
using Il2CppDummyDll;
using UnityEngine;

namespace NWH.DWP2.DefaultWater
{
	// Token: 0x0200005E RID: 94
	[Token(Token = "0x200005E")]
	[ExecuteInEditMode]
	public class WaterBase : MonoBehaviour
	{
		// Token: 0x06000284 RID: 644 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000284")]
		[Address(RVA = "0x2730E50", Offset = "0x272F450", VA = "0x182730E50")]
		public void Update()
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000285")]
		[Address(RVA = "0x2730F20", Offset = "0x272F520", VA = "0x182730F20")]
		public void UpdateShader()
		{
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000286")]
		[Address(RVA = "0x27313B0", Offset = "0x272F9B0", VA = "0x1827313B0")]
		public void WaterTileBeingRendered(Transform tr, Camera currentCam)
		{
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000287")]
		[Address(RVA = "0x27314C0", Offset = "0x272FAC0", VA = "0x1827314C0")]
		public WaterBase()
		{
		}

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x20")]
		public Material sharedMaterial;

		// Token: 0x04000251 RID: 593
		[Token(Token = "0x4000251")]
		[FieldOffset(Offset = "0x28")]
		public WaterQuality waterQuality;

		// Token: 0x04000252 RID: 594
		[Token(Token = "0x4000252")]
		[FieldOffset(Offset = "0x2C")]
		public bool edgeBlend;
	}
}
