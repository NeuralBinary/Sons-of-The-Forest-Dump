using System;
using System.Collections;
using Il2CppDummyDll;
using NGUI.UI;
using TheForest.Commons.Enums;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003EF RID: 1007
	[Token(Token = "0x20003EF")]
	public class LoadSaveSlotThumbnail : MonoBehaviour
	{
		// Token: 0x06001B1C RID: 6940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1C")]
		[Address(RVA = "0x32B12A0", Offset = "0x32AF8A0", VA = "0x1832B12A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001B1D RID: 6941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001B1D")]
		[Address(RVA = "0x32B1350", Offset = "0x32AF950", VA = "0x1832B1350")]
		private IEnumerator LoadImageRoutine()
		{
			return null;
		}

		// Token: 0x06001B1E RID: 6942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001B1E")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public LoadSaveSlotThumbnail()
		{
		}

		// Token: 0x04001A54 RID: 6740
		[Token(Token = "0x4001A54")]
		[FieldOffset(Offset = "0x20")]
		public UITexture _texture;

		// Token: 0x04001A55 RID: 6741
		[Token(Token = "0x4001A55")]
		[FieldOffset(Offset = "0x28")]
		public Slots _slot;

		// Token: 0x04001A56 RID: 6742
		[Token(Token = "0x4001A56")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public int _slotNum;
	}
}
