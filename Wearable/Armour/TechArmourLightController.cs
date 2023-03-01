using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Wearable.Armour
{
	// Token: 0x020005CD RID: 1485
	[Token(Token = "0x20005CD")]
	public class TechArmourLightController : MonoBehaviour
	{
		// Token: 0x06002602 RID: 9730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002602")]
		[Address(RVA = "0x2DAB4D0", Offset = "0x2DAA4D0", VA = "0x182DAB4D0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002603")]
		[Address(RVA = "0x2DAB480", Offset = "0x2DAA480", VA = "0x182DAB480")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002604")]
		[Address(RVA = "0x2DAB3F0", Offset = "0x2DAA3F0", VA = "0x182DAB3F0")]
		public void EnableLights(bool enable)
		{
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002605")]
		[Address(RVA = "0x2DAB670", Offset = "0x2DAA670", VA = "0x182DAB670")]
		public TechArmourLightController()
		{
		}

		// Token: 0x04002249 RID: 8777
		[Token(Token = "0x4002249")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Renderer _renderer;

		// Token: 0x0400224A RID: 8778
		[Token(Token = "0x400224A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private int _materialIndex;

		// Token: 0x0400224B RID: 8779
		[Token(Token = "0x400224B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _activeIntensity;

		// Token: 0x0400224C RID: 8780
		[Token(Token = "0x400224C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _inactiveIntensity;

		// Token: 0x0400224D RID: 8781
		[Token(Token = "0x400224D")]
		[FieldOffset(Offset = "0x38")]
		private Material _material;
	}
}
