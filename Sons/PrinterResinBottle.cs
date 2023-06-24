using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x0200002C RID: 44
[Token(Token = "0x200002C")]
public class PrinterResinBottle : MonoBehaviour
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000109 RID: 265 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001E")]
	public PrinterResinProperties Properties
	{
		[Token(Token = "0x6000109")]
		[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x0600010A RID: 266 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x1700001F")]
	public int RemainingVolume
	{
		[Token(Token = "0x600010A")]
		[Address(RVA = "0x2F74580", Offset = "0x2F72B80", VA = "0x182F74580")]
		get
		{
			return 0;
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x0600010B RID: 267 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x17000020")]
	public bool IsEmpty
	{
		[Token(Token = "0x600010B")]
		[Address(RVA = "0x2F745E0", Offset = "0x2F72BE0", VA = "0x182F745E0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010C")]
	[Address(RVA = "0x2F74640", Offset = "0x2F72C40", VA = "0x182F74640")]
	public void PourOut(int amount)
	{
	}

	// Token: 0x0600010D RID: 269 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010D")]
	[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
	public PrinterResinBottle()
	{
	}

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x20")]
	[ItemIdPicker]
	[SerializeField]
	private int _resinBottleItem;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PrinterResinProperties _resinProperties;
}
