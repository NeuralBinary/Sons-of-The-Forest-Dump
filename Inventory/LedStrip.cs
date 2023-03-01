using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Inventory
{
	// Token: 0x020005E2 RID: 1506
	[Token(Token = "0x20005E2")]
	public class LedStrip : MonoBehaviour
	{
		// Token: 0x0600269D RID: 9885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269D")]
		[Address(RVA = "0x2DA4E70", Offset = "0x2DA3E70", VA = "0x182DA4E70")]
		public void PowerOn(bool enable)
		{
		}

		// Token: 0x0600269E RID: 9886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269E")]
		[Address(RVA = "0x2DA5080", Offset = "0x2DA4080", VA = "0x182DA5080")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x0600269F RID: 9887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600269F")]
		[Address(RVA = "0x2DA5430", Offset = "0x2DA4430", VA = "0x182DA5430")]
		public void SetLightRange(float range)
		{
		}

		// Token: 0x060026A0 RID: 9888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A0")]
		[Address(RVA = "0x2DA5310", Offset = "0x2DA4310", VA = "0x182DA5310")]
		public void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x060026A1 RID: 9889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A1")]
		[Address(RVA = "0x2DA5260", Offset = "0x2DA4260", VA = "0x182DA5260")]
		public void SetEmissiveIntensity(float intensity)
		{
		}

		// Token: 0x060026A2 RID: 9890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60026A2")]
		[Address(RVA = "0x2DA5550", Offset = "0x2DA4550", VA = "0x182DA5550")]
		public LedStrip()
		{
		}

		// Token: 0x04002315 RID: 8981
		[Token(Token = "0x4002315")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Light> _lights;

		// Token: 0x04002316 RID: 8982
		[Token(Token = "0x4002316")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _stripRenderer;

		// Token: 0x04002317 RID: 8983
		[Token(Token = "0x4002317")]
		[FieldOffset(Offset = "0x30")]
		private List<HDAdditionalLightData> _lightsData;
	}
}
