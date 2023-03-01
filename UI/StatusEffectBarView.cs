using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	[AddComponentMenu("Sons/UI/StatusEffectBarView")]
	public class StatusEffectBarView : MonoBehaviour
	{
		// Token: 0x0600209F RID: 8351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209F")]
		[Address(RVA = "0x2D33020", Offset = "0x2D32020", VA = "0x182D33020")]
		private void OnValidate()
		{
		}

		// Token: 0x060020A0 RID: 8352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A0")]
		[Address(RVA = "0x2D32F80", Offset = "0x2D31F80", VA = "0x182D32F80")]
		public void Initialize(Texture icon, Color color, float value)
		{
		}

		// Token: 0x060020A1 RID: 8353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A1")]
		[Address(RVA = "0x2D33140", Offset = "0x2D32140", VA = "0x182D33140")]
		public void SetValue(float value)
		{
		}

		// Token: 0x060020A2 RID: 8354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60020A2")]
		[Address(RVA = "0x2D33220", Offset = "0x2D32220", VA = "0x182D33220")]
		public StatusEffectBarView()
		{
		}

		// Token: 0x04001E64 RID: 7780
		[Token(Token = "0x4001E64")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x04001E65 RID: 7781
		[Token(Token = "0x4001E65")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _fillBar;

		// Token: 0x04001E66 RID: 7782
		[Token(Token = "0x4001E66")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _color;

		// Token: 0x04001E67 RID: 7783
		[Token(Token = "0x4001E67")]
		[FieldOffset(Offset = "0x40")]
		[Range(0f, 1f)]
		[SerializeField]
		private float _value;
	}
}
