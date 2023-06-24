using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering;

namespace Obi
{
	// Token: 0x020001A3 RID: 419
	[Token(Token = "0x20001A3")]
	public class ShadowmapExposer : MonoBehaviour
	{
		// Token: 0x060007DE RID: 2014 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007DE")]
		[Address(RVA = "0x27E6120", Offset = "0x27E4720", VA = "0x1827E6120")]
		public void Awake()
		{
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007DF")]
		[Address(RVA = "0x27E61B0", Offset = "0x27E47B0", VA = "0x1827E61B0")]
		public void OnEnable()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007E0")]
		[Address(RVA = "0x27E6370", Offset = "0x27E4970", VA = "0x1827E6370")]
		public void OnDisable()
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007E1")]
		[Address(RVA = "0x27E6380", Offset = "0x27E4980", VA = "0x1827E6380")]
		private void Cleanup()
		{
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007E2")]
		[Address(RVA = "0x27E6450", Offset = "0x27E4A50", VA = "0x1827E6450")]
		public void SetupFluidShadowsCommandBuffer()
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007E3")]
		[Address(RVA = "0x27E6850", Offset = "0x27E4E50", VA = "0x1827E6850")]
		private void Update()
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60007E4")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ShadowmapExposer()
		{
		}

		// Token: 0x040006AB RID: 1707
		[Token(Token = "0x40006AB")]
		[FieldOffset(Offset = "0x20")]
		private Light unityLight;

		// Token: 0x040006AC RID: 1708
		[Token(Token = "0x40006AC")]
		[FieldOffset(Offset = "0x28")]
		private CommandBuffer afterShadow;

		// Token: 0x040006AD RID: 1709
		[Token(Token = "0x40006AD")]
		[FieldOffset(Offset = "0x30")]
		public ObiParticleRenderer[] particleRenderers;
	}
}
