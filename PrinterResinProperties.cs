using System;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002D RID: 45
[Token(Token = "0x200002D")]
[CreateAssetMenu(fileName = "NewPrinterResinProperties", menuName = "Sons/3D Printing/3dPrinterResin")]
public class PrinterResinProperties : ScriptableObject
{
	// Token: 0x17000021 RID: 33
	// (get) Token: 0x06000105 RID: 261 RVA: 0x00002430 File Offset: 0x00000630
	[Token(Token = "0x17000021")]
	public Color Color
	{
		[Token(Token = "0x6000105")]
		[Address(RVA = "0x93FC00", Offset = "0x93EC00", VA = "0x18093FC00")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000106")]
	[Address(RVA = "0x1D82720", Offset = "0x1D81720", VA = "0x181D82720")]
	public void SetColor(Color color)
	{
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00002448 File Offset: 0x00000648
	[Token(Token = "0x6000107")]
	[Address(RVA = "0x29ABE90", Offset = "0x29AAE90", VA = "0x1829ABE90")]
	public bool Equals(PrinterResinProperties otherResin)
	{
		return default(bool);
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x6000108")]
	[Address(RVA = "0x539C30", Offset = "0x538C30", VA = "0x180539C30")]
	public PrinterResinProperties()
	{
	}

	// Token: 0x04000113 RID: 275
	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private string _name;

	// Token: 0x04000114 RID: 276
	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Color _color;
}
