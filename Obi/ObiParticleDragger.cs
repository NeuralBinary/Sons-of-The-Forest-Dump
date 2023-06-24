using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001C6 RID: 454
	[Token(Token = "0x20001C6")]
	[RequireComponent(typeof(ObiParticlePicker))]
	[RequireComponent(typeof(LineRenderer))]
	public class ObiParticleDragger : MonoBehaviour
	{
		// Token: 0x060008D4 RID: 2260 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x27FAEF0", Offset = "0x27F94F0", VA = "0x1827FAEF0")]
		private void OnEnable()
		{
		}

		// Token: 0x060008D5 RID: 2261 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x27FB120", Offset = "0x27F9720", VA = "0x1827FB120")]
		private void OnDisable()
		{
		}

		// Token: 0x060008D6 RID: 2262 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x27FB350", Offset = "0x27F9950", VA = "0x1827FB350")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060008D7 RID: 2263 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
		private void Picker_OnParticleDragged(ObiParticlePicker.ParticlePickEventArgs e)
		{
		}

		// Token: 0x060008D8 RID: 2264 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D8")]
		[Address(RVA = "0x27FB910", Offset = "0x27F9F10", VA = "0x1827FB910")]
		private void Picker_OnParticleReleased(ObiParticlePicker.ParticlePickEventArgs e)
		{
		}

		// Token: 0x060008D9 RID: 2265 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60008D9")]
		[Address(RVA = "0x27FB9C0", Offset = "0x27F9FC0", VA = "0x1827FB9C0")]
		public ObiParticleDragger()
		{
		}

		// Token: 0x04000763 RID: 1891
		[Token(Token = "0x4000763")]
		[FieldOffset(Offset = "0x20")]
		public float springStiffness;

		// Token: 0x04000764 RID: 1892
		[Token(Token = "0x4000764")]
		[FieldOffset(Offset = "0x24")]
		public float springDamping;

		// Token: 0x04000765 RID: 1893
		[Token(Token = "0x4000765")]
		[FieldOffset(Offset = "0x28")]
		public bool drawSpring;

		// Token: 0x04000766 RID: 1894
		[Token(Token = "0x4000766")]
		[FieldOffset(Offset = "0x30")]
		private LineRenderer lineRenderer;

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x38")]
		private ObiParticlePicker picker;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x40")]
		private ObiParticlePicker.ParticlePickEventArgs pickArgs;
	}
}
