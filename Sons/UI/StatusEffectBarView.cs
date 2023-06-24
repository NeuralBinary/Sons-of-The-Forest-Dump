using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace Sons.UI
{
	// Token: 0x020004FC RID: 1276
	[Token(Token = "0x20004FC")]
	[AddComponentMenu("Sons/UI/StatusEffectBarView")]
	public class StatusEffectBarView : MonoBehaviour
	{
		// Token: 0x06002152 RID: 8530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002152")]
		[Address(RVA = "0x33274A0", Offset = "0x3325AA0", VA = "0x1833274A0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002153")]
		[Address(RVA = "0x3327620", Offset = "0x3325C20", VA = "0x183327620")]
		public void Initialize(Texture icon, Color color, float value)
		{
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002154")]
		[Address(RVA = "0x33276C0", Offset = "0x3325CC0", VA = "0x1833276C0")]
		public void SetValue(float value)
		{
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002155")]
		[Address(RVA = "0x3327840", Offset = "0x3325E40", VA = "0x183327840")]
		public StatusEffectBarView()
		{
		}

		// Token: 0x04001EF3 RID: 7923
		[Token(Token = "0x4001EF3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RawImage _icon;

		// Token: 0x04001EF4 RID: 7924
		[Token(Token = "0x4001EF4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _fillBar;

		// Token: 0x04001EF5 RID: 7925
		[Token(Token = "0x4001EF5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Color _color;

		// Token: 0x04001EF6 RID: 7926
		[Token(Token = "0x4001EF6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _value;
	}
}
