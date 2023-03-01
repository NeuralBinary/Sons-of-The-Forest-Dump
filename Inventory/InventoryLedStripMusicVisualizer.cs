using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Inventory
{
	// Token: 0x020005DC RID: 1500
	[Token(Token = "0x20005DC")]
	[AddComponentMenu("Sons/Inventory/InventoryLedStripMusicVisualizer")]
	public class InventoryLedStripMusicVisualizer : MonoBehaviour
	{
		// Token: 0x06002679 RID: 9849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002679")]
		[Address(RVA = "0x2DA2A90", Offset = "0x2DA1A90", VA = "0x182DA2A90")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600267A RID: 9850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600267A")]
		[Address(RVA = "0x2DA2DF0", Offset = "0x2DA1DF0", VA = "0x182DA2DF0")]
		public InventoryLedStripMusicVisualizer()
		{
		}

		// Token: 0x040022EC RID: 8940
		[Token(Token = "0x40022EC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<LedStrip> _bars;

		// Token: 0x040022ED RID: 8941
		[Token(Token = "0x40022ED")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _heightMultiplier;

		// Token: 0x040022EE RID: 8942
		[Token(Token = "0x40022EE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private FMODSpectrumData _spectrumData;

		// Token: 0x040022EF RID: 8943
		[Token(Token = "0x40022EF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _gainSmoothing;

		// Token: 0x040022F0 RID: 8944
		[Token(Token = "0x40022F0")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _dropSmoothing;
	}
}
