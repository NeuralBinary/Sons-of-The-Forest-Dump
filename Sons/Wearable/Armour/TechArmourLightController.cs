using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005DE RID: 1502
	[Token(Token = "0x20005DE")]
	public class TechArmourLightController : MonoBehaviour
	{
		// Token: 0x0600270B RID: 9995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270B")]
		[Address(RVA = "0x33BB200", Offset = "0x33B9800", VA = "0x1833BB200")]
		private void OnEnable()
		{
		}

		// Token: 0x0600270C RID: 9996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270C")]
		[Address(RVA = "0x33BB440", Offset = "0x33B9A40", VA = "0x1833BB440")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600270D RID: 9997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x33BB490", Offset = "0x33B9A90", VA = "0x1833BB490")]
		public void EnableLights(bool enable)
		{
		}

		// Token: 0x0600270E RID: 9998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x33BB520", Offset = "0x33B9B20", VA = "0x1833BB520")]
		public TechArmourLightController()
		{
		}

		// Token: 0x04002327 RID: 8999
		[Token(Token = "0x4002327")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x04002328 RID: 9000
		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _materialIndex;

		// Token: 0x04002329 RID: 9001
		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _activeIntensity;

		// Token: 0x0400232A RID: 9002
		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _inactiveIntensity;

		// Token: 0x0400232B RID: 9003
		[Token(Token = "0x400232B")]
		[FieldOffset(Offset = "0x38")]
		private Material _material;
	}
}
