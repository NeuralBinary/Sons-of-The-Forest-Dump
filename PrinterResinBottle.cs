using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

// Token: 0x0200002C RID: 44
[Token(Token = "0x200002C")]
public class PrinterResinBottle : MonoBehaviour
{
	// Token: 0x1700001E RID: 30
	// (get) Token: 0x06000100 RID: 256 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001E")]
	public PrinterResinProperties Properties
	{
		[Token(Token = "0x6000100")]
		[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
		get
		{
			return null;
		}
	}

	// Token: 0x1700001F RID: 31
	// (get) Token: 0x06000101 RID: 257 RVA: 0x00002400 File Offset: 0x00000600
	[Token(Token = "0x1700001F")]
	public int RemainingVolume
	{
		[Token(Token = "0x6000101")]
		[Address(RVA = "0x29ABE30", Offset = "0x29AAE30", VA = "0x1829ABE30")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x06000102 RID: 258 RVA: 0x00002418 File Offset: 0x00000618
	[Token(Token = "0x17000020")]
	public bool IsEmpty
	{
		[Token(Token = "0x6000102")]
		[Address(RVA = "0x29ABDD0", Offset = "0x29AADD0", VA = "0x1829ABDD0")]
		get
		{
			return default(bool);
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000103")]
	[Address(RVA = "0x29ABD10", Offset = "0x29AAD10", VA = "0x1829ABD10")]
	public void PourOut(int amount)
	{
	}

	// Token: 0x06000104 RID: 260 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000104")]
	[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
	public PrinterResinBottle()
	{
	}

	// Token: 0x04000111 RID: 273
	[Token(Token = "0x4000111")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	[ItemIdPicker]
	private int _resinBottleItem;

	// Token: 0x04000112 RID: 274
	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private PrinterResinProperties _resinProperties;
}
