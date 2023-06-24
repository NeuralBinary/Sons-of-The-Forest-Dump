using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Sons.Inventory
{
	// Token: 0x020005F3 RID: 1523
	[Token(Token = "0x20005F3")]
	public class LedStrip : MonoBehaviour
	{
		// Token: 0x060027A6 RID: 10150 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A6")]
		[Address(RVA = "0x33CBD90", Offset = "0x33CA390", VA = "0x1833CBD90")]
		public void PowerOn(bool enable)
		{
		}

		// Token: 0x060027A7 RID: 10151 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A7")]
		[Address(RVA = "0x33CC000", Offset = "0x33CA600", VA = "0x1833CC000")]
		public void SetColor(Color color)
		{
		}

		// Token: 0x060027A8 RID: 10152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A8")]
		[Address(RVA = "0x33CC3E0", Offset = "0x33CA9E0", VA = "0x1833CC3E0")]
		public void SetLightRange(float range)
		{
		}

		// Token: 0x060027A9 RID: 10153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027A9")]
		[Address(RVA = "0x33CC560", Offset = "0x33CAB60", VA = "0x1833CC560")]
		public void SetLightIntensity(float intensity)
		{
		}

		// Token: 0x060027AA RID: 10154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AA")]
		[Address(RVA = "0x33CC710", Offset = "0x33CAD10", VA = "0x1833CC710")]
		public void SetEmissiveIntensity(float intensity)
		{
		}

		// Token: 0x060027AB RID: 10155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60027AB")]
		[Address(RVA = "0x33CC870", Offset = "0x33CAE70", VA = "0x1833CC870")]
		public LedStrip()
		{
		}

		// Token: 0x040023F3 RID: 9203
		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Light> _lights;

		// Token: 0x040023F4 RID: 9204
		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Renderer _stripRenderer;

		// Token: 0x040023F5 RID: 9205
		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x30")]
		private List<HDAdditionalLightData> _lightsData;
	}
}
