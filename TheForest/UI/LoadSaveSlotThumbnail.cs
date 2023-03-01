using System;
using System.Collections;
using Il2CppDummyDll;
using NGUI.UI;
using TheForest.Commons.Enums;
using UnityEngine;

namespace TheForest.UI
{
	// Token: 0x020003FD RID: 1021
	[Token(Token = "0x20003FD")]
	public class LoadSaveSlotThumbnail : MonoBehaviour
	{
		// Token: 0x06001ADE RID: 6878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001ADE")]
		[Address(RVA = "0x2CE54A0", Offset = "0x2CE44A0", VA = "0x182CE54A0")]
		private void OnEnable()
		{
		}

		// Token: 0x06001ADF RID: 6879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001ADF")]
		[Address(RVA = "0x2CE5430", Offset = "0x2CE4430", VA = "0x182CE5430")]
		private IEnumerator LoadImageRoutine()
		{
			return null;
		}

		// Token: 0x06001AE0 RID: 6880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001AE0")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public LoadSaveSlotThumbnail()
		{
		}

		// Token: 0x04001A30 RID: 6704
		[Token(Token = "0x4001A30")]
		[FieldOffset(Offset = "0x20")]
		public UITexture _texture;

		// Token: 0x04001A31 RID: 6705
		[Token(Token = "0x4001A31")]
		[FieldOffset(Offset = "0x28")]
		public Slots _slot;

		// Token: 0x04001A32 RID: 6706
		[Token(Token = "0x4001A32")]
		[FieldOffset(Offset = "0x2C")]
		[HideInInspector]
		public int _slotNum;
	}
}
