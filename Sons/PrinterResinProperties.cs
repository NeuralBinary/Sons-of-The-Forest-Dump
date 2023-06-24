using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
[CreateAssetMenu(fileName = "NewPrinterResinProperties", menuName = "Sons/3D Printing/3dPrinterResin")]
public class PrinterResinProperties : ScriptableObject
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x0600010E RID: 270 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x17000021")]
	public Color Color
	{
		[Token(Token = "0x600010E")]
		[Address(RVA = "0xAA8B70", Offset = "0xAA7170", VA = "0x180AA8B70")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x0600010F RID: 271 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x600010F")]
	[Address(RVA = "0x20C00C0", Offset = "0x20BE6C0", VA = "0x1820C00C0")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000110 RID: 272 RVA: 0x00002460 File Offset: 0x00000660
	[Token(Token = "0x6000110")]
	[Address(RVA = "0x2F74710", Offset = "0x2F72D10", VA = "0x182F74710")]
	public bool Equals(PrinterResinProperties otherResin)
	{
		return default(bool);
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000111")]
	[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
	public PrinterResinProperties()
	{
	}

	// Token: 0x04000115 RID: 277
	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _name;

	// Token: 0x04000116 RID: 278
	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _color;
}
