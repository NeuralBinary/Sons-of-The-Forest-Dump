using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x0200002B RID: 43
[Token(Token = "0x200002B")]
[CreateAssetMenu(fileName = "NewPrintedItemBlueprint", menuName = "Sons/3D Printing/PrintedItemBlueprint")]
public class PrintedItemBlueprint : ScriptableObject
{
	// Token: 0x17000012 RID: 18
	// (get) Token: 0x060000F1 RID: 241 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000012")]
	public GameObject PrintedItem
	{
		[Token(Token = "0x60000F1")]
		[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000013 RID: 19
	// (get) Token: 0x060000F2 RID: 242 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000013")]
	public string Name
	{
		[Token(Token = "0x60000F2")]
		[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000014 RID: 20
	// (get) Token: 0x060000F3 RID: 243 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x17000014")]
	public Color DefaultColor
	{
		[Token(Token = "0x60000F3")]
		[Address(RVA = "0x219B100", Offset = "0x219A100", VA = "0x18219B100")]
		get
		{
			return default(Color);
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x060000F4 RID: 244 RVA: 0x00002358 File Offset: 0x00000558
	[Token(Token = "0x17000015")]
	public int RequiredResin
	{
		[Token(Token = "0x60000F4")]
		[Address(RVA = "0x6B72E0", Offset = "0x6B62E0", VA = "0x1806B72E0")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x17000016 RID: 22
	// (get) Token: 0x060000F5 RID: 245 RVA: 0x00002370 File Offset: 0x00000570
	[Token(Token = "0x17000016")]
	public float TotalPrintTime
	{
		[Token(Token = "0x60000F5")]
		[Address(RVA = "0x5808F0", Offset = "0x57F8F0", VA = "0x1805808F0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x17000017 RID: 23
	// (get) Token: 0x060000F6 RID: 246 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000017")]
	public Texture IconTexture
	{
		[Token(Token = "0x60000F6")]
		[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
		get
		{
			return null;
		}
	}

	// Token: 0x17000018 RID: 24
	// (get) Token: 0x060000F7 RID: 247 RVA: 0x00002388 File Offset: 0x00000588
	[Token(Token = "0x17000018")]
	public Vector3 PositionOffset
	{
		[Token(Token = "0x60000F7")]
		[Address(RVA = "0x1CD0100", Offset = "0x1CCF100", VA = "0x181CD0100")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x17000019 RID: 25
	// (get) Token: 0x060000F8 RID: 248 RVA: 0x000023A0 File Offset: 0x000005A0
	[Token(Token = "0x17000019")]
	public Quaternion RotationOffset
	{
		[Token(Token = "0x60000F8")]
		[Address(RVA = "0x27F29C0", Offset = "0x27F19C0", VA = "0x1827F29C0")]
		get
		{
			return default(Quaternion);
		}
	}

	// Token: 0x1700001A RID: 26
	// (get) Token: 0x060000F9 RID: 249 RVA: 0x000023B8 File Offset: 0x000005B8
	[Token(Token = "0x1700001A")]
	public Vector3 Scale
	{
		[Token(Token = "0x60000F9")]
		[Address(RVA = "0x22A45D0", Offset = "0x22A35D0", VA = "0x1822A45D0")]
		get
		{
			return default(Vector3);
		}
	}

	// Token: 0x1700001B RID: 27
	// (get) Token: 0x060000FA RID: 250 RVA: 0x000023D0 File Offset: 0x000005D0
	[Token(Token = "0x1700001B")]
	public float PrintBedHeight
	{
		[Token(Token = "0x60000FA")]
		[Address(RVA = "0x20480A0", Offset = "0x20470A0", VA = "0x1820480A0")]
		get
		{
			return default(float);
		}
	}

	// Token: 0x1700001C RID: 28
	// (get) Token: 0x060000FB RID: 251 RVA: 0x000023E8 File Offset: 0x000005E8
	[Token(Token = "0x1700001C")]
	public int Id
	{
		[Token(Token = "0x60000FB")]
		[Address(RVA = "0x986250", Offset = "0x985250", VA = "0x180986250")]
		get
		{
			return default(int);
		}
	}

	// Token: 0x1700001D RID: 29
	// (get) Token: 0x060000FC RID: 252 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001D")]
	public List<Vector3> Positions
	{
		[Token(Token = "0x60000FC")]
		[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
		get
		{
			return null;
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000FD")]
	[Address(RVA = "0x29ABAE0", Offset = "0x29AAAE0", VA = "0x1829ABAE0")]
	public string GetLocalizedName()
	{
		return null;
	}

	// Token: 0x060000FE RID: 254 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FE")]
	[Address(RVA = "0x29ABC30", Offset = "0x29AAC30", VA = "0x1829ABC30")]
	private void OnValidate()
	{
	}

	// Token: 0x060000FF RID: 255 RVA: 0x00002053 File Offset: 0x00000253
	[Token(Token = "0x60000FF")]
	[Address(RVA = "0x29ABC40", Offset = "0x29AAC40", VA = "0x1829ABC40")]
	public PrintedItemBlueprint()
	{
	}

	// Token: 0x04000103 RID: 259
	[Token(Token = "0x4000103")]
	private const string ItemsTableReference = "Items";

	// Token: 0x04000104 RID: 260
	[Token(Token = "0x4000104")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private GameObject _printedItem;

	// Token: 0x04000105 RID: 261
	[Token(Token = "0x4000105")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string _name;

	// Token: 0x04000106 RID: 262
	[Token(Token = "0x4000106")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string _translationKey;

	// Token: 0x04000107 RID: 263
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Texture _iconTexture;

	// Token: 0x04000108 RID: 264
	[Token(Token = "0x4000108")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Color _defaultPrintColor;

	// Token: 0x04000109 RID: 265
	[Token(Token = "0x4000109")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private int _requiredResinVolume;

	// Token: 0x0400010A RID: 266
	[Token(Token = "0x400010A")]
	[FieldOffset(Offset = "0x4C")]
	[SerializeField]
	private float _totalPrintTime;

	// Token: 0x0400010B RID: 267
	[Token(Token = "0x400010B")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private List<Vector3> _positions;

	// Token: 0x0400010C RID: 268
	[Token(Token = "0x400010C")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private float _printBedHeight;

	// Token: 0x0400010D RID: 269
	[Token(Token = "0x400010D")]
	[FieldOffset(Offset = "0x5C")]
	[SerializeField]
	private Vector3 _printPlatePositionOffset;

	// Token: 0x0400010E RID: 270
	[Token(Token = "0x400010E")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Quaternion _printPlateRotationOffset;

	// Token: 0x0400010F RID: 271
	[Token(Token = "0x400010F")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector3 _printPlateScale;

	// Token: 0x04000110 RID: 272
	[Token(Token = "0x4000110")]
	[FieldOffset(Offset = "0x84")]
	[SerializeField]
	private int _id;
}
