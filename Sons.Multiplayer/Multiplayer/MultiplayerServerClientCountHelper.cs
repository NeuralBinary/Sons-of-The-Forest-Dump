using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Sons.Multiplayer
{
	// Token: 0x02000035 RID: 53
	[Token(Token = "0x2000035")]
	public class MultiplayerServerClientCountHelper : MonoBehaviour
	{
		// Token: 0x060001BA RID: 442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BA")]
		[Address(RVA = "0x30EB470", Offset = "0x30E9A70", VA = "0x1830EB470")]
		private void OnEnable()
		{
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BB")]
		[Address(RVA = "0x30EB4E0", Offset = "0x30E9AE0", VA = "0x1830EB4E0")]
		private void InitializeClientCountOptions()
		{
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BC")]
		[Address(RVA = "0x30EB7B0", Offset = "0x30E9DB0", VA = "0x1830EB7B0")]
		private void ApplyClientCountToGui(int clientCount)
		{
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x30EB840", Offset = "0x30E9E40", VA = "0x1830EB840")]
		private int ConvertClientCountToOptionIndex(int clientCount)
		{
			return 0;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x60001BE")]
		[Address(RVA = "0x30EB9E0", Offset = "0x30E9FE0", VA = "0x1830EB9E0")]
		private int ConvertOptionIndexToClientCount(int optionIndex)
		{
			return 0;
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BF")]
		[Address(RVA = "0x30EBB50", Offset = "0x30EA150", VA = "0x1830EBB50")]
		public void SetClientCount(int optionIndex)
		{
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001C0")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public MultiplayerServerClientCountHelper()
		{
		}

		// Token: 0x040000C4 RID: 196
		[Token(Token = "0x40000C4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Dropdown _serverClientCountDropdown;

		// Token: 0x040000C5 RID: 197
		[Token(Token = "0x40000C5")]
		[FieldOffset(Offset = "0x28")]
		private int _inputCount;

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x2C")]
		private int _sanitizedCount;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x30")]
		private List<TMP_Dropdown.OptionData> _clientCountOptions;
	}
}
