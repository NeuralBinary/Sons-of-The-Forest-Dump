using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005ED RID: 1517
	[Token(Token = "0x20005ED")]
	[AddComponentMenu("Sons/Inventory/InventoryLedStripMusicVisualizer")]
	public class InventoryLedStripMusicVisualizer : MonoBehaviour
	{
		// Token: 0x06002782 RID: 10114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002782")]
		[Address(RVA = "0x33C83B0", Offset = "0x33C69B0", VA = "0x1833C83B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06002783 RID: 10115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002783")]
		[Address(RVA = "0x33C88D0", Offset = "0x33C6ED0", VA = "0x1833C88D0")]
		public InventoryLedStripMusicVisualizer()
		{
		}

		// Token: 0x040023CA RID: 9162
		[Token(Token = "0x40023CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<LedStrip> _bars;

		// Token: 0x040023CB RID: 9163
		[Token(Token = "0x40023CB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _heightMultiplier;

		// Token: 0x040023CC RID: 9164
		[Token(Token = "0x40023CC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FMODSpectrumData _spectrumData;

		// Token: 0x040023CD RID: 9165
		[Token(Token = "0x40023CD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _gainSmoothing;

		// Token: 0x040023CE RID: 9166
		[Token(Token = "0x40023CE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _dropSmoothing;
	}
}
